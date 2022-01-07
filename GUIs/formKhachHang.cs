using BUS;
using DTO;
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
    public partial class formKhachHang : Form
    {
        khachHang_BUS BUS = new     khachHang_BUS();
        trangThaiCoBan_BUS tt_BUS = new trangThaiCoBan_BUS();

        DataTable dtKhachHang = new DataTable();
        DataTable dataTableTT = new DataTable();


        khachHang_DTO selectedKhachHang = new khachHang_DTO();
        khachHang_DTO khachHang = new khachHang_DTO();

        int selectedFunction = 0;
        public formKhachHang()
        {
            InitializeComponent();
        }

        private void formKhachHang_Load(object sender, EventArgs e)
        {
            cbxTrangThai.Items.Clear();
            dataTableTT = tt_BUS.getListTrangThaiCoBan();
            for (int i = 0; i < dataTableTT.Rows.Count; i++)
            {
                cbxTrangThai.Items.Add(dataTableTT.Rows[i][1]);
            }

            dtKhachHang = BUS.getListKhachHang();            
            dgvKhachHang.DataSource = dtKhachHang;
            setDataTextBoxes(0);
            xuLyTextBox(false);
            xuLyButton(true);

        }

        public void setDataTextBoxes(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dtKhachHang.Rows.Count) {
                selectedKhachHang.setKhachHang(dtKhachHang.Rows[rowIndex][0].ToString(), dtKhachHang.Rows[rowIndex][1].ToString(), dtKhachHang.Rows[rowIndex][2].ToString(), dtKhachHang.Rows[rowIndex][3].ToString(), dtKhachHang.Rows[rowIndex][4].ToString(), dtKhachHang.Rows[rowIndex][5].ToString());
                txtMaKH.Text = selectedKhachHang.maKH;
                txtSoDienThoaiKH.Text = selectedKhachHang.sdtKH;
                txtTenKH.Text = selectedKhachHang.tenKH;
                txtDiaChiKH.Text = selectedKhachHang.diaChiKH;
                txtEmail.Text = selectedKhachHang.emailKH;
                cbxTrangThai.SelectedIndex = selectedKhachHang.trangThai;
            }
            else
            {
                resetTextBox();
            }
           
        }

        void resetTextBox()
        {
            txtMaKH.Clear();
            txtSoDienThoaiKH.Clear();
            txtTenKH.Clear();
            txtDiaChiKH.Clear();
            txtEmail.Clear();
            cbxTrangThai.SelectedIndex = 0;
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            khachHang.setKhachHang(txtMaKH.Text, txtTenKH.Text, txtSoDienThoaiKH.Text, txtDiaChiKH.Text, txtEmail.Text, cbxTrangThai.SelectedIndex);
        }

        private void txtSoDienThoaiKH_TextChanged(object sender, EventArgs e)
        {
            khachHang.setKhachHang(txtMaKH.Text, txtTenKH.Text, txtSoDienThoaiKH.Text, txtDiaChiKH.Text, txtEmail.Text, cbxTrangThai.SelectedIndex);
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            khachHang.setKhachHang(txtMaKH.Text, txtTenKH.Text, txtSoDienThoaiKH.Text, txtDiaChiKH.Text, txtEmail.Text, cbxTrangThai.SelectedIndex);
        }

        private void txtDiaChiKH_TextChanged(object sender, EventArgs e)
        {
            khachHang.setKhachHang(txtMaKH.Text, txtTenKH.Text, txtSoDienThoaiKH.Text, txtDiaChiKH.Text, txtEmail.Text, cbxTrangThai.SelectedIndex);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            khachHang.setKhachHang(txtMaKH.Text, txtTenKH.Text, txtSoDienThoaiKH.Text, txtDiaChiKH.Text, txtEmail.Text, cbxTrangThai.SelectedIndex);
        }

        private void cbxTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            khachHang.setKhachHang(txtMaKH.Text, txtTenKH.Text, txtSoDienThoaiKH.Text, txtDiaChiKH.Text, txtEmail.Text, cbxTrangThai.SelectedIndex);
        }

        void xuLyButton(bool t)
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = t;
            btnHuy.Enabled = btnLuu.Enabled = !t;
        }

        void xuLyTextBox(bool t)
        {
            txtMaKH.ReadOnly = txtSoDienThoaiKH.ReadOnly = txtTenKH.ReadOnly = txtDiaChiKH.ReadOnly = txtEmail.ReadOnly = !t;
            cbxTrangThai.Enabled = t;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            selectedFunction = 1;
            xuLyTextBox(true);
            xuLyButton(false);
            txtMaKH.ReadOnly = true;
            resetTextBox();
            //Tạo mã KH mới 
            int id = BUS.getListKhachHang().Rows.Count + 1;
            txtMaKH.Text = "KH" + id.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyTextBox(true);
            txtMaKH.ReadOnly = true;
            selectedFunction = 2;
            xuLyButton(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult confirmDetele = MessageBox.Show(null, "Khách hàng: \"" + khachHang.tenKH + "\"?\n Sẽ bị ngừng hoạt động!", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmDetele == DialogResult.Yes)
            {
                if (BUS.deleteKhachHang(khachHang.sdtKH) != 0)
                {
                    btnHuy_Click(sender, e);
                    MessageBox.Show("Xoá thành công!");
                    
                }
                else
                {
                    MessageBox.Show("Xoá thất bại!");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (selectedFunction)
            {
                case 1:
                    {
                        if(txtSoDienThoaiKH.Text==""||txtTenKH.Text==""||txtDiaChiKH.Text==""||txtEmail.Text=="")
                        {
                            MessageBox.Show("Chưa nhập đủ thông tin khách hàng. Vui lòng thử lại");
                        }
                        else if (BUS.addKhachHang(khachHang) != 0)
                        {
                            btnHuy_Click(sender, e);
                            MessageBox.Show("Thêm Thông tin Khách Hàng thành công!");
                            
                        }
                        else
                        {
                            MessageBox.Show("Thêm Thông tin Khách Hàng thất bại!");
                        }
                        break;
                    }
                case 2:
                    {
                        if (BUS.updateKhachHang(khachHang) != 0)
                        {
                            btnHuy_Click(sender, e);
                            MessageBox.Show("Cập nhật Thông tin Khách Hàng thành công!"); 
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật Thông tin Khách Hàng thất bại!");
                        }
                        break;
                    }
                default:
                    break;
            }
            xuLyTextBox(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dtKhachHang = BUS.getListKhachHang();
            dgvKhachHang.DataSource = dtKhachHang;
            setDataTextBoxes(0);
            xuLyTextBox(false);
            xuLyButton(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setDataTextBoxes(e.RowIndex);
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setDataTextBoxes(e.RowIndex);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtKhachHang = BUS.searchKhachHang(txtSearch.Text);
            dgvKhachHang.DataSource = dtKhachHang;
            setDataTextBoxes(0);
        }

        private void txtSoDienThoaiKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
    }
}
