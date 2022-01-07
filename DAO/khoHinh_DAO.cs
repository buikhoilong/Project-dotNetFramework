using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class khoHinh_DAO:dbConnection
    {
        public DataTable getListKhoHinh()
        {
            string sql = "select * from KHOHINH";
            return getData(sql).Tables[0];
        }

        public int addKhoHinh(khoHinh_DTO kh)
        {
            string sql = "insert into KHOHINH (MADOITUONG, TENFILE, GHICHU) values(N'" + kh.maDoiTuong+ "',N'" + kh.tenFile + "'," + kh.ghiChu + ")";

            return updateData(sql);
        }

        public int updateKhoHinh(khoHinh_DTO kh)
        {
            string sql = "update KHOHINH set MADOITUONG = N'" + kh.maDoiTuong+ "', TENFILE = N'" + kh.tenFile + "', GHICHU = " + kh.ghiChu+ " where MALOAISP like N'%" + kh.maHinh + "%'";
            return updateData(sql);
        }

        public int deleteKhoHinh(string maDoiTuong)
        {
            string sql = "delete from KHOHINH where MADOITUONG = N'" + maDoiTuong + "'";
            return updateData(sql);
        }

        /// <summary>
        /// Lấy tên file hình sản phẩm theo mã sản phẩm
        /// </summary>
        /// <param name="maDoiTuong"></param>
        /// <returns>Danh sách mã hình thuộc sản phẩm</returns>
        public DataTable getHinhByMaDoiTuong(string maDoiTuong)
        {
            return getData("select * from KHOHINH where MADOITUONG= N'" + maDoiTuong + "'").Tables[0];
        }
    }
}
