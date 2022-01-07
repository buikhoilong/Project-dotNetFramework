using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUIs
{
    public partial class searchHD : Form
    {
        hoaDon_BUS hd_BUS = new hoaDon_BUS();
        DataTable dtHD = new DataTable();

        trangThaiHoaDon_BUS tt_HD = new trangThaiHoaDon_BUS();
        DataTable dttt_HD = new DataTable();



        khachHang_BUS kh_BUS = new khachHang_BUS();
        DataTable dtKH = new DataTable();

        dbConnection_BUS connect = new dbConnection_BUS();
        string loaiHD = "";
        string trangthai = "";
        int doiTuong = 0;
        string searchContent = "";
        int loadCount = 0;

        public searchHD()
        {
            InitializeComponent();
        }

        private void searchHD_Load(object sender, EventArgs e)
        {            
            //Load Loại Hoá Đơn
            cbxLoaiHD.Items.Clear();
            cbxLoaiHD.Items.Add("Nhập"); //0
            cbxLoaiHD.Items.Add("Xuất/Bán"); //1
            cbxLoaiHD.Items.Add("Tất cả");      //2       
            cbxLoaiHD.SelectedIndex = 1;

            //Load Loại đối tượng
            cbxDoiTuong.Items.Clear();
            cbxDoiTuong.Items.Add("Khách hàng"); //0
            cbxDoiTuong.Items.Add("Hoá đơn");    //1
            doiTuong = cbxDoiTuong.SelectedIndex = 0;

            //Loai Trạng thái hoá đơn
            cbxTrangThaiHD.Items.Clear();
            dttt_HD = tt_HD.getListTrangThaiHoaDon();            
            for (int i = 0; i < dttt_HD.Rows.Count; i++)
            {
                cbxTrangThaiHD.Items.Add(dttt_HD.Rows[i]["TENTRANGTHAI"]).ToString();
            }
            cbxTrangThaiHD.Items.Add("Tất cả");
            cbxTrangThaiHD.SelectedIndex = 0;
            loadCount++;
            cbxTrangThaiHD.SelectedIndex = 4;
        }

        //Xử lý tìm kiếm
        void search(string LoaiHD, string TrangThai, int DoiTuong, string SearchContent)
        {
            string maKH = "";
            string sql = "";

            //Xử lý truy vấn
            if (txtSearch.Text == "")
            {
                maKH = "";
            }
            else
            {
                maKH = kh_BUS.getMaKHbyAll(SearchContent);
            }

            if (cbxLoaiHD.SelectedIndex == 1) {
                sql = "select * from HOADON where " + LoaiHD + TrangThai + "MA_KH like '%" + maKH + "%'";
            }
            else /*if (cbxLoaiHD.SelectedIndex == 0)*/
            {
                sql = "select * from HOADON where " + LoaiHD + TrangThai + "(MAHD like '%" + SearchContent + "%' or MA_KH like '%" + SearchContent + "%' or  MA_NCC like '%" + SearchContent + "%' or NGAYLAP_HD like '%" + SearchContent + "%')";
            }
           

            Console.Out.WriteLine(sql);

            //Xử lý DataGridView
            dtHD = connect.getData(sql);
            if (dtHD.Rows.Count > 0)
            {
                dgvHoaDon.DataSource = dtHD;
            }
            else
            {
                if (dgvHoaDon.Rows.Count > 0)
                {
                    dgvHoaDon.DataSource = null;
                }
            }
        }

        private void cbxTrangThaiHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cbxTrangThaiHD.SelectedIndex)
            {
                case 0:
                    trangthai += "TRANGTHAI_HD = 0";
                    break;
                case 1:
                    trangthai += "TRANGTHAI_HD = 1";
                    break;
                case 2:
                    trangthai += "TRANGTHAI_HD = 2";
                    break;
                case 3:
                    trangthai += "TRANGTHAI_HD = 3";
                    break;
                case 4:
                    trangthai = "";
                    break;
            }

            if (cbxTrangThaiHD.SelectedIndex != 4)
            {
                trangthai += " and ";
            }

            //Load xong dữ liệu mới chạy cho lần đầu tiên
            if (loadCount > 0)
            {
                search(loaiHD, trangthai, doiTuong, searchContent);
            }
            
        }

        private void cbxLoaiHD_SelectedIndexChanged(object sender, EventArgs e)
        {                      
            switch (cbxLoaiHD.SelectedIndex)
            {
                case 0:
                    {
                        loaiHD = "LOAIHD = 'N'";
                        break;
                    }

                case 1:
                    {
                        loaiHD = "LOAIHD = 'X'";                       
                        break;
                    }

                case 2:
                    {
                        loaiHD = "";                        
                        break;
                    }
                default:
                    break;
            }

            if (cbxLoaiHD.SelectedIndex != 2)
            {
                loaiHD += " and ";
            }

            if (cbxLoaiHD.SelectedIndex != 1)
            {
                if (loadCount > 0)
                {
                    cbxDoiTuong.SelectedIndex = 1;
                    cbxDoiTuong.Enabled = false;
                }
            }
            else
            {
                if (loadCount > 0)
                {
                    cbxDoiTuong.SelectedIndex = 0;
                    cbxDoiTuong.Enabled = true;
                }
            }

            //cbxtrangthai = true;
            //cbxTrangThaiHD_SelectedIndexChanged(sender, e);

            

            //cbxloaihd = false;
            //Load xong dữ liệu mới chạy cho lần đầu tiên
            if (loadCount > 0/* && cbxloaihd == false*/)
            {
                search(loaiHD, trangthai, doiTuong, searchContent);
            }
        }        

        private void cbxDoiTuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            doiTuong = cbxDoiTuong.SelectedIndex;          
            //Load xong dữ liệu mới chạy cho lần đầu tiên
            if (loadCount > 0)
            {
                search(loaiHD, trangthai, doiTuong, searchContent);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {            
            searchContent = txtSearch.Text;
            //Load xong dữ liệu mới chạy cho lần đầu tiên
            if (loadCount > 0)
            {
                search(loaiHD, trangthai, doiTuong, searchContent);
            }
        }
    }
}
