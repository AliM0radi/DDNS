using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDNS
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        // بستن فرم درباره من
        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // اعمال تم تاریک یا روشن به فرم و دکمه‌ها
        public void SetTheme(bool isDark)
        {
            // تغییر تصویر پس‌زمینه و آیکون‌ها بر اساس تم انتخاب‌شده
            this.BackgroundImage = isDark ? Properties.Resources.D_About_me_bg : Properties.Resources.About_me_bg;
            Telegram_Btn.Image = isDark ? Properties.Resources.D_Telegram : Properties.Resources.Telegram;
            Instagram_Btn.Image = isDark ? Properties.Resources.D_Instagram : Properties.Resources.Instagram;
            Github_Btn.Image = isDark ? Properties.Resources.D_Github : Properties.Resources.Github;
            Figma_Btn.Image = isDark ? Properties.Resources.D_Figma : Properties.Resources.Figma;
            Close_btn.Image = isDark ? Properties.Resources.En_D_OK_btn : Properties.Resources.okbtn_en;
        }

        //باز کردن کانال تلگرام
        private void Telegram_Btn_Click(object sender, EventArgs e)
        {
            string telegramUrl = "https://t.me/Demudns";
            try
            {
                System.Diagnostics.Process.Start(telegramUrl);
            }
            catch
            {
                MessageBox.Show("Default browser not found.");
            }
        }

        //باز کردن صفحه اینستاگرام
        private void Instagram_Btn_Click(object sender, EventArgs e)
        {
            string instagramUrl = "https://www.instagram.com/demureytion.graphic";
            try
            {
                System.Diagnostics.Process.Start(instagramUrl);
            }
            catch
            {
                MessageBox.Show("Default browser not found.");
            }
        }

        //باز کردن گیت‌هاب
        private void Github_Btn_Click(object sender, EventArgs e)
        {
            string githubUrl = "https://github.com/AliM0radi/DDNS/releases";
            try
            {
                System.Diagnostics.Process.Start(githubUrl);
            }
            catch
            {
                MessageBox.Show("Default browser not found.");
            }
        }

        //باز کردن طرح در فیگما
        private void Figma_Btn_Click(object sender, EventArgs e)
        {
            string figmaUrl = "https://www.figma.com/design/6RDmW4P8Um865YAc94lpDz/Dns?node-id=0-1&t=I9N93RJgj35LG6RF-1";
            try
            {
                System.Diagnostics.Process.Start(figmaUrl);
            }
            catch
            {
                MessageBox.Show("Default browser not found.");
            }
        }
    }
}