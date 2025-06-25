using System;
using System.Windows.Forms;

namespace DDNS
{
    public partial class CustomDNSForm : Form
    {
        public string Dns1 => txtDns1.Text.Trim(); // DNS اولیه
        public string Dns2 => txtDns2.Text.Trim(); // DNS ثانویه

        private bool isDarkTheme = true; //تعیین وضعیت تم
        private bool isPersian = true;   //تعیین زبان

        public CustomDNSForm()
        {
            InitializeComponent();
        }

        //خروج
        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //تغییر dns به انتخاب کاربر
        private void btnApply_Click(object sender, EventArgs e)
        {
            // بررسی اینکه آیا DNS اولیه وارد شده یا نه
            if (string.IsNullOrWhiteSpace(Dns1))
            {
                MessageBox.Show(
                    isPersian ? "!لطفاً دی ان اس اولیه را وارد کنید" : "Please enter the primary DNS!",
                    isPersian ? "خطا" : "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            //بستن فرم در صورت نبودن مشکل
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //تغییر تم
        public void SetTheme(bool isDark)
        {
            isDarkTheme = isDark;

            this.BackgroundImage = isDark
                ? (isPersian ? Properties.Resources.D_Custom_dns_form_bg : Properties.Resources.En_D_Custom_bg)
                : (isPersian ? Properties.Resources.costum_dns_form_bg_fa : Properties.Resources.Customdns_en);

            btnApply.Image = isDark
                ? (isPersian ? Properties.Resources.D_OK_btn : Properties.Resources.En_D_OK_btn)
                : (isPersian ? Properties.Resources.OK_btn : Properties.Resources.okbtn_en);

            Cancel_Btn.Image = isDark
                ? (isPersian ? Properties.Resources.D_Cancel_btn : Properties.Resources.En_D_Cancel_btn)
                : (isPersian ? Properties.Resources.Cancel_btn : Properties.Resources.cancelbtn_en);
        }

        //متدی برای تنظیم زبان فرم و به‌روزرسانی تم بر اساس زبان جدید
        public void SetLanguage(bool isPersian)
        {
            this.isPersian = isPersian;
            SetTheme(isDarkTheme);
        }
    }
}
