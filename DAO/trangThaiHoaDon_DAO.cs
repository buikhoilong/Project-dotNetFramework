using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class trangThaiHoaDon_DAO:dbConnection
    {
        public DataTable getListTrangThaiHoaDon()
        {
            return getData("select * from TRANGTHAI_HOADON").Tables[0];
        }
    }
}
