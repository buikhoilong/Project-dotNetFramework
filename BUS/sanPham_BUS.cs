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
    public class sanPham_BUS
    {
        sanPham_DAO d = new sanPham_DAO();

        public DataTable getListSanPham()
        {
            return d.getListSanPham();
        }

        public int addSanPham(sanPham_DTO sanPham)
        {
            return d.addSanPham(sanPham);
        }

        public int updateSanPham(sanPham_DTO sanPham)
        {
            return d.updateSanPham(sanPham);
        }

        public int deleteSanPham(string maSanPham)
        {
            return d.deleteSanPham(maSanPham);
        }

        public DataTable searchSanPham(string search)
        {
            return d.searchSanPham(search);
        }
    }
}
