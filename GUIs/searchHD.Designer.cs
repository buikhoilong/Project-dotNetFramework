namespace GUIs
{
    partial class searchHD
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
            this.lblHD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxTrangThaiHD = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblLoaiHD = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAIHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI_HD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP_HD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxDoiTuong = new System.Windows.Forms.ComboBox();
            this.cbxLoaiHD = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHD
            // 
            this.lblHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHD.Location = new System.Drawing.Point(0, 0);
            this.lblHD.Name = "lblHD";
            this.lblHD.Size = new System.Drawing.Size(1010, 115);
            this.lblHD.TabIndex = 13;
            this.lblHD.Text = "TÌM HÓA ĐƠN";
            this.lblHD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Theo thông tin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxDoiTuong);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.cbxTrangThaiHD);
            this.groupBox1.Controls.Add(this.lblLoaiHD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(989, 94);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cần tìm";
            // 
            // cbxTrangThaiHD
            // 
            this.cbxTrangThaiHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTrangThaiHD.FormattingEnabled = true;
            this.cbxTrangThaiHD.Location = new System.Drawing.Point(783, 35);
            this.cbxTrangThaiHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxTrangThaiHD.Name = "cbxTrangThaiHD";
            this.cbxTrangThaiHD.Size = new System.Drawing.Size(181, 33);
            this.cbxTrangThaiHD.TabIndex = 17;
            this.cbxTrangThaiHD.SelectedIndexChanged += new System.EventHandler(this.cbxTrangThaiHD_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(341, 38);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(289, 30);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblLoaiHD
            // 
            this.lblLoaiHD.AutoSize = true;
            this.lblLoaiHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiHD.Location = new System.Drawing.Point(638, 38);
            this.lblLoaiHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiHD.Name = "lblLoaiHD";
            this.lblLoaiHD.Size = new System.Drawing.Size(144, 25);
            this.lblLoaiHD.TabIndex = 15;
            this.lblLoaiHD.Text = "và có trạng thái";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvHoaDon);
            this.groupBox2.Location = new System.Drawing.Point(9, 260);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1001, 281);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHD,
            this.MA_KH,
            this.TONGTIEN,
            this.LOAIHD,
            this.TRANGTHAI_HD,
            this.MA_NCC,
            this.NGAYLAP_HD});
            this.dgvHoaDon.Location = new System.Drawing.Point(4, 20);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.Size = new System.Drawing.Size(989, 253);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            this.MAHD.HeaderText = "Mã hóa đơn";
            this.MAHD.MinimumWidth = 6;
            this.MAHD.Name = "MAHD";
            this.MAHD.Width = 90;
            // 
            // MA_KH
            // 
            this.MA_KH.DataPropertyName = "MA_KH";
            this.MA_KH.HeaderText = "Mã KH";
            this.MA_KH.MinimumWidth = 6;
            this.MA_KH.Name = "MA_KH";
            this.MA_KH.Width = 70;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng tiền";
            this.TONGTIEN.MinimumWidth = 6;
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.Width = 80;
            // 
            // LOAIHD
            // 
            this.LOAIHD.DataPropertyName = "LOAIHD";
            this.LOAIHD.HeaderText = "Loại HD";
            this.LOAIHD.MinimumWidth = 6;
            this.LOAIHD.Name = "LOAIHD";
            this.LOAIHD.Width = 80;
            // 
            // TRANGTHAI_HD
            // 
            this.TRANGTHAI_HD.DataPropertyName = "TRANGTHAI_HD";
            this.TRANGTHAI_HD.HeaderText = "Trạng thái";
            this.TRANGTHAI_HD.MinimumWidth = 6;
            this.TRANGTHAI_HD.Name = "TRANGTHAI_HD";
            this.TRANGTHAI_HD.Width = 80;
            // 
            // MA_NCC
            // 
            this.MA_NCC.DataPropertyName = "MA_NCC";
            this.MA_NCC.HeaderText = "Mã NCC";
            this.MA_NCC.MinimumWidth = 6;
            this.MA_NCC.Name = "MA_NCC";
            this.MA_NCC.Width = 80;
            // 
            // NGAYLAP_HD
            // 
            this.NGAYLAP_HD.DataPropertyName = "NGAYLAP_HD";
            this.NGAYLAP_HD.HeaderText = "Ngày lập";
            this.NGAYLAP_HD.MinimumWidth = 6;
            this.NGAYLAP_HD.Name = "NGAYLAP_HD";
            this.NGAYLAP_HD.Width = 125;
            // 
            // cbxDoiTuong
            // 
            this.cbxDoiTuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDoiTuong.FormattingEnabled = true;
            this.cbxDoiTuong.Location = new System.Drawing.Point(174, 38);
            this.cbxDoiTuong.Name = "cbxDoiTuong";
            this.cbxDoiTuong.Size = new System.Drawing.Size(148, 33);
            this.cbxDoiTuong.TabIndex = 18;
            this.cbxDoiTuong.SelectedIndexChanged += new System.EventHandler(this.cbxDoiTuong_SelectedIndexChanged);
            // 
            // cbxLoaiHD
            // 
            this.cbxLoaiHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoaiHD.FormattingEnabled = true;
            this.cbxLoaiHD.Location = new System.Drawing.Point(399, 58);
            this.cbxLoaiHD.Name = "cbxLoaiHD";
            this.cbxLoaiHD.Size = new System.Drawing.Size(221, 54);
            this.cbxLoaiHD.TabIndex = 18;
            this.cbxLoaiHD.SelectedIndexChanged += new System.EventHandler(this.cbxLoaiHD_SelectedIndexChanged);
            // 
            // searchHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 554);
            this.Controls.Add(this.cbxLoaiHD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHD);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "searchHD";
            this.Text = "searchHD";
            this.Load += new System.EventHandler(this.searchHD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxTrangThaiHD;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblLoaiHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAIHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI_HD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP_HD;
        private System.Windows.Forms.ComboBox cbxDoiTuong;
        private System.Windows.Forms.ComboBox cbxLoaiHD;
    }
}