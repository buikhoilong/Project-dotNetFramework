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
    public partial class formLoaiSP : Form
    {
        trangThaiCoBan_BUS tt_BUS = new trangThaiCoBan_BUS();
        DataTable dataTableTT = new DataTable();

        loaiSanPham_BUS BUS = new loaiSanPham_BUS();
        DataTable dataTableLoaiSP = new DataTable();
        


        loaiSanPham_DTO selectedLoaiSanPham = new loaiSanPham_DTO("", "", 1);
        loaiSanPham_DTO loaiSanPham = new loaiSanPham_DTO("", "", 1);

        int selectedFunction = 0;
        public formLoaiSP()
        {
            InitializeComponent();
        }

        private void formLoaiSP_Load(object sender, EventArgs e)
        {
            cbxTinhTrang.Items.Clear();
            dataTableTT = tt_BUS.getListTrangThaiCoBan();
            for (int i = 0; i < dataTableTT.Rows.Count; i++)
            {
                cbxTinhTrang.Items.Add(dataTableTT.Rows[i][1]);
            }

            dataTableLoaiSP = BUS.getListLoaiSanPham();
            dgvLoaiSP.DataSource = dataTableLoaiSP;
            setDataTextBoxes(0);
            btnsLoad(true);
        }

        void btnsLoad(bool value)
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = value;
            btnHuy.Enabled = btnLuu.Enabled = !value;
        }

        public void setDataTextBoxes(int rowIndex)
        {
            selectedLoaiSanPham.setLoaiSanPham(dataTableLoaiSP.Rows[rowIndex][0].ToString(), dataTableLoaiSP.Rows[rowIndex][1].ToString(), dataTableLoaiSP.Rows[rowIndex][2].ToString());

            txtMaLoai.Text = selectedLoaiSanPham.maLoaiSP;
            txtTenLoai.Text = selectedLoaiSanPham.tenLoaiSP;
            cbxTinhTrang.SelectedIndex = selectedLoaiSanPham.trangThaiLoaiSP;
        }

        private void txtMaLoai_TextChanged(object sender, EventArgs e)
        {
            loaiSanPham.setLoaiSanPham(txtMaLoai.Text, txtTenLoai.Text, cbxTinhTrang.SelectedIndex);
        }

        private void txtTenLoai_TextChanged(object sender, EventArgs e)
        {
            loaiSanPham.setLoaiSanPham(txtMaLoai.Text, txtTenLoai.Text, cbxTinhTrang.SelectedIndex);
        }

        private void cbxTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaiSanPham.setLoaiSanPham(txtMaLoai.Text, txtTenLoai.Text, cbxTinhTrang.SelectedIndex);
        }        

        void enableTextBoxes(bool value)
        {
            txtTenLoai.ReadOnly = txtMaLoai.ReadOnly = !value;
            cbxTinhTrang.Enabled = value;
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
            txtMaLoai.ReadOnly = true;
            selectedFunction = 2;
            btnsLoad(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult confirmDetele = MessageBox.Show(null, "Chắc chắn xoá loại: \"" + loaiSanPham.tenLoaiSP + "\"?\nDữ liệu sẽ bị xoá vĩnh viễn!", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmDetele == DialogResult.Yes)
            {
                if (BUS.deleteLoaiSanPham(loaiSanPham.maLoaiSP) != 0)
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
                        if (BUS.addLoaiSanPham(loaiSanPham) != 0)
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
                        if (BUS.updateLoaiSanPham(loaiSanPham) != 0)
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
            dataTableLoaiSP = BUS.getListLoaiSanPham();
            dgvLoaiSP.DataSource = dataTableLoaiSP;
            setDataTextBoxes(0);
            enableTextBoxes(false);
            btnsLoad(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLoaiSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setDataTextBoxes(e.RowIndex);
        }

        private void dgvLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setDataTextBoxes(e.RowIndex);
        }
    }
}
