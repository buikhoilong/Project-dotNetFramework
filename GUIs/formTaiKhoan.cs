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
    public partial class formTaiKhoan : Form
    {
        taiKhoan_BUS BUS = new taiKhoan_BUS();
        loaiTaiKhoan_BUS ltk_BUS = new loaiTaiKhoan_BUS();
        trangThaiCoBan_BUS tt_BUS = new trangThaiCoBan_BUS();

        DataTable dtTaiKhoan = new DataTable();
        DataTable dataTableLTK = new DataTable();
        DataTable dataTableTT = new DataTable();

        taiKhoan_DTO selectedTaiKhoan = new taiKhoan_DTO("", "", "", "", 0, "");
        taiKhoan_DTO taiKhoan = new taiKhoan_DTO("", "", "", "", 0, "");

        int selectedFunction;
        public formTaiKhoan()
        {
            InitializeComponent();
        }

        private void formTaiKhoan_Load(object sender, EventArgs e)
        {
            cbxTrangThai.Items.Clear();
            dataTableTT = tt_BUS.getListTrangThaiCoBan();
            for (int i = 0; i < dataTableTT.Rows.Count; i++)
            {
                cbxTrangThai.Items.Add(dataTableTT.Rows[i][1]);
            }

            cbxLoaiTaiKhoan.Items.Clear();
            dataTableLTK = ltk_BUS.getListLoaiTaiKhoan();
            for (int i = 0; i < dataTableLTK.Rows.Count; i++)
            {
                cbxLoaiTaiKhoan.Items.Add(dataTableLTK.Rows[i][0]);
            }

            dtTaiKhoan = BUS.getListTaiKhoan();
            dgvTaiKhoan.DataSource = dtTaiKhoan;
            setDataTextBoxes(0);
            enableTextBoxes(false);
            btnsLoad(true);
        }

        public void setDataTextBoxes(int rowIndex)
        {
            selectedTaiKhoan.setTaiKhoan(dtTaiKhoan.Rows[rowIndex]["USERNAME"].ToString(), dtTaiKhoan.Rows[rowIndex]["PASSWORD"].ToString(), dtTaiKhoan.Rows[rowIndex][2].ToString(), dtTaiKhoan.Rows[rowIndex][3].ToString(), dtTaiKhoan.Rows[rowIndex][4].ToString(), dtTaiKhoan.Rows[rowIndex][5].ToString());

            txtUsername.Text = selectedTaiKhoan.username;
            txtPassword.Text = selectedTaiKhoan.password;
            txtEmail.Text = selectedTaiKhoan.email;
            txtMoTa.Text = selectedTaiKhoan.moTaTK;
            cbxTrangThai.SelectedIndex = selectedTaiKhoan.trangThaiTK;
            cbxLoaiTaiKhoan.Text = selectedTaiKhoan.loaiTaiKhoan;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            taiKhoan.setTaiKhoan(txtUsername.Text, txtPassword.Text, txtEmail.Text, txtMoTa.Text, cbxTrangThai.SelectedIndex, cbxLoaiTaiKhoan.Text);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            taiKhoan.setTaiKhoan(txtUsername.Text, txtPassword.Text, txtEmail.Text, txtMoTa.Text, cbxTrangThai.SelectedIndex, cbxLoaiTaiKhoan.Text);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            taiKhoan.setTaiKhoan(txtUsername.Text, txtPassword.Text, txtEmail.Text, txtMoTa.Text, cbxTrangThai.SelectedIndex, cbxLoaiTaiKhoan.Text);
        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {
            taiKhoan.setTaiKhoan(txtUsername.Text, txtPassword.Text, txtEmail.Text, txtMoTa.Text, cbxTrangThai.SelectedIndex, cbxLoaiTaiKhoan.Text);
        }

        private void cbxTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            taiKhoan.setTaiKhoan(txtUsername.Text, txtPassword.Text, txtEmail.Text, txtMoTa.Text, cbxTrangThai.SelectedIndex, cbxLoaiTaiKhoan.Text);
        }

        private void cbxLoaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            taiKhoan.setTaiKhoan(txtUsername.Text, txtPassword.Text, txtEmail.Text, txtMoTa.Text, cbxTrangThai.SelectedIndex, cbxLoaiTaiKhoan.Text);
        }

        void btnsLoad(bool value)
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = value;
            btnHuy.Enabled = btnLuu.Enabled = !value;
        }

        void enableTextBoxes(bool value)
        {
            txtUsername.ReadOnly = txtPassword.ReadOnly = txtEmail.ReadOnly = txtMoTa.ReadOnly = !value;
            cbxLoaiTaiKhoan.Enabled = cbxTrangThai.Enabled = value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            selectedFunction = 1;
            enableTextBoxes(true);
            btnsLoad(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enableTextBoxes(true);
            txtUsername.ReadOnly = true;
            selectedFunction = 2;
            btnsLoad(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult confirmDetele = MessageBox.Show(null, "Chắc chắn xoá tài khoản: \"" + taiKhoan.username + "\"?\nDữ liệu sẽ bị xoá vĩnh viễn!", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmDetele == DialogResult.Yes)
            {
                if (BUS.deleteTaiKhoan(taiKhoan.username) != 0)
                {
                    btnHuy_Click(sender, e);
                    MessageBox.Show("Xoá Loại Sản Phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Xoá Loại Sản Phẩm thất bại!");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (selectedFunction)
            {
                case 1:
                    {
                        if (BUS.addTaiKhoan(taiKhoan) != 0)
                        {
                            btnHuy_Click(sender, e);
                            MessageBox.Show("Thêm Loại Sản Phẩm thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Thêm Loại Sản Phẩm thất bại!");
                        }
                        break;
                    }
                case 2:
                    {
                        if (BUS.updateTaiKhoan(taiKhoan) != 0)
                        {
                            btnHuy_Click(sender, e);
                            MessageBox.Show("Cập nhật Loại Sản Phẩm thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật Loại Sản Phẩm thất bại!");
                        }
                        break;
                    }
                default:
                    break;
            }
            enableTextBoxes(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dtTaiKhoan = BUS.getListTaiKhoan();
            dgvTaiKhoan.DataSource = dtTaiKhoan;
            setDataTextBoxes(0);
            enableTextBoxes(false);
            btnsLoad(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setDataTextBoxes(e.RowIndex);
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setDataTextBoxes(e.RowIndex);
        }
    }
}
