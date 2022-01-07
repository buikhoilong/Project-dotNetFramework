using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIs
{
    public partial class formHoaDonBan : Form
    {
        //Trạng Thái Hoá Đơn
        trangThaiHoaDon_BUS ttHD_BUS = new trangThaiHoaDon_BUS();//Gọi câu truy vấn
        DataTable dataTable_ttHD = new DataTable();// kiểu dữ liệu dùng để lưu dữ liệu khi lấy từ database

        //Trạng Thái Chi Tiết Hoá Đơn
        trangThaiCTHD_BUS ttCTHD_BUS = new trangThaiCTHD_BUS();
        DataTable dataTable_ttCTHD = new DataTable();

        //Khách Hàng
        khachHang_BUS kh_BUS = new khachHang_BUS();
        DataTable dtKH = new DataTable();

        //Nhà Cung Cấp
        //nhaCungCap_BUS ncc_BUS = new nhaCungCap_BUS();
        //DataTable dtNCC = new DataTable();

        //Kho Hình
        khoHinh_BUS hinh_BUS = new khoHinh_BUS();
        khoHinh_DTO hinh_DTO = new khoHinh_DTO();//Dùng để lưu 1 dòng dữ liệu datatable
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

        chiTietHoaDon_DTO selected_CTHD = new chiTietHoaDon_DTO();//Lưu giá trị dữ liệu lấy từ database trong dgv
        chiTietHoaDon_DTO cthd = new chiTietHoaDon_DTO();
        
        public formHoaDonBan()
        {
            InitializeComponent();
        }

        private void formHoaDonBan_Load(object sender, EventArgs e)
        {
            //Hoa Don
            dataTable_ttHD = ttHD_BUS.getListTrangThaiHoaDon();
            for (int i = 0; i < dataTable_ttHD.Rows.Count; i++)
            {
                cbxTinhTrangHD.Items.Add(dataTable_ttHD.Rows[i]["TENTRANGTHAI"]);
            }
            dtHoaDon = hd_BUS.getListHoaDon("X");
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
            cbxMaSp.AutoCompleteMode = cbxTenSP.AutoCompleteMode = AutoCompleteMode.Suggest;// làm cbx search
            cbxTenSP.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxMaSp.AutoCompleteSource = AutoCompleteSource.ListItems;

            dataTable_ttCTHD = ttCTHD_BUS.getListTrangThaiCTHD();
            cbxTrangThaiCTHD.Items.Clear();
            for (int i = 0; i < dataTable_ttCTHD.Rows.Count; i++)
            {
                cbxTrangThaiCTHD.Items.Add(dataTable_ttCTHD.Rows[i]["TENTRANGTHAI"]);
            }
            xyLyTexBox(false);
            xuLyButton(true);
            setTextBoxHoaDon(0);
        }
        void setTextBoxHoaDon(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                selectedHD.setHoaDon_Ban(dtHoaDon.Rows[rowIndex]["MAHD"].ToString(), dtHoaDon.Rows[rowIndex]["MA_KH"].ToString(), dtHoaDon.Rows[rowIndex]["TONGTIEN"].ToString(), dtHoaDon.Rows[rowIndex]["TRANGTHAI_HD"].ToString(), dtHoaDon.Rows[rowIndex]["NGAYLAP_HD"].ToString());

                txtMaHD.Text = selectedHD.maHD;
                txtMaKH.Text = selectedHD.maKH;
                txtTenKH.Text = kh_BUS.getTenKhachHangByID(selectedHD.maKH);
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
                showQRcode();
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
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtTongTien.Text = "0";
            dtpNgayLap.Value = DateTime.Now;
            cbxTinhTrangHD.SelectedIndex = 0;
        }

        void xyLyTexBox(bool t)
        {           
            cbxTinhTrangHD.Enabled =
            dtpNgayLap.Enabled = t;
        }

        void xuLyButton(bool t)
        {
            btnThemHD.Enabled = t;
            btnXoaHD.Enabled = t;
            btnSuaHD.Enabled = t;
            btnHuyHD.Enabled = !t;
            btnLuuHD.Enabled = !t;
            btnSearch.Visible = !t;
        }

        void showQRcode()
        {
            lblMess.Text = "QR code đang được tạo, vui lòng chờ ...";
            lblMess.ForeColor = Color.Red;
            var url = string.Format("http://chart.apis.google.com/chart?cht=qr&chs={1}x{2}&chl={0}", txtMaHD.Text, 500, 500);
            WebResponse response = default(WebResponse);
            Stream remoteStream = default(Stream);
            StreamReader readStream = default(StreamReader);
            WebRequest request = WebRequest.Create(url);
            response = request.GetResponse();
            remoteStream = response.GetResponseStream();
            readStream = new StreamReader(remoteStream);
            System.Drawing.Image img = System.Drawing.Image.FromStream(remoteStream);
            pcQRCode.Image = img;

            response.Close();
            remoteStream.Close();
            readStream.Close();

            lblMess.Text = "QR code đã được tạo xong!";
            lblMess.ForeColor = Color.Green;
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            hoaDon.setHoaDon_Ban(txtMaHD.Text, txtMaKH.Text, txtTongTien.Text, cbxTinhTrangHD.SelectedIndex.ToString(), dtpNgayLap.Value);
            //Biến để lưu tạm những thay đổi trên texbox
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            hoaDon.setHoaDon_Ban(txtMaHD.Text, txtMaKH.Text, txtTongTien.Text, cbxTinhTrangHD.SelectedIndex.ToString(), dtpNgayLap.Value);
            
        }

        private void dtpNgayLap_ValueChanged(object sender, EventArgs e)
        {
            hoaDon.setHoaDon_Ban(txtMaHD.Text, txtMaKH.Text, txtTongTien.Text, cbxTinhTrangHD.SelectedIndex.ToString(), dtpNgayLap.Value);
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            hoaDon.setHoaDon_Ban(txtMaHD.Text, txtMaKH.Text, txtTongTien.Text, cbxTinhTrangHD.SelectedIndex.ToString(), dtpNgayLap.Value);
        }

        private void cbxTinhTrangHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            hoaDon.setHoaDon_Ban(txtMaHD.Text, txtMaKH.Text, txtTongTien.Text, cbxTinhTrangHD.SelectedIndex.ToString(), dtpNgayLap.Value);
        }

        int selectedFunction = 0;
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            
            selectedFunction = 1;
            xyLyTexBox(true);
            xuLyButton(false);                 
            resetTextBoxHD();
            cbxTinhTrangHD.SelectedIndex = 1;

            //Tạo mã HD mới
            int id = hd_BUS.getListHoaDon("X").Rows.Count + 1;
            txtMaHD.Text = "HD-X-" + id.ToString();

            showQRcode();
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            xyLyTexBox(true);
            selectedFunction = 2;
            xuLyButton(false);
            btnThemCTHD.Enabled = btnSuaCTHD.Enabled = btnXoaCTHD.Enabled = btnLuuCTHD.Enabled = btnHuyCTHD.Enabled = true;
            btnCTHDLoad(true);
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            DialogResult confirmDetele = MessageBox.Show(null, "Hóa đơn: \"" + hoaDon.maHD + "\"?\nSẽ bị hủy!", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmDetele == DialogResult.Yes)
            {
                if (cthd_BUS.deleteAllChiTietHoaDon(hoaDon.maHD) >= 0)
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
                        if(txtMaKH.Text==""||txtTenKH.Text=="")
                        {
                            MessageBox.Show("Chưa nhập đủ thông tin. Vui lòng thử lại");
                        }
                        else if (hd_BUS.addHoaDon(hoaDon) != 0)
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
                        xyLyTexBox(false);
                        break;
                    }
                default:
                    break;
            }
            xyLyTexBox(false);
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            xyLyTexBox(false);
            xuLyButton(true);
            dtHoaDon = hd_BUS.getListHoaDon("X");
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

        void btnCTHDLoad(bool t)
        {
            btnThemCTHD.Enabled = btnSuaCTHD.Enabled = btnXoaCTHD.Enabled = t;
            btnLuuCTHD.Enabled = btnHuyCTHD.Enabled = !t;
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
            cbxTrangThaiCTHD.SelectedIndex = 1;
        }

        private void btnSuaCTHD_Click(object sender, EventArgs e)
        {
            selectedFunctionCTHD = 2;
            btnCTHDLoad(false);
            enableTextBoxCTHD(true);
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            if (cthd_BUS.deleteChiTietHoaDon(cthd.maHD, cthd.maSP) != 0)
            {
                btnHuyHD_Click(sender, e);
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
            dtHoaDon = hd_BUS.getListHoaDon("X");
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
            xyLyTexBox(false);

            //Cập nhật Tổng tiền Hoá Đơn
            UInt32 tongTien = 0;
            for (int i = 0; i < dtCTHD.Rows.Count; i++)
            {
                tongTien += uint.Parse(dtCTHD.Rows[i]["THANHTIEN"].ToString());
            }
            txtTongTien.Text = tongTien.ToString();
            hd_BUS.updateTongTienHoaDon(txtMaHD.Text, txtTongTien.Text);
            dtHoaDon = hd_BUS.getListHoaDon("X");
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

        public void GetDataKH (string maKH, string tenKH)
        {
            txtMaKH.Text = maKH;
            txtTenKH.Text = tenKH;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchKH search = new searchKH();

            search.getDataKH = new searchKH.GetDataKH(GetDataKH);
            search.Show();
        }

        //private void dgvCTHD_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        int vt = dgvCTHD.CurrentRow.Index;
        //        int soluong = int.Parse(dgvCTHD.CurrentRow.Cells[4].ToString());
        //        int giaban = int.Parse(dgvCTHD.CurrentRow.Cells[5].ToString());
        //        int giam = int.Parse(dgvCTHD.CurrentRow.Cells[6].ToString());
        //    }    
        //}

        //private void dgvCTHD_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex <= 6 && e.ColumnIndex >= 4)////kiểm tra thay đổi từ cột 4 đến cột 6 trong cthd
        //    {
        //        int vt = dgvCTHD.CurrentRow.Index;
        //        int soluong = int.Parse(dgvCTHD.CurrentRow.Cells[4].ToString());
        //        int giaban = int.Parse(dgvCTHD.CurrentRow.Cells[5].ToString());
        //        int giam = int.Parse(dgvCTHD.CurrentRow.Cells[6].ToString());

        //        int thanhtien = (soluong * giaban - giam);
        //        dgvCTHD.CurrentRow.Cells[4].Value = thanhtien.ToString();
        //    }
        //}
    }
}
