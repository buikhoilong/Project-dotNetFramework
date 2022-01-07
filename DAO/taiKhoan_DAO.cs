using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class taiKhoan_DAO :dbConnection
    {
        public DataTable getListTaiKhoan()
        {
            return getData("select * from TAIKHOAN").Tables[0];
        }

        public int addTaiKhoan(taiKhoan_DTO tk)
        {
            string sql = "insert into TAIKHOAN values(N'" + tk.username + "',N'" + tk.password + "',N'" + tk.email + "',N'" + tk.moTaTK + "'," + tk.trangThaiTK + ",N'" + tk.loaiTaiKhoan + "')";

            return updateData(sql);
        }

        public int updateTaiKhoan(taiKhoan_DTO tk)
        {
            string sql = "update TAIKHOAN set USERNAME = N'" + tk.username + "', PASSWORD = N'" + tk.password + "', EMAIL = N' " + tk.email + "', MOTA_TK = N'" + tk.moTaTK + "', TRANGTHAI_TK = " + tk + ", LOAI_TK = N'" + tk + "' where USERNAME like N'%" + tk.username + "%'";
            return updateData(sql);
        }

        public int deleteTaiKhoan(string username)
        {
            string sql = "delete from TAIKHOAN where USERNAME like N'%" + username + "%'";
            return updateData(sql);
        }

        /// <summary>
        /// Kiểm tra Tài khoản tồn tại
        /// </summary>
        /// <param name="username">Tên đăng nhập (khoá chính)</param>
        /// <param name="password">Mật khẩu</param>
        /// <returns>Nếu tồn tại trả về TRUE, không tồn tại là FALSE</returns>
        public bool checkTaiKhoan(string username, string password) //Account exist → return true, else return false;
        {
            DataTable d = new DataTable();
            d = getData("select USERNAME, PASSWORD from TAIKHOAN WHERE USERNAME like N'%" + username + "%' and PASSWORD = N'" + password + "'").Tables[0];
            int result = d.Rows.Count;            
            return (result!=0);
        }
    }
}
