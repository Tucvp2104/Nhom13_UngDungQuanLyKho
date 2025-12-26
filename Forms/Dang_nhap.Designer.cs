namespace QuanLyKho.Forms
{
    partial class Dang_nhap
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
            this.laDangnhap = new System.Windows.Forms.Label();
            this.laTenDN = new System.Windows.Forms.Label();
            this.laMK = new System.Windows.Forms.Label();
            this.textTenDN = new System.Windows.Forms.TextBox();
            this.textMK = new System.Windows.Forms.TextBox();
            this.buttDN = new System.Windows.Forms.Button();
            this.buttDK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laDangnhap
            // 
            this.laDangnhap.AutoSize = true;
            this.laDangnhap.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDangnhap.Location = new System.Drawing.Point(212, 25);
            this.laDangnhap.Name = "laDangnhap";
            this.laDangnhap.Size = new System.Drawing.Size(136, 24);
            this.laDangnhap.TabIndex = 0;
            this.laDangnhap.Text = "ĐĂNG NHẬP";
            this.laDangnhap.Click += new System.EventHandler(this.label1_Click);
            // 
            // laTenDN
            // 
            this.laTenDN.AutoSize = true;
            this.laTenDN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTenDN.Location = new System.Drawing.Point(83, 80);
            this.laTenDN.Name = "laTenDN";
            this.laTenDN.Size = new System.Drawing.Size(103, 17);
            this.laTenDN.TabIndex = 1;
            this.laTenDN.Text = "Tên đăng nhập";
            // 
            // laMK
            // 
            this.laMK.AutoSize = true;
            this.laMK.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laMK.Location = new System.Drawing.Point(83, 160);
            this.laMK.Name = "laMK";
            this.laMK.Size = new System.Drawing.Size(69, 17);
            this.laMK.TabIndex = 2;
            this.laMK.Text = "Mật khẩu";
            // 
            // textTenDN
            // 
            this.textTenDN.Location = new System.Drawing.Point(86, 109);
            this.textTenDN.Name = "textTenDN";
            this.textTenDN.Size = new System.Drawing.Size(355, 20);
            this.textTenDN.TabIndex = 3;
            // 
            // textMK
            // 
            this.textMK.Location = new System.Drawing.Point(86, 197);
            this.textMK.Name = "textMK";
            this.textMK.Size = new System.Drawing.Size(355, 20);
            this.textMK.TabIndex = 4;
            // 
            // buttDN
            // 
            this.buttDN.Location = new System.Drawing.Point(196, 242);
            this.buttDN.Name = "buttDN";
            this.buttDN.Size = new System.Drawing.Size(119, 23);
            this.buttDN.TabIndex = 5;
            this.buttDN.Text = "ĐĂNG NHẬP";
            this.buttDN.UseVisualStyleBackColor = true;
            this.buttDN.Click += new System.EventHandler(this.buttDN_Click);
            // 
            // buttDK
            // 
            this.buttDK.Location = new System.Drawing.Point(216, 374);
            this.buttDK.Name = "buttDK";
            this.buttDK.Size = new System.Drawing.Size(75, 23);
            this.buttDK.TabIndex = 6;
            this.buttDK.Text = "Đăng ký";
            this.buttDK.UseVisualStyleBackColor = true;
            this.buttDK.Click += new System.EventHandler(this.buttDK_Click);
            // 
            // Dang_nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.buttDK);
            this.Controls.Add(this.buttDN);
            this.Controls.Add(this.textMK);
            this.Controls.Add(this.textTenDN);
            this.Controls.Add(this.laMK);
            this.Controls.Add(this.laTenDN);
            this.Controls.Add(this.laDangnhap);
            this.Name = "Dang_nhap";
            this.Text = "Dang_nhap";
            this.Load += new System.EventHandler(this.Dang_nhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laDangnhap;
        private System.Windows.Forms.Label laTenDN;
        private System.Windows.Forms.Label laMK;
        private System.Windows.Forms.TextBox textTenDN;
        private System.Windows.Forms.TextBox textMK;
        private System.Windows.Forms.Button buttDN;
        private System.Windows.Forms.Button buttDK;
    }
}