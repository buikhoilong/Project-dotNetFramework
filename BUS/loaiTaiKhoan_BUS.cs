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
    public class loaiTaiKhoan_BUS
    {
        loaiTaiKhoan_DAO d = new loaiTaiKhoan_DAO();

        public DataTable getListLoaiTaiKhoan()
        {
            return d.getListLoaiTaiKhoan();
        }
    }
}
