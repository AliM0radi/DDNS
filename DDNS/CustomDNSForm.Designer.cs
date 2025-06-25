namespace DDNS
{
    partial class CustomDNSForm
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
            this.txtDns1 = new System.Windows.Forms.TextBox();
            this.txtDns2 = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.PictureBox();
            this.Cancel_Btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDns1
            // 
            this.txtDns1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDns1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDns1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDns1.Location = new System.Drawing.Point(369, 222);
            this.txtDns1.Name = "txtDns1";
            this.txtDns1.Size = new System.Drawing.Size(184, 28);
            this.txtDns1.TabIndex = 0;
            // 
            // txtDns2
            // 
            this.txtDns2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDns2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDns2.Location = new System.Drawing.Point(369, 298);
            this.txtDns2.Name = "txtDns2";
            this.txtDns2.Size = new System.Drawing.Size(184, 28);
            this.txtDns2.TabIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.Transparent;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Image = global::DDNS.Properties.Resources.D_OK_btn;
            this.btnApply.Location = new System.Drawing.Point(497, 408);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(182, 80);
            this.btnApply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnApply.TabIndex = 2;
            this.btnApply.TabStop = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Cancel_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_Btn.Image = global::DDNS.Properties.Resources.D_Cancel_btn;
            this.Cancel_Btn.Location = new System.Drawing.Point(221, 408);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(182, 80);
            this.Cancel_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Cancel_Btn.TabIndex = 3;
            this.Cancel_Btn.TabStop = false;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // CustomDNSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DDNS.Properties.Resources.D_Custom_dns_form_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtDns2);
            this.Controls.Add(this.txtDns1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomDNSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomDNSForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel_Btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDns1;
        private System.Windows.Forms.TextBox txtDns2;
        private System.Windows.Forms.PictureBox btnApply;
        private System.Windows.Forms.PictureBox Cancel_Btn;
    }
}