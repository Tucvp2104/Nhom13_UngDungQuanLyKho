namespace QuanLyKho.Forms
{
    partial class GiaoDienChinh
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
            this.laTieude = new System.Windows.Forms.Label();
            this.buttTHEM = new System.Windows.Forms.Button();
            this.buttSUA = new System.Windows.Forms.Button();
            this.buttXOA = new System.Windows.Forms.Button();
            this.buttThongKe = new System.Windows.Forms.Button();
            this.textTimKiem = new System.Windows.Forms.TextBox();
            this.laTimKiem = new System.Windows.Forms.Label();
            this.divHienThi = new System.Windows.Forms.DataGridView();
            this.coStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coMaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coNgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.divHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // laTieude
            // 
            this.laTieude.AutoSize = true;
            this.laTieude.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTieude.Location = new System.Drawing.Point(244, 9);
            this.laTieude.Name = "laTieude";
            this.laTieude.Size = new System.Drawing.Size(278, 24);
            this.laTieude.TabIndex = 0;
            this.laTieude.Text = "ỨNG DỤNG QUẢN LÝ KHO";
            // 
            // buttTHEM
            // 
            this.buttTHEM.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttTHEM.Location = new System.Drawing.Point(44, 74);
            this.buttTHEM.Name = "buttTHEM";
            this.buttTHEM.Size = new System.Drawing.Size(75, 23);
            this.buttTHEM.TabIndex = 1;
            this.buttTHEM.Text = "THÊM";
            this.buttTHEM.UseVisualStyleBackColor = true;
            this.buttTHEM.Click += new System.EventHandler(this.buttTHEM_Click);
            // 
            // buttSUA
            // 
            this.buttSUA.BackColor = System.Drawing.SystemColors.Control;
            this.buttSUA.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttSUA.Location = new System.Drawing.Point(248, 74);
            this.buttSUA.Name = "buttSUA";
            this.buttSUA.Size = new System.Drawing.Size(75, 23);
            this.buttSUA.TabIndex = 2;
            this.buttSUA.Text = "SỬA";
            this.buttSUA.UseVisualStyleBackColor = true;
            this.buttSUA.Click += new System.EventHandler(this.buttSUA_Click);
            // 
            // buttXOA
            // 
            this.buttXOA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttXOA.Location = new System.Drawing.Point(447, 74);
            this.buttXOA.Name = "buttXOA";
            this.buttXOA.Size = new System.Drawing.Size(75, 23);
            this.buttXOA.TabIndex = 3;
            this.buttXOA.Text = "XÓA";
            this.buttXOA.UseVisualStyleBackColor = true;
            this.buttXOA.Click += new System.EventHandler(this.buttXOA_Click);
            // 
            // buttThongKe
            // 
            this.buttThongKe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttThongKe.Location = new System.Drawing.Point(645, 74);
            this.buttThongKe.Name = "buttThongKe";
            this.buttThongKe.Size = new System.Drawing.Size(75, 23);
            this.buttThongKe.TabIndex = 4;
            this.buttThongKe.Text = "THỐNG KÊ";
            this.buttThongKe.UseVisualStyleBackColor = true;
            this.buttThongKe.Click += new System.EventHandler(this.buttThongKe_Click);
            // 
            // textTimKiem
            // 
            this.textTimKiem.Location = new System.Drawing.Point(44, 148);
            this.textTimKiem.Name = "textTimKiem";
            this.textTimKiem.Size = new System.Drawing.Size(399, 20);
            this.textTimKiem.TabIndex = 5;
            this.textTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textTimKiem_KeyDown);
            // 
            // laTimKiem
            // 
            this.laTimKiem.AutoSize = true;
            this.laTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTimKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.laTimKiem.Location = new System.Drawing.Point(41, 132);
            this.laTimKiem.Name = "laTimKiem";
            this.laTimKiem.Size = new System.Drawing.Size(60, 15);
            this.laTimKiem.TabIndex = 6;
            this.laTimKiem.Text = "Tìm kiém";
            // 
            // divHienThi
            // 
            this.divHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.divHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coStt,
            this.coMaHH,
            this.coTen,
            this.coLoai,
            this.coSoLuong,
            this.coGia,
            this.coNgayNhap,
            this.coNgayXuat,
            this.coTinhTrang});
            this.divHienThi.GridColor = System.Drawing.SystemColors.Control;
            this.divHienThi.Location = new System.Drawing.Point(1, 174);
            this.divHienThi.Name = "divHienThi";
            this.divHienThi.Size = new System.Drawing.Size(944, 275);
            this.divHienThi.TabIndex = 7;
            this.divHienThi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.divHienThi_CellContentClick);
            this.divHienThi.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.divHienThi_RowPostPaint);
            // 
            // coStt
            // 
            this.coStt.HeaderText = "STT";
            this.coStt.Name = "coStt";
            // 
            // coMaHH
            // 
            this.coMaHH.DataPropertyName = "MaHH";
            this.coMaHH.HeaderText = "Mã hàng hóa";
            this.coMaHH.Name = "coMaHH";
            // 
            // coTen
            // 
            this.coTen.DataPropertyName = "Ten";
            this.coTen.HeaderText = "Tên hàng hóa";
            this.coTen.Name = "coTen";
            // 
            // coLoai
            // 
            this.coLoai.DataPropertyName = "Loai";
            this.coLoai.HeaderText = "Loại hàng hóa";
            this.coLoai.Name = "coLoai";
            // 
            // coSoLuong
            // 
            this.coSoLuong.DataPropertyName = "So_luong";
            this.coSoLuong.HeaderText = "Số lượng";
            this.coSoLuong.Name = "coSoLuong";
            // 
            // coGia
            // 
            this.coGia.DataPropertyName = "Gia_tien";
            this.coGia.HeaderText = "Giá tiền";
            this.coGia.Name = "coGia";
            // 
            // coNgayNhap
            // 
            this.coNgayNhap.DataPropertyName = "Ngay_nhap_kho";
            this.coNgayNhap.HeaderText = "Ngày nhập";
            this.coNgayNhap.Name = "coNgayNhap";
            // 
            // coNgayXuat
            // 
            this.coNgayXuat.DataPropertyName = "Ngay_xuat_kho";
            this.coNgayXuat.HeaderText = "Ngày xuất kho";
            this.coNgayXuat.Name = "coNgayXuat";
            // 
            // coTinhTrang
            // 
            this.coTinhTrang.DataPropertyName = "Tinh_trang";
            this.coTinhTrang.HeaderText = "Tình trạng";
            this.coTinhTrang.Name = "coTinhTrang";
            // 
            // GiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.divHienThi);
            this.Controls.Add(this.laTimKiem);
            this.Controls.Add(this.textTimKiem);
            this.Controls.Add(this.buttThongKe);
            this.Controls.Add(this.buttXOA);
            this.Controls.Add(this.buttSUA);
            this.Controls.Add(this.buttTHEM);
            this.Controls.Add(this.laTieude);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "GiaoDienChinh";
            this.Text = "GiaoDienChinh";
            this.Load += new System.EventHandler(this.GiaoDienChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.divHienThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laTieude;
        private System.Windows.Forms.Button buttTHEM;
        private System.Windows.Forms.Button buttSUA;
        private System.Windows.Forms.Button buttXOA;
        private System.Windows.Forms.Button buttThongKe;
        private System.Windows.Forms.TextBox textTimKiem;
        private System.Windows.Forms.Label laTimKiem;
        private System.Windows.Forms.DataGridView divHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn coStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn coMaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn coTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn coLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn coSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn coGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn coNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn coNgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn coTinhTrang;
    }
}