namespace DDNS
{
    partial class PingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingForm));
            this.lblDns = new System.Windows.Forms.Label();
            this.lblPing = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnApply)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDns
            // 
            this.lblDns.AutoSize = true;
            this.lblDns.BackColor = System.Drawing.Color.Transparent;
            this.lblDns.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDns.ForeColor = System.Drawing.Color.White;
            this.lblDns.Location = new System.Drawing.Point(373, 228);
            this.lblDns.Name = "lblDns";
            this.lblDns.Size = new System.Drawing.Size(0, 29);
            this.lblDns.TabIndex = 0;
            // 
            // lblPing
            // 
            this.lblPing.AutoSize = true;
            this.lblPing.BackColor = System.Drawing.Color.Transparent;
            this.lblPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPing.ForeColor = System.Drawing.Color.White;
            this.lblPing.Location = new System.Drawing.Point(373, 302);
            this.lblPing.Name = "lblPing";
            this.lblPing.Size = new System.Drawing.Size(0, 29);
            this.lblPing.TabIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.Transparent;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Image = global::DDNS.Properties.Resources.D_OK_btn;
            this.btnApply.Location = new System.Drawing.Point(357, 407);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(182, 80);
            this.btnApply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnApply.TabIndex = 3;
            this.btnApply.TabStop = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // PingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DDNS.Properties.Resources.D_pingtest_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblPing);
            this.Controls.Add(this.lblDns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.btnApply)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDns;
        private System.Windows.Forms.Label lblPing;
        private System.Windows.Forms.PictureBox btnApply;
    }
}