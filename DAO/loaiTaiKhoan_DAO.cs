using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class loaiTaiKhoan_DAO : dbConnection
    {
        public DataTable getListLoaiTaiKhoan()
        {
            return getData("select * from LOAITAIKHOAN").Tables[0];
        }
    }
}
