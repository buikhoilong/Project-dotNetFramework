using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class trangThaiSanPham_DAO:dbConnection
    {
        public DataTable getListTrangThaiSanPham()
        {
            return getData("select * from TRANGTHAI_SANPHAM").Tables[0];
        }
    }
}
