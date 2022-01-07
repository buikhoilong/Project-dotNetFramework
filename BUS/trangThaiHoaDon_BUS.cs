using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO; 

namespace BUS
{
    public class trangThaiHoaDon_BUS
    {
        trangThaiHoaDon_DAO d = new trangThaiHoaDon_DAO();

        public DataTable getListTrangThaiHoaDon()
        {
            return d.getListTrangThaiHoaDon();
        }
    }
}
