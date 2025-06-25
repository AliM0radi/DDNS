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

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetTheme(bool isDark)
        {
            this.BackgroundImage = isDark ? Properties.Resources.D_About_me_bg : Properties.Resources.About_me_bg;
            Telegram_Btn.Image = isDark ? Properties.Resources.D_Telegram : Properties.Resources.Telegram;
            Instagram_Btn.Image = isDark ? Properties.Resources.D_Instagram : Properties.Resources.Instagram;
            Github_Btn.Image = isDark ? Properties.Resources.D_Github : Properties.Resources.Github;
            Close_btn.Image = isDark ? Properties.Resources.En_D_OK_btn : Properties.Resources.okbtn_en;
        }

        private void Telegram_Btn_Click(object sender, EventArgs e)
        {
            string instagramUrl = "https://t.me/Demudns";
            try
            {
                System.Diagnostics.Process.Start(instagramUrl);
            }
            catch
            {
                MessageBox.Show("Default browser not found.");
            }
        }

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
    }
}
