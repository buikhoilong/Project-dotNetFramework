using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class trangThaiCoBan_DAO:dbConnection
    {
        public DataTable getListTrangThaiCoBan()
        {
            return getData("select * from TRANGTHAI_COBAN").Tables[0];
        }
    }
}
