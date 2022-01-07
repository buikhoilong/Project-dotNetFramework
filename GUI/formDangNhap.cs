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

namespace GUI
{
    public partial class formDangNhap : Form
    {
        taiKhoan_BUS tk = new taiKhoan_BUS();
        formTrangChu homeGUI = new formTrangChu();
        public formDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (tk.checkTaiKhoan(txtUsername.Text, txtPassword.Text))
            {
                homeGUI.Show();
                homeGUI.signIn = true;
                //this.Hide();           
            }
            else
            {
                lblThongBao.Text = "* Tài khoản hoặc mật khẩu không đúng! Hãy kiểm tra và thử lại!";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            Close();
            
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
