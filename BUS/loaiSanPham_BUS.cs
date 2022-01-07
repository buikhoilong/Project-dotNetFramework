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
    public class loaiSanPham_BUS
    {
        loaiSanPham_DAO d = new loaiSanPham_DAO();

        public DataTable getListLoaiSanPham()
        {
            return d.getListLoaiSanPham();
        }

        public int addLoaiSanPham(loaiSanPham_DTO loaisanpham)
        {
            return d.addLoaiSanPham(loaisanpham);
        }

        public int updateLoaiSanPham(loaiSanPham_DTO loaiSanPham)
        {
            return d.updateLoaiSanPham(loaiSanPham);
        }

        public int deleteLoaiSanPham(string maLoai)
        {
            return d.deleteLoaiSanPham(maLoai);
        }
        
    }
}
