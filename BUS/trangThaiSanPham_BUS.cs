using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class trangThaiSanPham_BUS
    {
        trangThaiSanPham_DAO d = new trangThaiSanPham_DAO();

        public DataTable getListTrangThaiSanPham()
        {
            return d.getListTrangThaiSanPham();
        }
    }
}
