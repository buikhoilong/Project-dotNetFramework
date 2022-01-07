using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIs
{
    public partial class formTraCuu : Form
    {
        string doiTuong = "";
        dbConnection_BUS db = new dbConnection_BUS();
        
        public formTraCuu()
        {
            InitializeComponent();
        }

        private void formTraCuu_Load(object sender, EventArgs e)
        {
            cbxDoiTuong.Items.Clear();
            cbxDoiTuong.Items.Add("Sản Phẩm");
            cbxDoiTuong.Items.Add("Khách Hàng");
            cbxDoiTuong.Items.Add("Nhà Cung Cấp");
            cbxDoiTuong.Items.Add("Loại Sản Phẩm");
            cbxDoiTuong.Items.Add("Tài Khoản");
            cbxDoiTuong.Items.Add("Hóa Đơn");
            cbxDoiTuong.SelectedIndex = 0;
            cbxDoiTuong.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxDoiTuong.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbxLoai.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxLoai.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cbxDoiTuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvSearch.Rows.Count > 0)
            {
                dgvSearch.Rows.Clear();
            }
            doiTuong = cbxDoiTuong.Text;
            switch (cbxDoiTuong.SelectedIndex)
            {
                case 0:
                    {
                        cbxLoai.Items.Clear();
                        cbxLoai.Items.Add("Tất cả");
                        cbxLoai.Items.Add("Mã Sản Phẩm");
                        cbxLoai.Items.Add("Tên Sản Phẩm");
                        cbxLoai.Items.Add("Loại Sản Phẩm");
                        cbxLoai.Items.Add("Tên Nhà Cung Cấp");
                        cbxLoai.Items.Add("Mô tả Sản phẩm");
                        break;
                    }
                case 1:
                    {
                        cbxLoai.Items.Clear();
                        cbxLoai.Items.Add("Tất cả");
                        cbxLoai.Items.Add("Số điện thoại");
                        cbxLoai.Items.Add("Tên Khách hàng");
                        cbxLoai.Items.Add("Địa Chỉ");
                        cbxLoai.Items.Add("Email");
                        break;
                    }
                case 2:
                    {
                        cbxLoai.Items.Clear();
                        cbxLoai.Items.Add("Tất cả");
                        cbxLoai.Items.Add("Mã Nhà Cung Cấp");
                        cbxLoai.Items.Add("Tên Nhà Cung Cấp");
                        cbxLoai.Items.Add("Số điện thoại");
                        cbxLoai.Items.Add("Địa chỉ");
                        cbxLoai.Items.Add("Tên Tài Khoản");
                        cbxLoai.Items.Add("Số Tài Khoản");
                        break;
                    }
                case 3:
                    {
                        cbxLoai.Items.Clear();
                        cbxLoai.Items.Add("Tất cả");
                        cbxLoai.Items.Add("Mã Loại Sản Phẩm");
                        cbxLoai.Items.Add("Tên Loại Sản Phẩm");
                        break;
                    }
                case 4:
                    {
                        cbxLoai.Items.Clear();
                        cbxLoai.Items.Add("Tất cả");
                        cbxLoai.Items.Add("Tên Đăng Nhập");
                        cbxLoai.Items.Add("Email");
                        cbxLoai.Items.Add("Mô tả");
                        cbxLoai.Items.Add("Loại Tài Khoản");
                        break;
                    }
                case 5:
                    {
                        cbxLoai.Items.Clear();
                        cbxLoai.Items.Add("Tất cả");
                        cbxLoai.Items.Add("Mã hóa đơn");
                        cbxLoai.Items.Add("Mã khách hàng");
                        cbxLoai.Items.Add("Mã hóa đơn");
                        cbxLoai.Items.Add("Ngày lập");
                        break;
                    }
            }
            
            cbxLoai.SelectedIndex = 0;
        }

        private void cbxLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                dgvSearch.Rows.Clear();
            }
            catch
            {

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "";
            if (doiTuong == "Sản Phẩm")
            {
                sql = "select MASP as N'Mã Sản Phẩm', TENSP as N'Tên Sản Phẩm', GIA_BAN as N'Đơn Giá', TONKHO as N'Tồn Kho', TENTRANGTHAI as N'Trạng Thái', TENLOAISP as N'Loại Sản Phẩm' ,TENNCC as N'Nhà Cung Cấp', MO_TA_SP as N'Mô Tả Sản Phẩm' FROM SANPHAM, NHACUNGCAP, LOAISANPHAM,TRANGTHAI_SANPHAM WHERE MALOAI = MALOAISP AND MA_NCC = MANCC and TRANGTHAI_SP=TRANGTHAI and ";
                switch (cbxLoai.SelectedIndex)
                {

                    case 0:
                        {
                            sql += "(MASP like N'%" + txtSearch.Text + "%' or TENSP like N'%" + txtSearch.Text + "%' or TENLOAISP like N'%" + txtSearch.Text + "%' or TENNCC like N'%" + txtSearch.Text + "%' or MO_TA_SP like N'%" + txtSearch.Text + "%')";
                            break;
                        }
                    case 1:
                        {
                            sql += "MASP like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                    case 2:
                        {
                            sql += "TENSP like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                    case 3:
                        {
                            sql += "TENLOAISP like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                    case 4:
                        {
                            sql += "TENNCC like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                    case 5:
                        {
                            sql += "MO_TA_SP like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                }
            }

            if (doiTuong == "Khách Hàng")
            {
                sql = "select SDT_KH N'Số điện thoại', TENKH N'Tên khách hàng', DC_KH N'Địa chỉ', EMAIL_KH 'Email', TENTRANGTHAI N'Trạng thái' from KHACHHANG, TRANGTHAI_COBAN where TRANGTHAI_KH = TRANGTHAI and ";
                switch (cbxLoai.SelectedIndex)
                {
                    case 0:
                        {
                            sql += "(SDT_KH like N'%" + txtSearch.Text + "%' or TENKH like N'%" + txtSearch.Text + "%' or DC_KH like N'%" + txtSearch.Text + "%' or EMAIL_KH like N'%" + txtSearch.Text + "%')";
                            break;
                        }
                    case 1:
                        {
                            sql += "SDT_KH like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                    case 2:
                        {
                            sql += "TENKH like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                    case 3:
                        {
                            sql += "DC_KH like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                    case 4:
                        {
                            sql += "EMAIL_KH like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                }
            }

            if(doiTuong == "Loại Sản Phẩm")
            {
                sql = "select MALOAISP N'Mã loại', TENLOAISP N'Tên loại' from LOAISANPHAM where ";
                switch (cbxLoai.SelectedIndex)
                {
                    case 0:
                        {
                            sql += "MALOAISP like N'%" + txtSearch.Text + "%' or TENLOAISP like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                    case 1:
                        {
                            sql += "MALOAISP like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                    case 2:
                        {
                            sql += "TENLOAISP like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                }
            }

            if(doiTuong == "Nhà Cung Cấp")
            {
                sql = "select MANCC N'Mã Nhà Cung Cấp', TENNCC N'Tên Nhà Cung Cấp', SDT_NCC N'Số điện thoại', DC_NCC N'Địa chỉ', TK_NCC N'Tên tài khoản NH', STK_NCC N'Số tài khoản NH', TENTRANGTHAI N'Trạng thái' from NHACUNGCAP, TRANGTHAI_COBAN where TRANGTHAI_NCC = TRANGTHAI and ";
                switch (cbxLoai.SelectedIndex)
                {
                    case 0:
                        {
                            sql += "(MANCC like N'%" + txtSearch.Text + "%' or TENNCC like N'%" + txtSearch.Text + "%' or SDT_NCC like N'%" + txtSearch.Text + "%' or DC_NCC like N'%" + txtSearch.Text + "%' or TK_NCC like N'%" + txtSearch.Text + "%' or STK_NCC like N'%" + txtSearch.Text + "%')";
                            break;
                        }
                    case 1:
                        {
                            sql += "MANCC like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                    case 2:
                        {
                            sql += "TENNCC like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                    case 3:
                        {
                            sql += "SDT_NCC like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                    case 4:
                        {
                            sql += "DC_NCC like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                    case 5:
                        {
                            sql += "TK_NCC like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                    case 6:
                        {
                            sql += "STK_NCC like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                }
            }

            if (doiTuong == "Tài Khoản")
            {
                sql = "select USERNAME N'Tên đăng nhập',  PASSWORD N'Mật khẩu', EMAIL, MOTA_TK N'Mô tả', TENTRANGTHAI N'Trạng thái', LOAI_TK N'Loại tài khoản' from TAIKHOAN, TRANGTHAI_COBAN where TRANGTHAI_TK = TRANGTHAI and ";
                switch (cbxLoai.SelectedIndex)
                {
                    case 0:
                        {
                            sql += "(USERNAME like N'%" + txtSearch.Text + "%' or PASSWORD like N'%" + txtSearch.Text + "%' or EMAIL like N'%" + txtSearch.Text + "%' or MOTA_TK like N'%" + txtSearch.Text + "%' or LOAI_TK like N'%" + txtSearch.Text + "%')";
                            break;
                        }
                    case 1:
                        {
                            sql += "USERNAME like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                    case 2:
                        {
                            sql += "EMAIL like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                    case 3:
                        {
                            sql += "MOTA_TK like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                    case 4:
                        {
                            sql += "LOAI_TK like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                }
            }
            if(doiTuong=="Hóa Đơn")
            {
                sql = "select MAHD N'Mã hóa đơn', MA_KH N'Mã khách hàng', TONGTIEN N'Tổng tiền',LOAIHD N'Loại hóa đơn', TRANGTHAI_HD N'Trạng thái', MA_NCC N'Mã NCC', NGAYLAP_HD 'Ngày lập' from HOADON,TRANGTHAI_HOADON where TRANGTHAI_HD = TRANGTHAI and ";
                switch(cbxDoiTuong.SelectedIndex)
                {
                    case 0:
                        {
                            sql += "(MAHD like N'%" + txtSearch.Text + "%' or MA_KH like N'%" + txtSearch.Text + "%' or TONGTIEN like N'%" + txtSearch.Text + "%' or LOAIHD like N'%" + txtSearch.Text + "%' or TRANGTHAI_HD like N'%" + txtSearch.Text + "%' or MA_NCC like N'%" + txtSearch.Text + "%' or NGAYLAP_HD like '%" + txtSearch.Text + "%')";
                            break;                        
                        }
                    case 1:
                        {
                            sql += "MAHD like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                    case 2:
                        {
                            sql+= "NGAYLAP_HD like N'%" + txtSearch.Text + "%'";
                            break;
                        }
                }    
            }    

            dgvSearch.DataSource = db.getData(sql);
        }
    }
}
