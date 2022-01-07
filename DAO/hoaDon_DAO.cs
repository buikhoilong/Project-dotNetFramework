using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class hoaDon_DAO:dbConnection
    {
        public DataTable getListHoaDon(string loaiHD)
        {
            return getData("select * from HOADON where LOAIHD = '" + loaiHD + "'").Tables[0];//lấy bảng đầu tiên trong dataset
        }
        public DataTable getMaHD(string maHD)
        {
            return getData("select MAHD from HOADON order by MAHD").Tables[0];
        }

        public int addHoaDon(hoaDon_DTO hoaDon)
        {
            string maKhachHang = "";
            string maNhaCungCap = "";
            if (hoaDon.loaiHD == "N")
            {
                maKhachHang = hoaDon.maKH;
                maNhaCungCap = "'" + hoaDon.maNCC + "'";                
            }
            else
            {
                maKhachHang = "'" + hoaDon.maKH + "'";
                maNhaCungCap = hoaDon.maNCC;
            }
            string sql = "insert into HOADON values('" + hoaDon.maHD + "', " + maKhachHang + ", " + hoaDon.tongTien + ", '" + hoaDon.loaiHD + "', " + hoaDon.trangThai + ", " + maNhaCungCap + ", '" + hoaDon.ngayLap + "')";
            return updateData(sql);
        }



        public int updateHoaDon(hoaDon_DTO hoaDon)
        {
            string maKhachHang = "";
            string maNhaCungCap = "";
            if (hoaDon.loaiHD == "N")
            {
                maKhachHang = hoaDon.maKH;
                maNhaCungCap = "'" + hoaDon.maNCC + "'";
            }
            else
            {
                maKhachHang = "'" + hoaDon.maKH + "'";
                maNhaCungCap = hoaDon.maNCC;
            }
            string sql = "update HOADON set MA_KH = " + maKhachHang + ", TONGTIEN = " + hoaDon.tongTien + ", TRANGTHAI_HD =  " + hoaDon.trangThai + ", MA_NCC = " + maNhaCungCap + ", NGAYLAP_HD = '" + hoaDon.ngayLap + "' where MAHD = '" + hoaDon.maHD + "'";
            return updateData(sql);
        }

        public int updateTongTienHoaDon(string maHD, string tongTien)
        {
            string sql = "update HOADON set  TONGTIEN = " + tongTien + " where MAHD = '" + maHD + "'";
            return updateData(sql);
        }

        public int deleteHoaDon(string maHD)
        {
            string sql = "update HOADON set TRANGTHAI_HD = 0 where MAHD = '" + maHD + "'";
            return updateData(sql);
        }

        public DataTable searchHoaDonNhap(string search)
        {
            string sql = "select * from HOADON where MAHD like '%" + search + "%' or MA_KH like '%" + search + "%' or NGAYLAP_HD like '%" + search + "%'";
            return getData(sql).Tables[0];
        }
    }
}
