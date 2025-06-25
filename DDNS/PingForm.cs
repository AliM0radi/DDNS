using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace DDNS
{
    public partial class PingForm : Form
    {
        private Timer pingTimer;
        private string primaryDns;
        private bool isPersian = true;
        private bool isDarkTheme = true;

        public PingForm()
        {
            InitializeComponent();
            InitializePingTimer();
            this.FormClosing += PingForm_FormClosing;
            LoadPrimaryDns();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetTheme(bool isDark)
        {
            isDarkTheme = isDark;

            this.BackgroundImage = isDark
                ? (isPersian ? Properties.Resources.D_pingtest_bg : Properties.Resources.En_D_pingtest_bg)
                : (isPersian ? Properties.Resources.ping_bg : Properties.Resources.Ping_test_en);

            this.btnApply.Image = isDark
                ? (isPersian ? Properties.Resources.D_OK_btn : Properties.Resources.En_D_OK_btn)
                : (isPersian ? Properties.Resources.OK_btn : Properties.Resources.okbtn_en);
        }

        public void SetLanguage(bool isPersian)
        {
            this.isPersian = isPersian;

            // اعمال مجدد تم با زبان جدید
            SetTheme(isDarkTheme);
        }

        private void InitializePingTimer()
        {
            pingTimer = new Timer();
            pingTimer.Interval = 500; // هر ۵۰۰ میلی‌ثانیه
            pingTimer.Tick += PingTimer_Tick;
        }

        private void LoadPrimaryDns()
        {
            var dnsList = GetCurrentDnsServers();
            if (dnsList.Count > 0)
            {
                primaryDns = dnsList[0];
                lblDns.Text = primaryDns;
                pingTimer.Start();
            }
            else
            {
                lblDns.Text = isPersian ? "یافت نشد" : "Not found";
                lblPing.Text = "-";
            }
        }

        private void PingTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send(primaryDns, 1000);
                    lblPing.Text = reply.Status == IPStatus.Success
                        ? $"{reply.RoundtripTime} ms"
                        : (isPersian ? "درخواست بی‌پاسخ" : "Request timed out.");
                }
            }
            catch
            {
                lblPing.Text = isPersian ? "خطا" : "Error";
            }
        }

        private List<string> GetCurrentDnsServers()
        {
            var dnsServers = new List<string>();

            foreach (var ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up &&
                    ni.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    var props = ni.GetIPProperties();
                    foreach (var dns in props.DnsAddresses)
                    {
                        if (dns.AddressFamily == AddressFamily.InterNetwork)
                            dnsServers.Add(dns.ToString());
                    }
                }
            }

            return dnsServers;
        }

        private void PingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pingTimer != null)
            {
                pingTimer.Stop();
                pingTimer.Tick -= PingTimer_Tick;
                pingTimer.Dispose();
                pingTimer = null;
            }
        }
    }
}
