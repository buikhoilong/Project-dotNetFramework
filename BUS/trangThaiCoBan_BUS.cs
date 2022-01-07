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
    public class trangThaiCoBan_BUS
    {
        trangThaiCoBan_DAO d = new trangThaiCoBan_DAO();

        public DataTable getListTrangThaiCoBan()
        {
            return d.getListTrangThaiCoBan(); 
        }
    }
}
