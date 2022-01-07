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
    public partial class formTrangChu : Form
    {
        public Boolean signIn;
        
        public formTrangChu()
        {
            InitializeComponent();
        }

        private void formTrangChu_Load(object sender, EventArgs e)
        {
            if (signIn == false)
            {
                formDangNhap logInGUI = new formDangNhap();
                logInGUI.Show();                
                menuBar.Enabled = false;
            }
            else
            {
               // btnDangNhap.Enabled = btnDangNhap.Visible = false;
                menuBar.Enabled = true;
            }
        }

        private void formTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void submenuLoaiSP_Click(object sender, EventArgs e)
        {
            formLoaiSP l = new formLoaiSP();
            l.Show();
        }

        private void submenuKhachHang_Click(object sender, EventArgs e)
        {
            formKhachHang k = new formKhachHang();
            k.Show();
        }

        private void submenuTaiKhoan_Click(object sender, EventArgs e)
        {
            formTaiKhoan tk = new formTaiKhoan();
            tk.Show();
        }

        private void submenuNhaCungCap_Click(object sender, EventArgs e)
        {
            formNhaCungCap ncc = new formNhaCungCap();
            ncc.Show();
        }

        private void submenuSanPham_Click(object sender, EventArgs e)
        {
            formSanPham sp = new formSanPham();
            sp.Show();
        }

        private void menuTraCuu_Click(object sender, EventArgs e)
        {
            formTraCuu traCuu = new formTraCuu();
            traCuu.Show();
        }

        private void submenuHoaDonNhap_Click(object sender, EventArgs e)
        {
            formHoaDonNhap hdn = new formHoaDonNhap();
            hdn.Show();
        }

        private void submenuHoaDonBan_Click(object sender, EventArgs e)
        {
            formHoaDonBan hdb = new formHoaDonBan();
            hdb.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void searchHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchHD hd = new searchHD();
            hd.Show();
        }
    }
}
