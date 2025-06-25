using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDNS
{
    public partial class Form1 : Form
    {
        private bool isDarkTheme = true;    //تعیین وضعیت تم
        private bool isPersian = true;      //تعیین زبان
        public Form1()
        {
            InitializeComponent();
        }

        //دکمه خروج
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //دکمه مینیمایز
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //تغییر dns به گوگل
        private void Google_Btn_Click(object sender, EventArgs e)
        {
            string dns1 = "8.8.8.8";
            string dns2 = "8.8.4.4";

            string iface = GetActiveInterfaceName();
            if (iface == null)
            {
                MessageBox.Show(isPersian ? "کارت شبکه فعال پیدا نشد" : "No active network interface found");
                return;
            }

            this.Select_DNS.Visible = false;
            this.Change_DNS.Visible = true;

            if (!isDarkTheme)
            { this.BackgroundImage = global::DDNS.Properties.Resources.google_bg; }
            else { this.BackgroundImage = global::DDNS.Properties.Resources.D_Google_bg; }

            RunNetsh($"interface ip set dns name=\"{iface}\" static {dns1}");
            RunNetsh($"interface ip add dns name=\"{iface}\" {dns2} index=2");
        }

        //بازنشانی dns به حالت خودکار
        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            string iface = GetActiveInterfaceName();
            if (iface == null)
            {
                MessageBox.Show(isPersian ? "کارت شبکه فعال پیدا نشد" : "No active network interface found");
                return;
            }

            this.Select_DNS.Visible = true;
            this.Change_DNS.Visible = false;

            if (!isDarkTheme)
            { this.BackgroundImage = global::DDNS.Properties.Resources.Dns_bg; }
            else { this.BackgroundImage = global::DDNS.Properties.Resources.D_DNS_bg; }
            RunNetsh($"interface ip set dns name=\"{iface}\" dhcp");
        }

        //اجرای دستور netsh با دسترسی ادمین
        private void RunNetsh(string args)
        {
            try
            {
                Process.Start(new ProcessStartInfo("netsh", args)
                {
                    Verb = "runas",
                    WindowStyle = ProcessWindowStyle.Hidden
                });
            }
            catch
            {
                MessageBox.Show(isPersian ? "دسترسی Administrator مورد نیاز است." : "Administrator privileges are required.");
            }
        }

        //به‌دست‌آوردن نام کارت شبکه فعال
        private string GetActiveInterfaceName()
        {
            var interfaces = NetworkInterface.GetAllNetworkInterfaces()
                .Where(n =>
                    n.OperationalStatus == OperationalStatus.Up &&
                    n.NetworkInterfaceType != NetworkInterfaceType.Loopback &&
                    n.GetIPProperties().GatewayAddresses.Count > 0
                );

            return interfaces.FirstOrDefault()?.Name;
        }

        //تغییر dns به شکن
        private void Shecan_Btn_Click(object sender, EventArgs e)
        {
            string dns1 = "178.22.122.100";
            string dns2 = "185.51.200.2";

            string iface = GetActiveInterfaceName();
            if (iface == null)
            {
                MessageBox.Show(isPersian ? "کارت شبکه فعال پیدا نشد" : "No active network interface found");
                return;
            }

            this.Select_DNS.Visible = false;
            this.Change_DNS.Visible = true;

            if (!isDarkTheme)
            { this.BackgroundImage = global::DDNS.Properties.Resources.Shecan_bg; }
            else { this.BackgroundImage = global::DDNS.Properties.Resources.D_Shecan_bg; }
            RunNetsh($"interface ip set dns name=\"{iface}\" static {dns1}");
            RunNetsh($"interface ip add dns name=\"{iface}\" {dns2} index=2");
        }

        //تغییر dns به الکترو
        private void Electeo_Btn_Click(object sender, EventArgs e)
        {
            string dns1 = "78.157.42.100";
            string dns2 = "78.157.42.101";

            string iface = GetActiveInterfaceName();
            if (iface == null)
            {
                MessageBox.Show(isPersian ? "کارت شبکه فعال پیدا نشد" : "No active network interface found");
                return;
            }

            this.Select_DNS.Visible = false;
            this.Change_DNS.Visible = true;

            if (!isDarkTheme)
            { this.BackgroundImage = global::DDNS.Properties.Resources.electro_bg; }
            else { this.BackgroundImage = global::DDNS.Properties.Resources.D_Electro_bg; }
            RunNetsh($"interface ip set dns name=\"{iface}\" static {dns1}");
            RunNetsh($"interface ip add dns name=\"{iface}\" {dns2} index=2");
        }

        //تغییر dns به رادارگیم
        private void Radar_Btn_Click(object sender, EventArgs e)
        {
            string dns1 = "10.202.10.10";
            string dns2 = "10.202.10.11";

            string iface = GetActiveInterfaceName();
            if (iface == null)
            {
                MessageBox.Show(isPersian ? "کارت شبکه فعال پیدا نشد" : "No active network interface found");
                return;
            }

            this.Select_DNS.Visible = false;
            this.Change_DNS.Visible = true;

            if (!isDarkTheme)
            { this.BackgroundImage = global::DDNS.Properties.Resources.radar_bg; }
            else { this.BackgroundImage = global::DDNS.Properties.Resources.D_Radar_bg; }
            RunNetsh($"interface ip set dns name=\"{iface}\" static {dns1}");
            RunNetsh($"interface ip add dns name=\"{iface}\" {dns2} index=2");
        }

        //تغییر dns به بگذز
        private void Begzar_Btn_Click(object sender, EventArgs e)
        {
            string dns1 = "185.55.226.25";
            string dns2 = "185.55.226.26";

            string iface = GetActiveInterfaceName();
            if (iface == null)
            {
                MessageBox.Show(isPersian ? "کارت شبکه فعال پیدا نشد" : "No active network interface found");
                return;
            }

            this.Select_DNS.Visible = false;
            this.Change_DNS.Visible = true;

            if (!isDarkTheme)
            { this.BackgroundImage = global::DDNS.Properties.Resources.begzar_bg; }
            else { this.BackgroundImage = global::DDNS.Properties.Resources.D_Begzar_bg; }
            RunNetsh($"interface ip set dns name=\"{iface}\" static {dns1}");
            RunNetsh($"interface ip add dns name=\"{iface}\" {dns2} index=2");
        }

        //تغییر dns به کلودفلر
        private void One_Btn_Click(object sender, EventArgs e)
        {
            string dns1 = "1.1.1.1";
            string dns2 = "1.0.0.1";

            string iface = GetActiveInterfaceName();
            if (iface == null)
            {
                MessageBox.Show(isPersian ? "کارت شبکه فعال پیدا نشد" : "No active network interface found");
                return;
            }

            this.Select_DNS.Visible = false;
            this.Change_DNS.Visible = true;

            if (!isDarkTheme)
            { this.BackgroundImage = global::DDNS.Properties.Resources.one_bg; }
            else { this.BackgroundImage = global::DDNS.Properties.Resources.D_One_bg; }
            RunNetsh($"interface ip set dns name=\"{iface}\" static {dns1}");
            RunNetsh($"interface ip add dns name=\"{iface}\" {dns2} index=2");
        }

        //تغییر تم از دارک به لایت و برعکس
        private void Theme_Btn_Click(object sender, EventArgs e)
        {
            isDarkTheme = !isDarkTheme;

            if (isDarkTheme)
            {
                this.BackgroundImage = global::DDNS.Properties.Resources.D_DNS_bg;
                this.Google_Btn.Image = global::DDNS.Properties.Resources.D_btn_google;
                this.Shecan_Btn.Image = global::DDNS.Properties.Resources.D_btn_shecan;
                this.Electeo_Btn.Image = global::DDNS.Properties.Resources.D_btn_electro;
                this.Radar_Btn.Image = global::DDNS.Properties.Resources.D_btn_radar;
                this.Begzar_Btn.Image = global::DDNS.Properties.Resources.D_btn_bogzar;
                this.One_Btn.Image = global::DDNS.Properties.Resources.D_btn_one;
                this.Reset_Btn.Image = global::DDNS.Properties.Resources.D_resetbtn;
                this.Custom_Btn.Image = global::DDNS.Properties.Resources.D_custombtn;
                this.Ping_Btn.Image = global::DDNS.Properties.Resources.D_ping;
                this.Language_Btn.Image = global::DDNS.Properties.Resources.D_language;
                this.Theme_Btn.Image = global::DDNS.Properties.Resources.D_dark_mode;
            }
            else
            {
                this.BackgroundImage = global::DDNS.Properties.Resources.Dns_bg;
                this.Google_Btn.Image = global::DDNS.Properties.Resources.google;
                this.Shecan_Btn.Image = global::DDNS.Properties.Resources.shecan;
                this.Electeo_Btn.Image = global::DDNS.Properties.Resources.electro;
                this.Radar_Btn.Image = global::DDNS.Properties.Resources.radar;
                this.Begzar_Btn.Image = global::DDNS.Properties.Resources.bogzar;
                this.One_Btn.Image = global::DDNS.Properties.Resources.one;
                this.Reset_Btn.Image = global::DDNS.Properties.Resources.resetbtn;
                this.Custom_Btn.Image = global::DDNS.Properties.Resources.custombtn;
                this.Ping_Btn.Image = global::DDNS.Properties.Resources.ping;
                this.Language_Btn.Image = global::DDNS.Properties.Resources.language;
                this.Theme_Btn.Image = global::DDNS.Properties.Resources.dark_mode;
            }

            UpdateLanguage();
        }

        //تغییر به DNS مورد نظر کاربر
        private void Custom_Btn_Click(object sender, EventArgs e)
        {
            var customForm = new CustomDNSForm();
            customForm.SetLanguage(isPersian);
            customForm.SetTheme(isDarkTheme);

            if (customForm.ShowDialog() == DialogResult.OK)
            {
                string dns1 = customForm.Dns1;
                string dns2 = customForm.Dns2;

                string iface = GetActiveInterfaceName();
                if (iface == null)
                {
                    MessageBox.Show(isPersian ? "کارت شبکه فعال پیدا نشد" : "No active network interface found");
                    return;
                }

                Select_DNS.Visible = false;
                Change_DNS.Visible = true;

                this.BackgroundImage = isDarkTheme
                    ? Properties.Resources.D_Custom_bg
                    : Properties.Resources.Custom_bg;

                RunNetsh($"interface ip set dns name=\"{iface}\" static {dns1}");
                if (!string.IsNullOrWhiteSpace(dns2))
                    RunNetsh($"interface ip add dns name=\"{iface}\" {dns2} index=2");
            }
        }

        //بازکردن فرم پینگ
        private void Ping_Btn_Click(object sender, EventArgs e)
        {
            using (PingForm form = new PingForm())
            {
                form.SetLanguage(isPersian);
                form.SetTheme(isDarkTheme);
                form.ShowDialog();
            }
        }

        //تغییر زبان
        private void Language_Btn_Click(object sender, EventArgs e)
        {
            isPersian = !isPersian;

            UpdateLanguage();
        }

        //بر اساس isPersian مشخص می کند که زبان از فارسی به انگلیسی تغییر کند یا برعکس
        private void UpdateLanguage()
        {
            if (isDarkTheme)
            {
                Google_Btn.Image = isPersian ? Properties.Resources.D_btn_google : Properties.Resources.En_D_google;
                Shecan_Btn.Image = isPersian ? Properties.Resources.D_btn_shecan : Properties.Resources.En_D_shecan;
                Electeo_Btn.Image = isPersian ? Properties.Resources.D_btn_electro : Properties.Resources.En_D_electro;
                Radar_Btn.Image = isPersian ? Properties.Resources.D_btn_radar : Properties.Resources.En_D_radar;
                Begzar_Btn.Image = isPersian ? Properties.Resources.D_btn_bogzar : Properties.Resources.En_D_Btn_bogzar;
                One_Btn.Image = isPersian ? Properties.Resources.D_btn_one : Properties.Resources.En_D_one;
                Reset_Btn.Image = isPersian ? Properties.Resources.D_resetbtn : Properties.Resources.En_D_resetbtn;
                Custom_Btn.Image = isPersian ? Properties.Resources.D_custombtn : Properties.Resources.En_D_custombtn;
                Ping_Btn.Image = isPersian ? Properties.Resources.D_ping : Properties.Resources.En_D_ping;
                Language_Btn.Image = isPersian ? Properties.Resources.D_language : Properties.Resources.En_D_language;
                Theme_Btn.Image = isPersian ? Properties.Resources.D_dark_mode : Properties.Resources.En_D_dark_mode;
                Select_DNS.Image = isPersian ? Properties.Resources.select_fa : Properties.Resources.SELECT_DNS_en;
                Change_DNS.Image = isPersian ? Properties.Resources.Dns_change_fa : Properties.Resources.DNS_changed_en;
                if (!isPersian)
                {
                    Change_DNS.Size = Change_DNS.Image.Size;
                    Change_DNS.Location = new Point(
                        this.ClientSize.Width - Change_DNS.Width - 190,70);
                }
                else
                {
                    Change_DNS.Size = Change_DNS.Image.Size;
                    Change_DNS.Location = new Point(
                        this.ClientSize.Width - Change_DNS.Width - 90, 95);
                }
            }
            else
            {
                Google_Btn.Image = isPersian ? Properties.Resources.google : Properties.Resources.google_en;
                Shecan_Btn.Image = isPersian ? Properties.Resources.shecan : Properties.Resources.shecan_en;
                Electeo_Btn.Image = isPersian ? Properties.Resources.electro : Properties.Resources.electro_en;
                Radar_Btn.Image = isPersian ? Properties.Resources.radar : Properties.Resources.radar_en;
                Begzar_Btn.Image = isPersian ? Properties.Resources.bogzar : Properties.Resources.bogzar_en;
                One_Btn.Image = isPersian ? Properties.Resources.one : Properties.Resources.one_en;
                Reset_Btn.Image = isPersian ? Properties.Resources.resetbtn : Properties.Resources.resetbtn_en;
                Custom_Btn.Image = isPersian ? Properties.Resources.custombtn : Properties.Resources.custombtn_en;
                Ping_Btn.Image = isPersian ? Properties.Resources.ping : Properties.Resources.ping_en;
                Language_Btn.Image = isPersian ? Properties.Resources.language : Properties.Resources.language_en;
                Theme_Btn.Image = isPersian ? Properties.Resources.dark_mode : Properties.Resources.dark_mode_en;
                Select_DNS.Image = isPersian ? Properties.Resources.select_fa : Properties.Resources.SELECT_DNS_en;
                Change_DNS.Image = isPersian ? Properties.Resources.Dns_change_fa : Properties.Resources.DNS_changed_en;
                if (!isPersian)
                {
                    Change_DNS.Size = Change_DNS.Image.Size;
                    Change_DNS.Location = new Point(
                        this.ClientSize.Width - Change_DNS.Width - 190, 70);
                }
                else
                {
                    Change_DNS.Size = Change_DNS.Image.Size;
                    Change_DNS.Location = new Point(
                        this.ClientSize.Width - Change_DNS.Width - 90, 95);
                }
            }
        }

        //باز کردن فرم درباره من
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            using (AboutForm form = new AboutForm())
            {
                form.SetTheme(isDarkTheme);     
                form.ShowDialog();
            }
        }
    }
}
