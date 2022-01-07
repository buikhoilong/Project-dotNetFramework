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
    public partial class formNhaCungCap : Form
    {
        trangThaiCoBan_BUS tt_BUS = new trangThaiCoBan_BUS();
        DataTable dataTableTT = new DataTable();

        nhaCungCap_BUS ncc_BUS = new nhaCungCap_BUS();
        DataTable dtNCC = new DataTable();

        nhaCungCap_DTO selected = new nhaCungCap_DTO();
        nhaCungCap_DTO ncc = new nhaCungCap_DTO();

        public formNhaCungCap()
        {
            InitializeComponent();
        }

        private void formNhaCungCap_Load(object sender, EventArgs e)
        {
            cbxTrangThai.Items.Clear();
            dataTableTT = tt_BUS.getListTrangThaiCoBan();
            for (int i = 0; i < dataTableTT.Rows.Count; i++)
            {
                cbxTrangThai.Items.Add(dataTableTT.Rows[i][1]);
            }

            dtNCC = ncc_BUS.getListNhaCungCap();
            dgvNhaCungCap.DataSource = dtNCC;
            setDataTextBoxes(0);
            btnsLoad(true);
            enableTextBoxes(false);

        }

        void btnsLoad(bool value)
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = value;
            btnHuy.Enabled = btnLuu.Enabled = !value;
        }

        void enableTextBoxes(bool value)
        {
            txtMaNCC.ReadOnly = 
            txtTenNCC.ReadOnly = 
            txtSDTNCC.ReadOnly = 
            txtDiaChiNCC.ReadOnly = 
            txtTkNCC.ReadOnly = 
            txtStkNCC.ReadOnly = !value;
            cbxTrangThai.Enabled = value;
        }

        public void setDataTextBoxes(int rowIndex)
        {
            selected.setNhaCungCap(dtNCC.Rows[rowIndex][0].ToString(), dtNCC.Rows[rowIndex][1].ToString(), dtNCC.Rows[rowIndex][2].ToString(), dtNCC.Rows[rowIndex][3].ToString(), dtNCC.Rows[rowIndex][4].ToString(), dtNCC.Rows[rowIndex][5].ToString(), dtNCC.Rows[rowIndex][6].ToString());

            txtMaNCC.Text = selected.maNCC;
            txtTenNCC.Text = selected.tenNCC;
            txtSDTNCC.Text = selected.sdtNCC;
            txtDiaChiNCC.Text = selected.diaChiNCC;
            txtTkNCC.Text = selected.tkNCC;
            txtStkNCC.Text = selected.stkNCC;
            cbxTrangThai.SelectedIndex = selected.trangThai;
        }

        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {
            ncc.setNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtSDTNCC.Text, txtDiaChiNCC.Text, txtTkNCC.Text, txtStkNCC.Text, cbxTrangThai.SelectedIndex);
        }

        private void txtTenNCC_TextChanged(object sender, EventArgs e)
        {
            ncc.setNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtSDTNCC.Text, txtDiaChiNCC.Text, txtTkNCC.Text, txtStkNCC.Text, cbxTrangThai.SelectedIndex);
        }

        private void txtSDTNCC_TextChanged(object sender, EventArgs e)
        {
            ncc.setNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtSDTNCC.Text, txtDiaChiNCC.Text, txtTkNCC.Text, txtStkNCC.Text, cbxTrangThai.SelectedIndex);
        }

        private void txtDiaChiNCC_TextChanged(object sender, EventArgs e)
        {
            ncc.setNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtSDTNCC.Text, txtDiaChiNCC.Text, txtTkNCC.Text, txtStkNCC.Text, cbxTrangThai.SelectedIndex);
        }

        private void txtTkNCC_TextChanged(object sender, EventArgs e)
        {
            ncc.setNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtSDTNCC.Text, txtDiaChiNCC.Text, txtTkNCC.Text, txtStkNCC.Text, cbxTrangThai.SelectedIndex);
        }

        private void txtStkNCC_TextChanged(object sender, EventArgs e)
        {
            ncc.setNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtSDTNCC.Text, txtDiaChiNCC.Text, txtTkNCC.Text, txtStkNCC.Text, cbxTrangThai.SelectedIndex);
        }

        private void cbxTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            ncc.setNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtSDTNCC.Text, txtDiaChiNCC.Text, txtTkNCC.Text, txtStkNCC.Text, cbxTrangThai.SelectedIndex);
        }

        int selectedFunction = 0;

        private void btnThem_Click(object sender, EventArgs e)
        {
            selectedFunction = 1;
            enableTextBoxes(true);
            btnsLoad(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enableTextBoxes(true);
            txtMaNCC.ReadOnly = true;
            selectedFunction = 2;
            btnsLoad(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult confirmDetele = MessageBox.Show(null, "Chắc chắn xoá nhà cung cấp: \"" + ncc.tenNCC + "\"?\nDữ liệu sẽ bị xoá vĩnh viễn!", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmDetele == DialogResult.Yes)
            {
                if (ncc_BUS.deteleNhaCungCap(ncc.maNCC) != 0)
                {
                    btnHuy_Click(sender, e);
                    MessageBox.Show("Xoá Nhà Cung Cấp thành công!");
                }
                else
                {
                    MessageBox.Show("Xoá Nhà Cung Cấp thất bại!");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (selectedFunction)
            {
                case 1:
                    {
                        if (ncc_BUS.addNhaCungCap(ncc) != 0)
                        {
                            btnHuy_Click(sender, e);
                            MessageBox.Show("Thêm Nhà Cung Cấp thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Thêm Nhà Cung Cấp thất bại!");
                        }
                        break;
                    }
                case 2:
                    {
                        if (ncc_BUS.updateNhaCungCap(ncc) != 0)
                        {
                            btnHuy_Click(sender, e);
                            MessageBox.Show("Cập nhật Nhà Cung Cấp thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật Nhà Cung Cấp thất bại!");
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
            dtNCC = ncc_BUS.getListNhaCungCap();
            dgvNhaCungCap.DataSource = dtNCC;
            setDataTextBoxes(0);
            enableTextBoxes(false);
            btnsLoad(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setDataTextBoxes(e.RowIndex);
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setDataTextBoxes(e.RowIndex);
        }
    }
}
