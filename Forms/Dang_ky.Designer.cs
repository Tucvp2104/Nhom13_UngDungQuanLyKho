namespace QuanLyKho.Forms
{
    partial class Dang_ky
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
            this.laDK = new System.Windows.Forms.Label();
            this.laTenDN = new System.Windows.Forms.Label();
            this.laEmail = new System.Windows.Forms.Label();
            this.laMK = new System.Windows.Forms.Label();
            this.laNhapLaiMK = new System.Windows.Forms.Label();
            this.textTenDN = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textRePass = new System.Windows.Forms.TextBox();
            this.buttDK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laDK
            // 
            this.laDK.AutoSize = true;
            this.laDK.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDK.Location = new System.Drawing.Point(352, 24);
            this.laDK.Name = "laDK";
            this.laDK.Size = new System.Drawing.Size(101, 24);
            this.laDK.TabIndex = 0;
            this.laDK.Text = "ĐĂNG KÝ";
            // 
            // laTenDN
            // 
            this.laTenDN.AutoSize = true;
            this.laTenDN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTenDN.Location = new System.Drawing.Point(71, 68);
            this.laTenDN.Name = "laTenDN";
            this.laTenDN.Size = new System.Drawing.Size(91, 15);
            this.laTenDN.TabIndex = 1;
            this.laTenDN.Text = "Tên Đăng Nhập";
            // 
            // laEmail
            // 
            this.laEmail.AutoSize = true;
            this.laEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laEmail.Location = new System.Drawing.Point(71, 148);
            this.laEmail.Name = "laEmail";
            this.laEmail.Size = new System.Drawing.Size(38, 15);
            this.laEmail.TabIndex = 2;
            this.laEmail.Text = "Email";
            // 
            // laMK
            // 
            this.laMK.AutoSize = true;
            this.laMK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laMK.Location = new System.Drawing.Point(71, 225);
            this.laMK.Name = "laMK";
            this.laMK.Size = new System.Drawing.Size(60, 15);
            this.laMK.TabIndex = 3;
            this.laMK.Text = "Mật Khẩu";
            // 
            // laNhapLaiMK
            // 
            this.laNhapLaiMK.AutoSize = true;
            this.laNhapLaiMK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laNhapLaiMK.Location = new System.Drawing.Point(71, 299);
            this.laNhapLaiMK.Name = "laNhapLaiMK";
            this.laNhapLaiMK.Size = new System.Drawing.Size(111, 15);
            this.laNhapLaiMK.TabIndex = 4;
            this.laNhapLaiMK.Text = "Nhập Lại Mật khẩu";
            // 
            // textTenDN
            // 
            this.textTenDN.Location = new System.Drawing.Point(199, 65);
            this.textTenDN.Name = "textTenDN";
            this.textTenDN.Size = new System.Drawing.Size(414, 20);
            this.textTenDN.TabIndex = 5;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(199, 148);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(414, 20);
            this.textEmail.TabIndex = 6;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(199, 225);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(414, 20);
            this.textPass.TabIndex = 7;
            // 
            // textRePass
            // 
            this.textRePass.Location = new System.Drawing.Point(199, 299);
            this.textRePass.Name = "textRePass";
            this.textRePass.Size = new System.Drawing.Size(414, 20);
            this.textRePass.TabIndex = 8;
            // 
            // buttDK
            // 
            this.buttDK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttDK.Location = new System.Drawing.Point(358, 372);
            this.buttDK.Name = "buttDK";
            this.buttDK.Size = new System.Drawing.Size(75, 23);
            this.buttDK.TabIndex = 9;
            this.buttDK.Text = "ĐĂNG KÝ";
            this.buttDK.UseVisualStyleBackColor = true;
            this.buttDK.Click += new System.EventHandler(this.buttDK_Click);
            // 
            // Dang_ky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.buttDK);
            this.Controls.Add(this.textRePass);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textTenDN);
            this.Controls.Add(this.laNhapLaiMK);
            this.Controls.Add(this.laMK);
            this.Controls.Add(this.laEmail);
            this.Controls.Add(this.laTenDN);
            this.Controls.Add(this.laDK);
            this.Name = "Dang_ky";
            this.Text = "Dang_ky";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laDK;
        private System.Windows.Forms.Label laTenDN;
        private System.Windows.Forms.Label laEmail;
        private System.Windows.Forms.Label laMK;
        private System.Windows.Forms.Label laNhapLaiMK;
        private System.Windows.Forms.TextBox textTenDN;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textRePass;
        private System.Windows.Forms.Button buttDK;
    }
}