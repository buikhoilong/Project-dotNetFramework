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
    public partial class searchKH : Form
    {
        khachHang_BUS kh_BUS = new khachHang_BUS();

        public delegate void GetDataKH(string maKH, string tenKH);// hàm này dùng để double click vào tên, mã khách hàng thì hiện thẳng vào form hóa đơn

        public GetDataKH getDataKH;

        public searchKH()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = kh_BUS.searchKhachHang(txtSearch.Text);
        }

        private void dgvKhachHang_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if(getDataKH != null)
                {
                    string maKH = dgvKhachHang.Rows[e.RowIndex].Cells["MAKH"].Value.ToString();
                    string tenKH = dgvKhachHang.Rows[e.RowIndex].Cells["TENKH"].Value.ToString();
                    getDataKH(maKH, tenKH);

                    this.Close();
                }
            }
        }
    }
}
