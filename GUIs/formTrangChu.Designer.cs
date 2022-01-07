
namespace GUIs
{
    partial class formTrangChu
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuLoaiSP = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuHoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.searchHDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChucNang,
            this.menuTraCuu,
            this.menuDangXuat,
            this.searchHDToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(600, 24);
            this.menuBar.TabIndex = 2;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuChucNang
            // 
            this.menuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuKhachHang,
            this.submenuLoaiSP,
            this.submenuTaiKhoan,
            this.submenuNhaCungCap,
            this.submenuSanPham,
            this.submenuHoaDonNhap,
            this.submenuHoaDonBan});
            this.menuChucNang.Name = "menuChucNang";
            this.menuChucNang.Size = new System.Drawing.Size(77, 20);
            this.menuChucNang.Text = "Chức năng";
            // 
            // submenuKhachHang
            // 
            this.submenuKhachHang.Name = "submenuKhachHang";
            this.submenuKhachHang.Size = new System.Drawing.Size(153, 22);
            this.submenuKhachHang.Text = "Khách Hàng";
            this.submenuKhachHang.Click += new System.EventHandler(this.submenuKhachHang_Click);
            // 
            // submenuLoaiSP
            // 
            this.submenuLoaiSP.Name = "submenuLoaiSP";
            this.submenuLoaiSP.Size = new System.Drawing.Size(153, 22);
            this.submenuLoaiSP.Text = "Loại Sản Phẩm";
            this.submenuLoaiSP.Click += new System.EventHandler(this.submenuLoaiSP_Click);
            // 
            // submenuTaiKhoan
            // 
            this.submenuTaiKhoan.Name = "submenuTaiKhoan";
            this.submenuTaiKhoan.Size = new System.Drawing.Size(153, 22);
            this.submenuTaiKhoan.Text = "Tài Khoản";
            this.submenuTaiKhoan.Click += new System.EventHandler(this.submenuTaiKhoan_Click);
            // 
            // submenuNhaCungCap
            // 
            this.submenuNhaCungCap.Name = "submenuNhaCungCap";
            this.submenuNhaCungCap.Size = new System.Drawing.Size(153, 22);
            this.submenuNhaCungCap.Text = "Nhà Cung Cấp";
            this.submenuNhaCungCap.Click += new System.EventHandler(this.submenuNhaCungCap_Click);
            // 
            // submenuSanPham
            // 
            this.submenuSanPham.Name = "submenuSanPham";
            this.submenuSanPham.Size = new System.Drawing.Size(153, 22);
            this.submenuSanPham.Text = "Sản Phẩm";
            this.submenuSanPham.Click += new System.EventHandler(this.submenuSanPham_Click);
            // 
            // submenuHoaDonNhap
            // 
            this.submenuHoaDonNhap.Name = "submenuHoaDonNhap";
            this.submenuHoaDonNhap.Size = new System.Drawing.Size(153, 22);
            this.submenuHoaDonNhap.Text = "Hoá Đơn Nhập";
            this.submenuHoaDonNhap.Click += new System.EventHandler(this.submenuHoaDonNhap_Click);
            // 
            // submenuHoaDonBan
            // 
            this.submenuHoaDonBan.Name = "submenuHoaDonBan";
            this.submenuHoaDonBan.Size = new System.Drawing.Size(153, 22);
            this.submenuHoaDonBan.Text = "Hoá Đơn Bán";
            this.submenuHoaDonBan.Click += new System.EventHandler(this.submenuHoaDonBan_Click);
            // 
            // menuTraCuu
            // 
            this.menuTraCuu.Name = "menuTraCuu";
            this.menuTraCuu.Size = new System.Drawing.Size(57, 20);
            this.menuTraCuu.Text = "Tra cứu";
            this.menuTraCuu.Click += new System.EventHandler(this.menuTraCuu_Click);
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(73, 20);
            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);
            // 
            // searchHDToolStripMenuItem
            // 
            this.searchHDToolStripMenuItem.Name = "searchHDToolStripMenuItem";
            this.searchHDToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.searchHDToolStripMenuItem.Text = "Search HD";
            this.searchHDToolStripMenuItem.Click += new System.EventHandler(this.searchHDToolStripMenuItem_Click);
            // 
            // formTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuBar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formTrangChu";
            this.Text = "Trang Chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formTrangChu_FormClosing);
            this.Load += new System.EventHandler(this.formTrangChu_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuChucNang;
        private System.Windows.Forms.ToolStripMenuItem menuTraCuu;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem submenuLoaiSP;
        private System.Windows.Forms.ToolStripMenuItem submenuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem submenuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem submenuNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem submenuSanPham;
        private System.Windows.Forms.ToolStripMenuItem submenuHoaDonNhap;
        private System.Windows.Forms.ToolStripMenuItem submenuHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem searchHDToolStripMenuItem;
    }
}

