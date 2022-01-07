using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIs
{
    public partial class formSanPham : Form
    {
        trangThaiSanPham_BUS tt_BUS = new trangThaiSanPham_BUS();
        DataTable dataTableTT = new DataTable();

        loaiSanPham_BUS loaiSP_BUS = new loaiSanPham_BUS();
        DataTable dtLoaiSP = new DataTable();

        nhaCungCap_BUS ncc_BUS = new nhaCungCap_BUS();
        DataTable dtNCC = new DataTable();

        khoHinh_BUS hinh_BUS = new khoHinh_BUS();
        khoHinh_DTO hinh_DTO = new khoHinh_DTO();
        DataTable dtHinh = new DataTable();

        sanPham_BUS BUS = new sanPham_BUS();
        DataTable dtSanPham = new DataTable();

        sanPham_DTO selected = new sanPham_DTO();
        sanPham_DTO sanPham = new sanPham_DTO();

        public formSanPham()
        {
            InitializeComponent();
        }

        private void formSanPham_Load(object sender, EventArgs e)
        {
            loadComboBox();
            dtSanPham = BUS.getListSanPham();
            dgvSanPham.DataSource = dtSanPham;
            setDataTextBoxes(0);
            btnsLoad(true);
            enableTextBoxes(false);
        }

        void loadComboBox()
        {
            //Tình trạng
            cbxTinhTrang.Items.Clear();
            dataTableTT = tt_BUS.getListTrangThaiSanPham();
            for (int i = 0; i < dataTableTT.Rows.Count; i++)
            {
                cbxTinhTrang.Items.Add(dataTableTT.Rows[i][1]);
            }

            //Loại Sản Phẩm
            cbxLoaiSP.Items.Clear();
            dtLoaiSP = loaiSP_BUS.getListLoaiSanPham();
            for (int i = 0; i < dtLoaiSP.Rows.Count; i++)
            {
                cbxLoaiSP.Items.Add(dtLoaiSP.Rows[i][0]);
            }

            //Nhà Cung Cấp
            cbxNCC.Items.Clear();
            dtNCC = ncc_BUS.getListNhaCungCap();
            for (int i = 0; i < dtNCC.Rows.Count; i++)
            {
                cbxNCC.Items.Add(dtNCC.Rows[i][0]);
            }
        }

        void resetTextBox()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            txtTonKho.Text = "";
            cbxTinhTrang.SelectedIndex = 0;
            cbxLoaiSP.SelectedIndex = 0;
            cbxNCC.SelectedIndex = 0;
            txtMoTa.Text = "";

            showImg("", 0);
        }

        void btnsLoad(bool value)
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = value;
            btnHuy.Enabled = btnLuu.Enabled = btnUpload.Enabled = !value;
        }

        public void setDataTextBoxes(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                selected.setsanPham(dtSanPham.Rows[rowIndex][0].ToString(), dtSanPham.Rows[rowIndex][1].ToString(), dtSanPham.Rows[rowIndex][2].ToString(), dtSanPham.Rows[rowIndex][3].ToString(), dtSanPham.Rows[rowIndex][4].ToString(), dtSanPham.Rows[rowIndex][5].ToString(), dtSanPham.Rows[rowIndex][6].ToString(), dtSanPham.Rows[rowIndex][7].ToString(), dtSanPham.Rows[rowIndex][8].ToString());

                txtMaSP.Text = selected.maSanPham;
                txtTenSP.Text = selected.tenSanPham;
                txtGiaNhap.Text = selected.giaNhap.ToString();
                txtGiaBan.Text = selected.giaBan.ToString();
                txtTonKho.Text = selected.tonKho.ToString();
                cbxTinhTrang.SelectedIndex = selected.trangThaiSP;
                cbxLoaiSP.SelectedIndex = cbxLoaiSP.FindStringExact(selected.maLoai);
                cbxNCC.SelectedIndex = cbxNCC.FindStringExact(selected.maNhaCungCap);
                txtMoTa.Text = selected.moTaSP;
                selectedPic = 0;
                beginPic = 0;
                showImg(selected.maSanPham, beginPic);
            }
            else
            {
                resetTextBox();
            }
        }

        // Start: Product's Picture Process
        /// <summary>
        /// Direct link to folder containts imgages
        /// </summary>
        string pathImg = Program.imgPath;

        private int selectedPic = 0;
        private int beginPic = 0;
        private int endPic = 0;
        private void showImg(String idObj, int indexImg)
        {
            dtHinh = hinh_BUS.getHinhByMaDoiTuong(idObj);
            
            string fileImgName;
            if (dtHinh.Rows.Count !=0)
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
                if(endPic != 0)
                {
                    imgName.Text = "* Lỗi file hình!";
                }
                picSP.Image = Image.FromFile(pathImg + "noImg.png");
            }     
            
            endPic = dtHinh.Rows.Count;
            lblEnd.Text = endPic.ToString();
        }
        void showQRcode()
        {
            var url = string.Format("http://chart.apis.google.com/chart?cht=qr&chs={1}x{2}&chl={0}", txtMaSP, 500, 500);
            WebResponse response = default(WebResponse);
            Stream remoteStream = default(Stream);
            StreamReader readStream = default(StreamReader);
            WebRequest request = WebRequest.Create(url);
            response = request.GetResponse();
            remoteStream = response.GetResponseStream();
            readStream = new StreamReader(remoteStream);
            System.Drawing.Image img = System.Drawing.Image.FromStream(remoteStream);
            pcQR.Image = img;
            
            response.Close();
            remoteStream.Close();
            readStream.Close();           
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
            showImg(txtMaSP.Text, selectedPic);
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
            showImg(txtMaSP.Text,  selectedPic);
        }

        /// <summary>
        /// Upload hình sản phẩm, chỉ show button khi sản phẩm ko có hình ảnh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog browser = new OpenFileDialog();
            browser.InitialDirectory = @"C:\Users\Admin\Desktop";
            browser.Filter = "Image Files (*.jpg)|*.jpg | All Files|*.*";
            browser.FilterIndex = 0;
            
            if (browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (browser.CheckFileExists)
                {                   
                    //Tạo mã đối tượng
                    string extensionImg = System.IO.Path.GetExtension(browser.FileName);
                    hinh_DTO.maDoiTuong = selected.maSanPham;
                    int rowExisted = hinh_BUS.getHinhByMaDoiTuong(hinh_DTO.maDoiTuong).Rows.Count;

                    
                    hinh_DTO.tenFile = "sp-" + txtMaSP.Text + "-" + (rowExisted + 1) + extensionImg;
                    if (rowExisted+1 == 1)
                    {
                        hinh_DTO.ghiChu = "'Cover'";
                    }
                    else
                    {
                        hinh_DTO.ghiChu = "null";
                    }

                    System.IO.File.Copy(browser.FileName, pathImg + hinh_DTO.tenFile);
                    hinh_BUS.addKhoHinh(hinh_DTO);
                    MessageBox.Show("Tải ảnh thành công!");
                }
            }
        }
        // End: Product's Picture Process

        void enableTextBoxes(bool value)
        {
            txtMaSP.ReadOnly =
            txtTenSP.ReadOnly =
            txtGiaNhap.ReadOnly =
            txtGiaBan.ReadOnly =
            txtTonKho.ReadOnly =
            txtMoTa.ReadOnly = !value;

            cbxTinhTrang.Enabled =
            cbxLoaiSP.Enabled =
            cbxNCC.Enabled = value;
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            sanPham.setsanPham(txtMaSP.Text, txtTenSP.Text, txtGiaNhap.Text, txtGiaBan.Text, txtTonKho.Text, cbxTinhTrang.SelectedIndex.ToString(), cbxLoaiSP.Text, cbxNCC.Text, txtMoTa.Text);
            showQRcode();
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            sanPham.setsanPham(txtMaSP.Text, txtTenSP.Text, txtGiaNhap.Text, txtGiaBan.Text, txtTonKho.Text, cbxTinhTrang.SelectedIndex.ToString(), cbxLoaiSP.Text, cbxNCC.Text, txtMoTa.Text);
        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            sanPham.setsanPham(txtMaSP.Text, txtTenSP.Text, txtGiaNhap.Text, txtGiaBan.Text, txtTonKho.Text, cbxTinhTrang.SelectedIndex.ToString(), cbxLoaiSP.Text, cbxNCC.Text, txtMoTa.Text);
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            sanPham.setsanPham(txtMaSP.Text, txtTenSP.Text, txtGiaNhap.Text, txtGiaBan.Text, txtTonKho.Text, cbxTinhTrang.SelectedIndex.ToString(), cbxLoaiSP.Text, cbxNCC.Text, txtMoTa.Text);
        }

        private void txtTonKho_TextChanged(object sender, EventArgs e)
        {
            sanPham.setsanPham(txtMaSP.Text, txtTenSP.Text, txtGiaNhap.Text, txtGiaBan.Text, txtTonKho.Text, cbxTinhTrang.SelectedIndex.ToString(), cbxLoaiSP.Text, cbxNCC.Text, txtMoTa.Text);
        }

        private void cbxTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            sanPham.setsanPham(txtMaSP.Text, txtTenSP.Text, txtGiaNhap.Text, txtGiaBan.Text, txtTonKho.Text, cbxTinhTrang.SelectedIndex.ToString(), cbxLoaiSP.Text, cbxNCC.Text, txtMoTa.Text);
        }

        private void cbxLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            sanPham.setsanPham(txtMaSP.Text, txtTenSP.Text, txtGiaNhap.Text, txtGiaBan.Text, txtTonKho.Text, cbxTinhTrang.SelectedIndex.ToString(), cbxLoaiSP.Text, cbxNCC.Text, txtMoTa.Text);
        }

        private void cbxNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            sanPham.setsanPham(txtMaSP.Text, txtTenSP.Text, txtGiaNhap.Text, txtGiaBan.Text, txtTonKho.Text, cbxTinhTrang.SelectedIndex.ToString(), cbxLoaiSP.Text, cbxNCC.Text, txtMoTa.Text);
        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {
            sanPham.setsanPham(txtMaSP.Text, txtTenSP.Text, txtGiaNhap.Text, txtGiaBan.Text, txtTonKho.Text, cbxTinhTrang.SelectedIndex.ToString(), cbxLoaiSP.Text, cbxNCC.Text, txtMoTa.Text);
        }

        //Begin: Buttons Process
        int selectedFunction = 0;

        private void btnThem_Click(object sender, EventArgs e)
        {
            selectedFunction = 1;
            enableTextBoxes(true);
            btnsLoad(false);
            resetTextBox();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            selectedFunction = 2;
            enableTextBoxes(true);
            txtMaSP.ReadOnly = true;          
            btnsLoad(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (selectedFunction)
            {
                case 1:
                    {
                        if (BUS.addSanPham(sanPham) != 0)
                        {
                            btnHuy_Click(sender, e);
                            MessageBox.Show("Thêm Sản Phẩm thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Thêm Sản Phẩm thất bại!");
                        }
                        break;
                    }
                case 2:
                    {
                        if (BUS.updateSanPham(sanPham) != 0)
                        {
                            btnHuy_Click(sender, e);
                            MessageBox.Show("Cập nhật Sản Phẩm thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật Sản Phẩm thất bại!");
                        }
                        break;
                    }
                default:
                    break;
            }
            enableTextBoxes(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult confirmDetele = MessageBox.Show(null, "Chắc chắn xoá sản phẩm: \"" + sanPham.tenSanPham + "\"?\nDữ liệu sẽ bị xoá vĩnh viễn!", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmDetele == DialogResult.Yes)
            {
                showImg("", 0);
                if (BUS.deleteSanPham(sanPham.maSanPham) != 0)
                {

                    hinh_BUS.deleteKhoHinh(sanPham.maSanPham);
                    dtHinh = hinh_BUS.getHinhByMaDoiTuong(sanPham.maSanPham);
                    for (int i = 0; i < dtHinh.Rows.Count; i++)
                    {
                        string tenfile = dtHinh.Rows[i]["TENFILE"].ToString();
                        string fullpath = pathImg + tenfile;
                        //picSP.Image = Image.FromFile(pathImg + "noImg.jpg");
                        if (File.Exists(fullpath))
                        {
                            System.GC.Collect();
                            System.GC.WaitForPendingFinalizers();
                            File.Delete(fullpath);
                        }
                    }
                    
                    btnHuy_Click(sender, e);
                    MessageBox.Show("Xoá Sản Phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Xoá Sản Phẩm thất bại!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            loadComboBox();
            dtSanPham = BUS.getListSanPham();
            dgvSanPham.DataSource = dtSanPham;
            setDataTextBoxes(0);
            enableTextBoxes(false);
            btnsLoad(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setDataTextBoxes(e.RowIndex);
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setDataTextBoxes(e.RowIndex);
        }
        //End: Buttons Process

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtSanPham = BUS.searchSanPham(txtSearch.Text);
            dgvSanPham.DataSource = dtSanPham;
            setDataTextBoxes(0);
        }

        private void btnSaveQRCode_Click(object sender, EventArgs e)
        {
            System.Drawing.Image img = pcQR.Image;
            img.Save(pathImg + @"\qrcode\" + "sp-" + txtMaSP.Text + "-qrcode" + ".png");
            MessageBox.Show("Lưu thành công!");
        }
    }
}
