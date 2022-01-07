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
    public class nhaCungCap_BUS
    {
        nhaCungCap_DAO d = new nhaCungCap_DAO();

        public DataTable getListNhaCungCap()
        {
            return d.getListNhaCungCap();
        }

        public int addNhaCungCap(nhaCungCap_DTO nhaCungCap)
        {
            return d.addNhaCungCap(nhaCungCap);
        }

        public int updateNhaCungCap(nhaCungCap_DTO nhaCungCap)
        {
            return d.updateNhaCungCap(nhaCungCap);
        }

        public int deteleNhaCungCap(string maNCC)
        {
            return d.deteleNhaCungCap(maNCC);
        }
    }
}
