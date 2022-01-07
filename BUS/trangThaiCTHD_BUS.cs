using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class trangThaiCTHD_BUS
    {
        DAO.trangThaiCTHD_DAO d = new DAO.trangThaiCTHD_DAO();

        public DataTable getListTrangThaiCTHD()
        {
            return d.getListTrangThaiCTHD();
        }
    }
}
