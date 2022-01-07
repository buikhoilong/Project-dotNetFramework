
namespace GUIs
{
    partial class searchKH
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DC_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblNhap = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TENKH,
            this.SDT_KH,
            this.DC_KH,
            this.EMAIL_KH,
            this.TRANGTHAI_KH});
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(3, 16);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(575, 237);
            this.dgvKhachHang.TabIndex = 11;
            this.dgvKhachHang.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentDoubleClick);
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã Khách Hàng";
            this.MAKH.MinimumWidth = 6;
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            this.MAKH.Width = 78;
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên Khách Hàng";
            this.TENKH.MinimumWidth = 6;
            this.TENKH.Name = "TENKH";
            this.TENKH.ReadOnly = true;
            this.TENKH.Width = 81;
            // 
            // SDT_KH
            // 
            this.SDT_KH.DataPropertyName = "SDT_KH";
            this.SDT_KH.HeaderText = "SĐT Khách Hàng";
            this.SDT_KH.MinimumWidth = 6;
            this.SDT_KH.Name = "SDT_KH";
            this.SDT_KH.ReadOnly = true;
            this.SDT_KH.Width = 84;
            // 
            // DC_KH
            // 
            this.DC_KH.DataPropertyName = "DC_KH";
            this.DC_KH.HeaderText = "Địa chỉ";
            this.DC_KH.MinimumWidth = 6;
            this.DC_KH.Name = "DC_KH";
            this.DC_KH.ReadOnly = true;
            this.DC_KH.Width = 48;
            // 
            // EMAIL_KH
            // 
            this.EMAIL_KH.DataPropertyName = "EMAIL_KH";
            this.EMAIL_KH.HeaderText = "Email";
            this.EMAIL_KH.MinimumWidth = 6;
            this.EMAIL_KH.Name = "EMAIL_KH";
            this.EMAIL_KH.ReadOnly = true;
            this.EMAIL_KH.Width = 57;
            // 
            // TRANGTHAI_KH
            // 
            this.TRANGTHAI_KH.DataPropertyName = "TRANGTHAI_KH";
            this.TRANGTHAI_KH.HeaderText = "Trạng thái";
            this.TRANGTHAI_KH.MinimumWidth = 6;
            this.TRANGTHAI_KH.Name = "TRANGTHAI_KH";
            this.TRANGTHAI_KH.ReadOnly = true;
            this.TRANGTHAI_KH.Width = 74;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 49);
            this.label1.TabIndex = 12;
            this.label1.Text = "TÌM KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(119, 86);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(356, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhap.Location = new System.Drawing.Point(211, 55);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(160, 20);
            this.lblNhap.TabIndex = 13;
            this.lblNhap.Text = "Nhập dữ liệu cần tìm :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKhachHang);
            this.groupBox1.Location = new System.Drawing.Point(7, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 256);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // searchKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 443);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNhap);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "searchKH";
            this.Text = "searchKH";
      //      this.Load += new System.EventHandler(this.searchKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DC_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI_KH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}