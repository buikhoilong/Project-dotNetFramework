
namespace GUIs
{
    partial class formSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA_BAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA_NHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MO_TA_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.picSP = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imgName = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblEnd = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.imgDataPath = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxNCC = new System.Windows.Forms.ComboBox();
            this.cbxLoaiSP = new System.Windows.Forms.ComboBox();
            this.cbxTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtMoTa = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grbxChucNang = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.pcQR = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaveQRCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbxChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcQR)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP,
            this.TENSP,
            this.GIA_BAN,
            this.GIA_NHAP,
            this.TONKHO,
            this.TRANGTHAI_SP,
            this.MALOAI,
            this.MA_NCC,
            this.MO_TA_SP});
            this.dgvSanPham.Location = new System.Drawing.Point(11, 430);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(1529, 292);
            this.dgvSanPham.TabIndex = 19;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã Sản Phẩm";
            this.MASP.MinimumWidth = 6;
            this.MASP.Name = "MASP";
            this.MASP.ReadOnly = true;
            this.MASP.Width = 115;
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Tên Sản Phẩm";
            this.TENSP.MinimumWidth = 6;
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            this.TENSP.Width = 120;
            // 
            // GIA_BAN
            // 
            this.GIA_BAN.DataPropertyName = "GIA_BAN";
            this.GIA_BAN.HeaderText = "Giá Bán";
            this.GIA_BAN.MinimumWidth = 6;
            this.GIA_BAN.Name = "GIA_BAN";
            this.GIA_BAN.ReadOnly = true;
            this.GIA_BAN.Width = 82;
            // 
            // GIA_NHAP
            // 
            this.GIA_NHAP.DataPropertyName = "GIA_NHAP";
            this.GIA_NHAP.HeaderText = "Giá Bán";
            this.GIA_NHAP.MinimumWidth = 6;
            this.GIA_NHAP.Name = "GIA_NHAP";
            this.GIA_NHAP.Width = 82;
            // 
            // TONKHO
            // 
            this.TONKHO.DataPropertyName = "TONKHO";
            this.TONKHO.HeaderText = "Tồn Kho";
            this.TONKHO.MinimumWidth = 6;
            this.TONKHO.Name = "TONKHO";
            this.TONKHO.ReadOnly = true;
            this.TONKHO.Width = 62;
            // 
            // TRANGTHAI_SP
            // 
            this.TRANGTHAI_SP.DataPropertyName = "TRANGTHAI_SP";
            this.TRANGTHAI_SP.HeaderText = "Trạng Thái";
            this.TRANGTHAI_SP.MinimumWidth = 6;
            this.TRANGTHAI_SP.Name = "TRANGTHAI_SP";
            this.TRANGTHAI_SP.ReadOnly = true;
            this.TRANGTHAI_SP.Width = 99;
            // 
            // MALOAI
            // 
            this.MALOAI.DataPropertyName = "MALOAI";
            this.MALOAI.HeaderText = "Loại Sản Phẩm";
            this.MALOAI.MinimumWidth = 6;
            this.MALOAI.Name = "MALOAI";
            this.MALOAI.ReadOnly = true;
            this.MALOAI.Width = 122;
            // 
            // MA_NCC
            // 
            this.MA_NCC.DataPropertyName = "MA_NCC";
            this.MA_NCC.HeaderText = "Nhà Cung Cấp";
            this.MA_NCC.MinimumWidth = 6;
            this.MA_NCC.Name = "MA_NCC";
            this.MA_NCC.ReadOnly = true;
            this.MA_NCC.Width = 118;
            // 
            // MO_TA_SP
            // 
            this.MO_TA_SP.DataPropertyName = "MO_TA_SP";
            this.MO_TA_SP.HeaderText = "Mô Tả";
            this.MO_TA_SP.MinimumWidth = 6;
            this.MO_TA_SP.Name = "MO_TA_SP";
            this.MO_TA_SP.ReadOnly = true;
            this.MO_TA_SP.Width = 56;
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(579, 23);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(78, 41);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSize = true;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(466, 23);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(78, 41);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(93, 399);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1447, 22);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnPrev
            // 
            this.btnPrev.AutoSize = true;
            this.btnPrev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(167, 347);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(26, 27);
            this.btnPrev.TabIndex = 17;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // picSP
            // 
            this.picSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSP.Location = new System.Drawing.Point(10, 21);
            this.picSP.Name = "picSP";
            this.picSP.Size = new System.Drawing.Size(427, 320);
            this.picSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSP.TabIndex = 15;
            this.picSP.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(263, 347);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(26, 27);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imgName);
            this.groupBox2.Controls.Add(this.btnUpload);
            this.groupBox2.Controls.Add(this.lblEnd);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblSelected);
            this.groupBox2.Controls.Add(this.btnPrev);
            this.groupBox2.Controls.Add(this.picSP);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Location = new System.Drawing.Point(733, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 380);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hình ảnh Sản Phẩm";
            // 
            // imgName
            // 
            this.imgName.AutoSize = true;
            this.imgName.ForeColor = System.Drawing.Color.Red;
            this.imgName.Location = new System.Drawing.Point(295, 353);
            this.imgName.Name = "imgName";
            this.imgName.Size = new System.Drawing.Size(0, 17);
            this.imgName.TabIndex = 23;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(10, 347);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(141, 27);
            this.btnUpload.TabIndex = 21;
            this.btnUpload.Text = "Thêm ảnh";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(232, 352);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(16, 17);
            this.lblEnd.TabIndex = 20;
            this.lblEnd.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(223, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "/";
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(210, 352);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(16, 17);
            this.lblSelected.TabIndex = 18;
            this.lblSelected.Text = "1";
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(206, 23);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(78, 41);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // imgDataPath
            // 
            this.imgDataPath.SelectedPath = "E:\\0. STUDY\\CKC\\Semester IV\\Windows Programing\\Img";
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(114, 23);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 41);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxNCC);
            this.groupBox1.Controls.Add(this.cbxLoaiSP);
            this.groupBox1.Controls.Add(this.cbxTinhTrang);
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTonKho);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 299);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // cbxNCC
            // 
            this.cbxNCC.FormattingEnabled = true;
            this.cbxNCC.Location = new System.Drawing.Point(500, 72);
            this.cbxNCC.Name = "cbxNCC";
            this.cbxNCC.Size = new System.Drawing.Size(190, 24);
            this.cbxNCC.TabIndex = 16;
            this.cbxNCC.SelectedIndexChanged += new System.EventHandler(this.cbxNCC_SelectedIndexChanged);
            // 
            // cbxLoaiSP
            // 
            this.cbxLoaiSP.FormattingEnabled = true;
            this.cbxLoaiSP.Location = new System.Drawing.Point(500, 31);
            this.cbxLoaiSP.Name = "cbxLoaiSP";
            this.cbxLoaiSP.Size = new System.Drawing.Size(190, 24);
            this.cbxLoaiSP.TabIndex = 15;
            this.cbxLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cbxLoaiSP_SelectedIndexChanged);
            // 
            // cbxTinhTrang
            // 
            this.cbxTinhTrang.Enabled = false;
            this.cbxTinhTrang.FormattingEnabled = true;
            this.cbxTinhTrang.Location = new System.Drawing.Point(161, 252);
            this.cbxTinhTrang.Name = "cbxTinhTrang";
            this.cbxTinhTrang.Size = new System.Drawing.Size(190, 24);
            this.cbxTinhTrang.TabIndex = 14;
            this.cbxTinhTrang.SelectedIndexChanged += new System.EventHandler(this.cbxTinhTrang_SelectedIndexChanged);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(431, 116);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ReadOnly = true;
            this.txtMoTa.Size = new System.Drawing.Size(259, 161);
            this.txtMoTa.TabIndex = 13;
            this.txtMoTa.Text = "";
            this.txtMoTa.TextChanged += new System.EventHandler(this.txtMoTa_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mô Tả";
            // 
            // txtTonKho
            // 
            this.txtTonKho.Location = new System.Drawing.Point(163, 216);
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.ReadOnly = true;
            this.txtTonKho.Size = new System.Drawing.Size(190, 22);
            this.txtTonKho.TabIndex = 10;
            this.txtTonKho.Text = "0";
            this.txtTonKho.TextChanged += new System.EventHandler(this.txtTonKho_TextChanged);
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(163, 144);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.ReadOnly = true;
            this.txtGiaNhap.Size = new System.Drawing.Size(190, 22);
            this.txtGiaNhap.TabIndex = 9;
            this.txtGiaNhap.Text = "0";
            this.txtGiaNhap.TextChanged += new System.EventHandler(this.txtGiaNhap_TextChanged);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(163, 180);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.ReadOnly = true;
            this.txtGiaBan.Size = new System.Drawing.Size(190, 22);
            this.txtGiaBan.TabIndex = 9;
            this.txtGiaBan.Text = "0";
            this.txtGiaBan.TextChanged += new System.EventHandler(this.txtGiaBan_TextChanged);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(161, 69);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(190, 61);
            this.txtTenSP.TabIndex = 8;
            this.txtTenSP.TextChanged += new System.EventHandler(this.txtTenSP_TextChanged);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(161, 33);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(190, 22);
            this.txtMaSP.TabIndex = 7;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nhà Cung Cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Loại Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trạng Thái";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Giá Nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lượng Tồn Kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá Bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(298, 23);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 41);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grbxChucNang
            // 
            this.grbxChucNang.Controls.Add(this.btnThoat);
            this.grbxChucNang.Controls.Add(this.btnHuy);
            this.grbxChucNang.Controls.Add(this.btnLuu);
            this.grbxChucNang.Controls.Add(this.btnSua);
            this.grbxChucNang.Controls.Add(this.btnXoa);
            this.grbxChucNang.Controls.Add(this.btnThem);
            this.grbxChucNang.Location = new System.Drawing.Point(11, 318);
            this.grbxChucNang.Margin = new System.Windows.Forms.Padding(4);
            this.grbxChucNang.Name = "grbxChucNang";
            this.grbxChucNang.Padding = new System.Windows.Forms.Padding(4);
            this.grbxChucNang.Size = new System.Drawing.Size(702, 74);
            this.grbxChucNang.TabIndex = 18;
            this.grbxChucNang.TabStop = false;
            this.grbxChucNang.Text = "Chức Năng";
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(22, 23);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 41);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pcQR
            // 
            this.pcQR.Location = new System.Drawing.Point(6, 21);
            this.pcQR.Name = "pcQR";
            this.pcQR.Size = new System.Drawing.Size(329, 319);
            this.pcQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcQR.TabIndex = 25;
            this.pcQR.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSaveQRCode);
            this.groupBox3.Controls.Add(this.pcQR);
            this.groupBox3.Location = new System.Drawing.Point(1199, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 379);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "QR code Mã Sản Phẩm";
            // 
            // btnSaveQRCode
            // 
            this.btnSaveQRCode.Location = new System.Drawing.Point(113, 348);
            this.btnSaveQRCode.Name = "btnSaveQRCode";
            this.btnSaveQRCode.Size = new System.Drawing.Size(133, 23);
            this.btnSaveQRCode.TabIndex = 26;
            this.btnSaveQRCode.Text = "Lưu thành file ảnh";
            this.btnSaveQRCode.UseVisualStyleBackColor = true;
            this.btnSaveQRCode.Click += new System.EventHandler(this.btnSaveQRCode_Click);
            // 
            // formSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 772);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbxChucNang);
            this.Name = "formSanPham";
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.formSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbxChucNang.ResumeLayout(false);
            this.grbxChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcQR)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.PictureBox picSP;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.FolderBrowserDialog imgDataPath;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxTinhTrang;
        private System.Windows.Forms.RichTextBox txtMoTa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox grbxChucNang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxNCC;
        private System.Windows.Forms.ComboBox cbxLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA_BAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA_NHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MO_TA_SP;
        private System.Windows.Forms.Label imgName;
        private System.Windows.Forms.PictureBox pcQR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSaveQRCode;
    }
}