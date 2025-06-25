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
        private Timer pingTimer;           // تایمر برای اجرای پینگ به‌صورت دوره‌ای
        private string primaryDns;         // نگهداری آدرس DNS اصلی برای پینگ
        private bool isPersian = true;     //تعیین زبان
        private bool isDarkTheme = true;   //تعیین وضعیت تم

        public PingForm()
        {
            InitializeComponent();
            InitializePingTimer();
            this.FormClosing += PingForm_FormClosing;
            LoadPrimaryDns();    // بارگذاری DNS فعلی سیستم
        }

        //خروج
        private void btnApply_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //تغییر تم
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

        // تنظیم زبان فرم و به‌روزرسانی تم با زبان جدید
        public void SetLanguage(bool isPersian)
        {
            this.isPersian = isPersian;
            SetTheme(isDarkTheme);
        }

        // مقداردهی اولیه تایمر پینگ
        private void InitializePingTimer()
        {
            pingTimer = new Timer();
            pingTimer.Interval = 500; // تنظیم بازه زمانی هر نیم ثانیه
            pingTimer.Tick += PingTimer_Tick;
        }

        // گرفتن اولین آدرس DNS از تنظیمات فعلی شبکه و شروع تایمر پینگ
        private void LoadPrimaryDns()
        {
            var dnsList = GetCurrentDnsServers();
            if (dnsList.Count > 0)
            {
                primaryDns = dnsList[0];         // استفاده از اولین DNS برای تست پینگ
                lblDns.Text = primaryDns;
                pingTimer.Start();
            }
            else
            {
                lblDns.Text = isPersian ? "یافت نشد" : "Not found";
                lblPing.Text = "-";
            }
        }

        // رویداد تایمر برای انجام پینگ به DNS اصلی و نمایش نتیجه
        private void PingTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send(primaryDns, 500); // پینگ با زمان‌انتظار 500 میلی‌ثانیه
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

        // دریافت لیست DNS های فعلی فعال سیستم
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

        //بستن فرم و توقف تایمر
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
