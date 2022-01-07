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
    public class khoHinh_BUS
    {
        khoHinh_DAO d = new khoHinh_DAO();

        public DataTable getListKhoHinh()
        {
            return d.getListKhoHinh();
        }

        public int addKhoHinh(khoHinh_DTO kh)
        {
            return d.addKhoHinh(kh);
        }

        public int updateKhoHinh(khoHinh_DTO kh)
        {
            return d.updateKhoHinh(kh);
        }

        public int deleteKhoHinh(string maDoiTuong)
        {
            return d.deleteKhoHinh(maDoiTuong);
        }

        /// <summary>
        /// Lấy tên file hình sản phẩm theo mã sản phẩm
        /// </summary>
        /// <param name="maDoiTuong"></param>
        /// <returns>Danh sách mã hình thuộc sản phẩm</returns>
        public DataTable getHinhByMaDoiTuong(string maDoiTuong)
        {
            return d.getHinhByMaDoiTuong(maDoiTuong);
        }
    }
}
