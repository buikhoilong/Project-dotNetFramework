using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class taiKhoan_BUS
    {
        taiKhoan_DAO d = new taiKhoan_DAO();
        public DataTable getListTaiKhoan()
        {
            return d.getListTaiKhoan();
        }

        public int addTaiKhoan(taiKhoan_DTO tk)
        {
            return d.addTaiKhoan(tk);
        }

        public int updateTaiKhoan(taiKhoan_DTO tk)
        {
            return d.updateTaiKhoan(tk);
        }

        public int deleteTaiKhoan(string username)
        {
            return d.deleteTaiKhoan(username);
        }

        /// <summary>
        /// Kiểm tra Tài khoản tồn tại
        /// </summary>
        /// <param name="username">Tên đăng nhập (khoá chính)</param>
        /// <param name="password">Mật khẩu</param>
        /// <returns>Nếu tồn tại trả về TRUE, không tồn tại là FALSE</returns>
        public bool checkTaiKhoan(string username, string password) 
        {
            return d.checkTaiKhoan(username, password);
        }
    }
}
