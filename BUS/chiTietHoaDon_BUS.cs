using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class chiTietHoaDon_BUS
    {
        chiTietHoaDon_DAO d = new chiTietHoaDon_DAO();

        public DataTable getListChiTietHoaDon(string maHD)
        {
            return d.getListChiTietHoaDon(maHD);
        }

        public int addChiThietHoaDon(chiTietHoaDon_DTO chiTietHoaDon)
        {
            return d.addChiThietHoaDon(chiTietHoaDon);
        }

        public int updateChiTietHoaDon(chiTietHoaDon_DTO chiTietHoaDon)
        {
            return d.updateChiTietHoaDon(chiTietHoaDon);
        }

        /// <summary>
        /// Xoá 1 CT Hoá Đơn. Dùng khi chỉnh sửa 1 Hoá Đơn
        /// </summary>
        /// <param name="maHD"></param>
        /// <param name="maSP"></param>
        /// <returns></returns>
        public int deleteChiTietHoaDon(string maHD, string maSP)
        {
            return d.deleteChiTietHoaDon(maHD, maSP);
        }

        /// <summary>
        /// Xoá tất cả CT Hoá Đơn thuộc Hoá đơn. Dùng khi xoá một hoá đơn
        /// </summary>
        /// <param name="maHD"></param>
        /// <returns></returns>
        public int deleteAllChiTietHoaDon(string maHD)
        {
            return d.deleteAllChiTietHoaDon(maHD);
        }
    }
}
