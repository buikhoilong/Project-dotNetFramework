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
using DTO;

namespace GUIs
{
    public partial class formHoaDonNhap : Form
    {
        //Trạng Thái Hoá Đơn
        trangThaiHoaDon_BUS ttHD_BUS = new trangThaiHoaDon_BUS();
        DataTable dataTable_ttHD = new DataTable();

        //Trạng Thái Chi Tiết Hoá Đơn
        trangThaiCTHD_BUS ttCTHD_BUS = new trangThaiCTHD_BUS();
        DataTable dataTable_ttCTHD = new DataTable();

        //Khách Hàng
        khachHang_BUS kh_BUS = new khachHang_BUS();
        DataTable dtKH = new DataTable();

        //Nhà Cung Cấp
        nhaCungCap_BUS ncc_BUS = new nhaCungCap_BUS();
        DataTable dtNCC = new DataTable();

        //Kho Hình
        khoHinh_BUS hinh_BUS = new khoHinh_BUS();
        khoHinh_DTO hinh_DTO = new khoHinh_DTO();
        DataTable dtHinh = new DataTable();

        //Sản Phẩm
        sanPham_BUS sp_BUS = new sanPham_BUS();
        DataTable dtSanPham = new DataTable();


        //Hoá Đơn
        hoaDon_BUS hd_BUS = new hoaDon_BUS();
        DataTable dtHoaDon = new DataTable();

        hoaDon_DTO selectedHD = new hoaDon_DTO();
        hoaDon_DTO hoaDon = new hoaDon_DTO();

        //Chi Tiết Hoá Đơn
        chiTietHoaDon_BUS cthd_BUS = new chiTietHoaDon_BUS();        
        DataTable dtCTHD = new DataTable();

        chiTietHoaDon_DTO selected_CTHD = new chiTietHoaDon_DTO();
        chiTietHoaDon_DTO cthd = new chiTietHoaDon_DTO();
        public formHoaDonNhap()
        {
            InitializeComponent();
        }


        private void formHoaDonNhap_Load(object sender, EventArgs e)
        {
            //Hoa Don
            dataTable_ttHD = ttHD_BUS.getListTrangThaiHoaDon();
            for(int i = 0; i< dataTable_ttHD.Rows.Count; i++)
            {
                cbxTinhTrangHD.Items.Add(dataTable_ttHD.Rows[i]["TENTRANGTHAI"]);
            }

            dtNCC = ncc_BUS.getListNhaCungCap();
            for (int i = 0; i < dtNCC.Rows.Count; i++)
            {
                cbxNCC.Items.Add(dtNCC.Rows[i]["MANCC"]);
            }
            cbxNCC.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxNCC.AutoCompleteSource = AutoCompleteSource.ListItems;

            dtHoaDon = hd_BUS.getListHoaDon("N");
            dgvHoaDonNhap.DataSource = dtHoaDon;

            dtpNgayLap.CustomFormat = "hh:mm:ss ddd dd/MM/yyyy";

           

            //CT Hoa Don
            dtSanPham = sp_BUS.getListSanPham();
            cbxMaSp.Items.Clear();
            cbxTenSP.Items.Clear();
            for (int i = 0; i < dtSanPham.Rows.Count; i++)
            {
                cbxMaSp.Items.Add(dtSanPham.Rows[i]["MASP"]);
                cbxTenSP.Items.Add(dtSanPham.Rows[i]["TENSP"]);
            }
            cbxMaSp.AutoCompleteMode = cbxTenSP.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxTenSP.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxMaSp.AutoCompleteSource = AutoCompleteSource.ListItems;

            dataTable_ttCTHD = ttCTHD_BUS.getListTrangThaiCTHD();
            cbxTrangThaiCTHD.Items.Clear();
            for(int i = 0; i< dataTable_ttCTHD.Rows.Count; i++)
            {
                cbxTrangThaiCTHD.Items.Add(dataTable_ttCTHD.Rows[i]["TENTRANGTHAI"]);
            }
            
            xuLyTexBox(false);
            xuLyButtonHD(true);
            setTextBoxHoaDon(0);
        }

        void setTextBoxHoaDon(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                selectedHD.setHoaDon_Nhap(dtHoaDon.Rows[rowIndex]["MAHD"].ToString(), dtHoaDon.Rows[rowIndex]["TONGTIEN"].ToString(), dtHoaDon.Rows[rowIndex]["TRANGTHAI_HD"].ToString(), dtHoaDon.Rows[rowIndex]["MA_NCC"].ToString(), dtHoaDon.Rows[rowIndex]["NGAYLAP_HD"].ToString());

                txtMaHD.Text = selectedHD.maHD;
                cbxNCC.SelectedIndex = cbxNCC.FindStringExact(selectedHD.maNCC);
                txtTongTien.Text = selectedHD.tongTien.ToString();
                //DateTime date = 
                dtpNgayLap.Value = DateTime.Parse(selectedHD.ngayLap);
                cbxTinhTrangHD.SelectedIndex = selectedHD.trangThai;


                // chiTietHoaDon_Load
                activateChiTietHoaDon(selectedHD.maHD);
                setTextBoxChiTietHoaDon(0);
                enableTextBoxCTHD(false);
                btnCTHDLoad(true);
                btnThemCTHD.Enabled = btnSuaCTHD.Enabled = btnXoaCTHD.Enabled = btnLuuCTHD.Enabled = btnHuyCTHD.Enabled = false;
            }
            else
            {
                resetTextBoxHD();
                resetTextBoxCTHD();
                btnThemCTHD.Enabled = btnSuaCTHD.Enabled = btnXoaCTHD.Enabled = btnLuuCTHD.Enabled = btnHuyCTHD.Enabled = false;
            }
        }

        void resetTextBoxHD()
        {
            txtMaHD.Clear();
            cbxNCC.SelectedIndex = 0;
            txtTongTien.Text = "0";
            dtpNgayLap.Value = DateTime.Now;
            cbxTinhTrangHD.SelectedIndex = 0;
        }

        void xuLyTexBox(bool t)
        {
            cbxNCC.Enabled =
            cbxTinhTrangHD.Enabled =
            dtpNgayLap.Enabled = t;
        }

        void xuLyButtonHD(bool t)
        {
            btnThemHD.Enabled = btnXoaHD.Enabled = btnSuaHD.Enabled = t;
            btnHuyHD.Enabled = btnLuuHD.Enabled = !t;
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            hoaDon.setHoaDon_Nhap(txtMaHD.Text, txtTongTien.Text, cbxTinhTrangHD.SelectedIndex.ToString(), cbxNCC.Text, dtpNgayLap.Value);
        }

        private void cbxNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            hoaDon.setHoaDon_Nhap(txtMaHD.Text, txtTongTien.Text, cbxTinhTrangHD.SelectedIndex.ToString(), cbxNCC.Text, dtpNgayLap.Value);
        }

        private void dtpNgayLap_ValueChanged(object sender, EventArgs e)
        {
            hoaDon.setHoaDon_Nhap(txtMaHD.Text, txtTongTien.Text, cbxTinhTrangHD.SelectedIndex.ToString(), cbxNCC.Text, dtpNgayLap.Value);
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            hoaDon.setHoaDon_Nhap(txtMaHD.Text, txtTongTien.Text, cbxTinhTrangHD.SelectedIndex.ToString(), cbxNCC.Text, dtpNgayLap.Value);
        }

        private void cbxTinhTrangHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            hoaDon.setHoaDon_Nhap(txtMaHD.Text, txtTongTien.Text, cbxTinhTrangHD.SelectedIndex.ToString(), cbxNCC.Text, dtpNgayLap.Value);
        }

        int selectedFunction = 0;
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            selectedFunction = 1;
            xuLyTexBox(true);
            xuLyButtonHD(false);            
            resetTextBoxHD();

            //Tạo mã HD mới
            int id = hd_BUS.getListHoaDon("N").Rows.Count + 1;
            txtMaHD.Text = "HD-N-" + id.ToString();
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            xuLyTexBox(true);
            selectedFunction = 2;
            xuLyButtonHD(false);
            btnThemCTHD.Enabled = btnSuaCTHD.Enabled = btnXoaCTHD.Enabled = btnLuuCTHD.Enabled = btnHuyCTHD.Enabled = true;
            btnCTHDLoad(true);
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            DialogResult confirmDetele = MessageBox.Show(null, "Chắc chắn xoá hoá đơn: \"" + hoaDon.maHD + "\"?\nDữ liệu sẽ bị xoá vĩnh viễn!", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmDetele == DialogResult.Yes)
            {
                
                if(cthd_BUS.deleteAllChiTietHoaDon(hoaDon.maHD) >= 0)
                {
                    if (hd_BUS.deleteHoaDon(hoaDon.maHD) != 0)
                    {
                        btnHuyHD_Click(sender, e);
                        MessageBox.Show("Xoá Hoá Đơn thành công!");

                    }
                    else
                    {
                        MessageBox.Show("Xoá Hoá Đơn thất bại!");
                    }
                }
                else
                {
                    MessageBox.Show("Xoá Hoá Đơn thất bại!");
                }
                
            }
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            switch (selectedFunction)
            {
                case 1:
                    {
                        if (hd_BUS.addHoaDon(hoaDon) != 0)
                        {
                            btnHuyHD_Click(sender, e);
                            setTextBoxHoaDon(dgvHoaDonNhap.Rows.Count - 1);
                            btnSuaHD_Click(sender, e);
                            MessageBox.Show("Thêm Hoá Đơn thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Thêm Hoá Đơn thất bại!");
                        }
                        xuLyButtonHD(true);
                        btnThemCTHD.Enabled = btnSuaCTHD.Enabled = btnXoaCTHD.Enabled = btnLuuCTHD.Enabled = btnHuyCTHD.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        if (hd_BUS.updateHoaDon(hoaDon) != 0)
                        {
                            btnHuyHD_Click(sender, e);
                            MessageBox.Show("Cập nhật Hoá Đơn thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật Hoá Đơn thất bại!");
                        }
                        xuLyTexBox(false);
                        break;
                    }
                default:
                    break;
            }                     
            
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            xuLyTexBox(false);
            xuLyButtonHD(true);
            dtHoaDon = hd_BUS.getListHoaDon("N");
            dgvHoaDonNhap.DataSource = dtHoaDon;
            setTextBoxHoaDon(0);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setTextBoxHoaDon(e.RowIndex);
        }

        private void dgvHoaDonNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setTextBoxHoaDon(e.RowIndex);
        }

        //Xử lý Chi Tiết Hoá Đơn
        void activateChiTietHoaDon(string maHD)
        {
            dtCTHD = cthd_BUS.getListChiTietHoaDon(maHD);
            dgvCTHD.DataSource = dtCTHD;
        }

        void setTextBoxChiTietHoaDon(int rowIndex)
        {

            if (rowIndex >= 0 && dgvCTHD.Rows.Count > 0)
            {
                selected_CTHD.setChiTietHoaDon(dtCTHD.Rows[rowIndex]["MA_HD"].ToString(), dtCTHD.Rows[rowIndex]["MA_SP"].ToString(), dtCTHD.Rows[rowIndex]["SOLUONG"].ToString(), dtCTHD.Rows[rowIndex]["DONGIA"].ToString(), dtCTHD.Rows[rowIndex]["GIAM"].ToString(), dtCTHD.Rows[rowIndex]["THANHTIEN"].ToString(), dtCTHD.Rows[rowIndex]["TRANGTHAI_CTHD"].ToString());

                cbxMaSp.SelectedIndex = cbxMaSp.FindStringExact(selected_CTHD.maSP);
                cbxTenSP.SelectedIndex = cbxMaSp.SelectedIndex;
                txtSoLuong.Text = selected_CTHD.soLuong.ToString();
                txtDonGia.Text = selected_CTHD.donGia.ToString();
                cbxTrangThaiCTHD.SelectedIndex = selected_CTHD.trangThai;
                txtGiam.Text = selected_CTHD.giam.ToString();
                txtThanhTien.Text = selected_CTHD.thanhTien.ToString();

                
                selectedPic = 0;
                beginPic = 0;
                showImg(selected_CTHD.maSP, beginPic);
            }
            else
            {
                resetTextBoxCTHD();
            }
        }

        void resetTextBoxCTHD()
        {
            cbxMaSp.SelectedIndex = 0;
            cbxTenSP.SelectedIndex = cbxMaSp.SelectedIndex;
            txtSoLuong.Clear();
            txtDonGia.Clear();
            cbxTrangThaiCTHD.SelectedIndex = 0;
            txtGiam.Clear();
            txtThanhTien.Clear();
            showImg("", 0);
        }

        void enableTextBoxCTHD(bool value)
        {
            txtSoLuong.ReadOnly =             
            txtGiam.ReadOnly = !value;

            cbxMaSp.Enabled =
            cbxTenSP.Enabled =
            cbxTrangThaiCTHD.Enabled = value;
        }

        void btnCTHDLoad(bool value)
        {
            btnThemCTHD.Enabled = btnSuaCTHD.Enabled = btnXoaCTHD.Enabled = value;
            btnLuuCTHD.Enabled = btnHuyCTHD.Enabled = !value;
        }

        private void cbxMaSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cthd.setChiTietHoaDon(txtMaHD.Text, cbxMaSp.Text, txtSoLuong.Text, txtDonGia.Text, txtGiam.Text, txtThanhTien.Text, cbxTrangThaiCTHD.SelectedIndex.ToString());
            cbxTenSP.SelectedIndex = cbxMaSp.SelectedIndex;

            txtDonGia.Text = dtSanPham.Rows[cbxMaSp.SelectedIndex]["GIA_NHAP"].ToString();
            txtThanhTien.Text = (cthd.donGia * cthd.soLuong).ToString();
            
            selectedPic = 0;
            beginPic = 0;
            showImg(cthd.maSP, beginPic);
        }

        private void cbxTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            cthd.setChiTietHoaDon(txtMaHD.Text, cbxMaSp.Text, txtSoLuong.Text, txtDonGia.Text, txtGiam.Text, txtThanhTien.Text, cbxTrangThaiCTHD.SelectedIndex.ToString());
            cbxMaSp.SelectedIndex = cbxTenSP.SelectedIndex;
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            cthd.setChiTietHoaDon(txtMaHD.Text, cbxMaSp.Text, txtSoLuong.Text, txtDonGia.Text, txtGiam.Text, txtThanhTien.Text, cbxTrangThaiCTHD.SelectedIndex.ToString());
            txtThanhTien.Text = (cthd.donGia * cthd.soLuong).ToString();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            cthd.setChiTietHoaDon(txtMaHD.Text, cbxMaSp.Text, txtSoLuong.Text, txtDonGia.Text, txtGiam.Text, txtThanhTien.Text, cbxTrangThaiCTHD.SelectedIndex.ToString());
        }

        private void cbxTrangThaiCTHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            cthd.setChiTietHoaDon(txtMaHD.Text, cbxMaSp.Text, txtSoLuong.Text, txtDonGia.Text, txtGiam.Text, txtThanhTien.Text, cbxTrangThaiCTHD.SelectedIndex.ToString());
        }

        private void txtGiam_TextChanged(object sender, EventArgs e)
        {
            cthd.setChiTietHoaDon(txtMaHD.Text, cbxMaSp.Text, txtSoLuong.Text, txtDonGia.Text, txtGiam.Text, txtThanhTien.Text, cbxTrangThaiCTHD.SelectedIndex.ToString());
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            cthd.setChiTietHoaDon(txtMaHD.Text, cbxMaSp.Text, txtSoLuong.Text, txtDonGia.Text, txtGiam.Text, txtThanhTien.Text, cbxTrangThaiCTHD.SelectedIndex.ToString());
        }

        int selectedFunctionCTHD = 0;

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            selectedFunctionCTHD = 1;
            btnCTHDLoad(false);
            enableTextBoxCTHD(true);
            resetTextBoxCTHD();
        }

        private void btnSuaCTHD_Click(object sender, EventArgs e)
        {
            selectedFunctionCTHD = 2;
            btnCTHDLoad(false);
            enableTextBoxCTHD(true);
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            if (cthd_BUS.deleteChiTietHoaDon(cthd.maHD,cthd.maSP) != 0)
            {
                btnHuyCTHD_Click(sender, e);
                MessageBox.Show("Xoá Chi Tiết Hoá Đơn thành công!");

            }
            else
            {
                MessageBox.Show("Xoá Chi Tiết Hoá Đơn thất bại!");
            }

            UInt32 tongTien = 0;
            for (int i = 0; i < dtCTHD.Rows.Count; i++)
            {
                tongTien += uint.Parse(dtCTHD.Rows[i]["THANHTIEN"].ToString());
            }
            txtTongTien.Text = tongTien.ToString();
            hd_BUS.updateTongTienHoaDon(txtMaHD.Text, txtTongTien.Text);
            dtHoaDon = hd_BUS.getListHoaDon("N");
            dgvHoaDonNhap.DataSource = dtHoaDon;
        }

        private void btnLuuCTHD_Click(object sender, EventArgs e)
        {
            switch (selectedFunctionCTHD)
            {
                case 1:
                    {
                        if (cthd_BUS.addChiThietHoaDon(cthd) != 0)
                        {
                            
                            btnHuyCTHD_Click(sender, e);
                            MessageBox.Show("Thêm Hoá Đơn thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Thêm Hoá Đơn thất bại!");
                        }
                        break;
                    }
                case 2:
                    {
                        if (cthd_BUS.updateChiTietHoaDon(cthd) != 0)
                        {

                            btnHuyCTHD_Click(sender, e);
                            MessageBox.Show("Cập nhật Hoá Đơn thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật Hoá Đơn thất bại!");
                        }
                        break;
                    }
                default:
                    break;
            }
            xuLyTexBox(false);

            //Cập nhật Tổng tiền Hoá Đơn
            UInt32 tongTien = 0;
            for (int i = 0; i < dtCTHD.Rows.Count; i++)
            {
                tongTien += uint.Parse(dtCTHD.Rows[i]["THANHTIEN"].ToString());
            }
            txtTongTien.Text = tongTien.ToString();
            hd_BUS.updateTongTienHoaDon(txtMaHD.Text, txtTongTien.Text);
            dtHoaDon = hd_BUS.getListHoaDon("N");
            dgvHoaDonNhap.DataSource = dtHoaDon;
        }

        private void btnHuyCTHD_Click(object sender, EventArgs e)
        {
            resetTextBoxCTHD();
            btnCTHDLoad(true);
            enableTextBoxCTHD(false);
            dtCTHD = cthd_BUS.getListChiTietHoaDon(hoaDon.maHD);
            dgvCTHD.DataSource = dtCTHD;
            setTextBoxChiTietHoaDon(0);
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setTextBoxChiTietHoaDon(e.RowIndex);
        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setTextBoxChiTietHoaDon(e.RowIndex);
        }

        string pathImg = Program.imgPath;

        private int selectedPic = 0;
        private int beginPic = 0;
        private int endPic = 0;
        private void showImg(String idObj, int indexImg)
        {
            dtHinh = hinh_BUS.getHinhByMaDoiTuong(idObj);

            string fileImgName;
            if (dtHinh.Rows.Count != 0)
            {
                fileImgName = dtHinh.Rows[indexImg]["TENFILE"].ToString();
                btnNext.Enabled = btnPrev.Enabled = true;
                lblSelected.Text = (selectedPic + 1).ToString();
            }
            else
            {
                fileImgName = "noImg.jpg";
                btnNext.Enabled = btnPrev.Enabled = false;
                lblSelected.Text = "0";
            }

            try
            {
                picSP.Image = Image.FromFile(pathImg + fileImgName);
            }
            catch
            {
                if (endPic != 0)
                {
                    imgName.Text = "* Lỗi file hình!";
                }
                picSP.Image = Image.FromFile(pathImg + "noImg.png");
            }

            endPic = dtHinh.Rows.Count;
            lblEnd.Text = endPic.ToString();

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (selectedPic == 0)
            {
                selectedPic = endPic - 1;
            }
            else
            {
                selectedPic = selectedPic - 1;
            }
            showImg(cthd.maSP, selectedPic);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (selectedPic == endPic - 1)
            {
                selectedPic = 0;
            }
            else
            {
                selectedPic = selectedPic + 1;
            }
            showImg(cthd.maSP, selectedPic);
        }
    }
}
