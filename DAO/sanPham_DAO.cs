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
    public class sanPham_DAO:dbConnection
    {
        public DataTable getListSanPham()
        {
            string sql = "select * from SANPHAM";
            return getData(sql).Tables[0];
        }

        public int addSanPham(sanPham_DTO sanPham)
        {
            string sql = "insert into SANPHAM values( N'" + sanPham.maSanPham + "', N'" + sanPham.tenSanPham + "', " + sanPham.giaNhap + ", " + sanPham.giaBan + ", " + sanPham.tonKho + ", " + sanPham.trangThaiSP + ", N'" + sanPham.maLoai + "', N'" + sanPham.maNhaCungCap + "', N'" + sanPham.moTaSP + "')";
            return updateData(sql);
        }

        public int updateSanPham(sanPham_DTO sanPham)
        {
            string sql = "update SANPHAM set MASP = N'" + sanPham.maSanPham + "', TENSP = N'" + sanPham.tenSanPham + "', GIA_NHAP = " + sanPham.giaNhap + ", GIA_BAN = " + sanPham.giaBan + ", TONKHO = " + sanPham.tonKho + ", TRANGTHAI_SP = " + sanPham.trangThaiSP + ", MALOAI = N'" + sanPham.maLoai + "', MA_NCC = N'" + sanPham.maNhaCungCap + "', MO_TA_SP = N'" + sanPham.moTaSP + "' WHERE MASP = N'" + sanPham.maSanPham + "'";
            return updateData(sql);
        }

        public int deleteSanPham(string maSanPham)
        {
            string sql = "delete from SANPHAM where MASP = N'" + maSanPham + "'";
            return updateData(sql);
        }

        public DataTable searchSanPham(string search)
        {
            string sql = "select * from SANPHAM where MASP like N'%" + search + "%' or TENSP like N'%" + search + "%' or MALOAI like N'%" + search + "%' or MA_NCC like N'%" + search + "%' or MO_TA_SP like N'%" + search + "%'";
            return getData(sql).Tables[0];
        }
    }
}
