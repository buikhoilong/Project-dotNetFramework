using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class chiTietHoaDon_DAO:dbConnection
    {
        public DataTable getListChiTietHoaDon(string maHD)
        {
            return getData("select * from CHITIET_HOADON where MA_HD = '" + maHD + "'").Tables[0];
        }

        public int addChiThietHoaDon(chiTietHoaDon_DTO chiTietHoaDon)
        {
            string sql = "insert into CHITIET_HOADON values('" + chiTietHoaDon.maHD + "', '" + chiTietHoaDon.maSP + "', " + chiTietHoaDon.trangThai + ", " + chiTietHoaDon.soLuong + ", " + chiTietHoaDon.donGia + ", " + chiTietHoaDon.giam + "," + chiTietHoaDon.thanhTien + ")";
            return updateData(sql);
        }

        public int updateChiTietHoaDon(chiTietHoaDon_DTO chiTietHoaDon)
        {
            string sql = "update CHITIET_HOADON set MA_HD = N'" + chiTietHoaDon.maHD + "', MA_SP = '" + chiTietHoaDon.maSP + "', SOLUONG = " + chiTietHoaDon.soLuong + ", DONGIA = " + chiTietHoaDon.donGia + ", GIAM = " + chiTietHoaDon.giam + ", THANHTIEN = " + chiTietHoaDon.thanhTien + ", TRANGTHAI_CTHD = " + chiTietHoaDon.trangThai + " where MA_HD = '" + chiTietHoaDon.maHD + "' and MA_SP = '" + chiTietHoaDon.maSP + "'";
            return updateData(sql);
        }

        /// <summary>
        /// Xoá 1 CT Hoá Đơn. Dùng khi chỉnh sửa 1 Hoá Đơn
        /// </summary>
        /// <param name="maHD"></param>
        /// <param name="maSP"></param>
        /// <returns></returns>
        public int deleteChiTietHoaDon(string maHD, string maSP)
        {
            string sql = "update CHITIET_HOADON set TRANGTHAI_CTHD = 0 where MA_HD = '" + maHD + "' and MA_SP = '" + maSP + "'";
            return updateData(sql);
        }

        /// <summary>
        /// Xoá tất cả CT Hoá Đơn thuộc Hoá đơn. Dùng khi xoá một hoá đơn
        /// </summary>
        /// <param name="maHD"></param>
        /// <returns></returns>
        public int deleteAllChiTietHoaDon(string maHD)
        {
            string sql = "delete from CHITIET_HOADON where MA_HD = '" + maHD + "'";
            return updateData(sql);
        }
    }
}
