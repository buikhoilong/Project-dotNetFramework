using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class trangThaiCTHD_DAO:dbConnection
    {
        public DataTable getListTrangThaiCTHD()
        {
            return getData("select * from TRANGTHAI_CT_HOADON").Tables[0];
        }
    }
}
