using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class loaiSanPham_DAO:dbConnection
    {        
        public DataTable getListLoaiSanPham()
        {
            string sql = "select * from LOAISANPHAM";
            return getData(sql).Tables[0];
        }

        public int addLoaiSanPham(loaiSanPham_DTO loaisanpham)
        {
            string sql = "insert into LOAISANPHAM values(N'" + loaisanpham.maLoaiSP + "',N'" + loaisanpham.tenLoaiSP + "'," + loaisanpham.trangThaiLoaiSP + ")";

            return updateData(sql);
        }

        public int updateLoaiSanPham(loaiSanPham_DTO loaisanpham)
        {
            string sql = "update LOAISANPHAM set MALOAISP = N'"+loaisanpham.maLoaiSP+ "', TENLOAISP = N'" + loaisanpham.tenLoaiSP + "', TRANGTHAI_LOAISP = " + loaisanpham.trangThaiLoaiSP + " where MALOAISP like N'%" + loaisanpham.maLoaiSP + "%'";
            return updateData(sql);
        }

        public int deleteLoaiSanPham(string maLoai)
        {
            string sql = "delete from LOAISANPHAM where MALOAISP like N'%" + maLoai + "%'";
            return updateData(sql);
        }
    }
}
