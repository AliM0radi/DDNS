﻿namespace DDNS
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.Telegram_Btn = new System.Windows.Forms.PictureBox();
            this.Instagram_Btn = new System.Windows.Forms.PictureBox();
            this.Github_Btn = new System.Windows.Forms.PictureBox();
            this.Close_btn = new System.Windows.Forms.PictureBox();
            this.Figma_Btn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Telegram_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Instagram_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Github_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Figma_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // Telegram_Btn
            // 
            this.Telegram_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Telegram_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Telegram_Btn.Image = global::DDNS.Properties.Resources.D_Telegram;
            this.Telegram_Btn.Location = new System.Drawing.Point(199, 355);
            this.Telegram_Btn.Name = "Telegram_Btn";
            this.Telegram_Btn.Size = new System.Drawing.Size(53, 53);
            this.Telegram_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Telegram_Btn.TabIndex = 11;
            this.Telegram_Btn.TabStop = false;
            this.Telegram_Btn.Click += new System.EventHandler(this.Telegram_Btn_Click);
            // 
            // Instagram_Btn
            // 
            this.Instagram_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Instagram_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Instagram_Btn.Image = global::DDNS.Properties.Resources.D_Instagram;
            this.Instagram_Btn.Location = new System.Drawing.Point(349, 355);
            this.Instagram_Btn.Name = "Instagram_Btn";
            this.Instagram_Btn.Size = new System.Drawing.Size(53, 53);
            this.Instagram_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Instagram_Btn.TabIndex = 12;
            this.Instagram_Btn.TabStop = false;
            this.Instagram_Btn.Click += new System.EventHandler(this.Instagram_Btn_Click);
            // 
            // Github_Btn
            // 
            this.Github_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Github_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Github_Btn.Image = global::DDNS.Properties.Resources.D_Github;
            this.Github_Btn.Location = new System.Drawing.Point(649, 355);
            this.Github_Btn.Name = "Github_Btn";
            this.Github_Btn.Size = new System.Drawing.Size(53, 53);
            this.Github_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Github_Btn.TabIndex = 13;
            this.Github_Btn.TabStop = false;
            this.Github_Btn.Click += new System.EventHandler(this.Github_Btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.Transparent;
            this.Close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_btn.Image = global::DDNS.Properties.Resources.En_D_OK_btn;
            this.Close_btn.Location = new System.Drawing.Point(378, 451);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(145, 66);
            this.Close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_btn.TabIndex = 14;
            this.Close_btn.TabStop = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Figma_Btn
            // 
            this.Figma_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Figma_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Figma_Btn.Image = global::DDNS.Properties.Resources.D_Figma;
            this.Figma_Btn.Location = new System.Drawing.Point(499, 355);
            this.Figma_Btn.Name = "Figma_Btn";
            this.Figma_Btn.Size = new System.Drawing.Size(53, 53);
            this.Figma_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Figma_Btn.TabIndex = 15;
            this.Figma_Btn.TabStop = false;
            this.Figma_Btn.Click += new System.EventHandler(this.Figma_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "v1.1";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DDNS.Properties.Resources.D_About_me_bg;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Figma_Btn);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Github_Btn);
            this.Controls.Add(this.Instagram_Btn);
            this.Controls.Add(this.Telegram_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Me";
            ((System.ComponentModel.ISupportInitialize)(this.Telegram_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Instagram_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Github_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Figma_Btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Telegram_Btn;
        private System.Windows.Forms.PictureBox Instagram_Btn;
        private System.Windows.Forms.PictureBox Github_Btn;
        private System.Windows.Forms.PictureBox Close_btn;
        private System.Windows.Forms.PictureBox Figma_Btn;
        private System.Windows.Forms.Label label1;
    }
}