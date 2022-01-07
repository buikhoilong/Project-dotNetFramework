using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formTrangChu : Form
    {
        public Boolean signIn;
        formDangNhap logInGUI = new formDangNhap();
        public formTrangChu()
        {
            InitializeComponent();
        }

        private void formTrangChu_Load(object sender, EventArgs e)
        {
            if(signIn == false)
            {                
                //formDangNhap logIn = new formDangNhap();
                logInGUI.Show();
                //logIn.Show();
                btnDangNhap.Enabled = btnDangNhap.Visible = true;
                menuBar.Enabled = false;
            }
            else
            {
                btnDangNhap.Enabled = btnDangNhap.Visible = false;
                menuBar.Enabled = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            (new formDangNhap()).Show();
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            //logInGUI.Show();
        }
    }
}
