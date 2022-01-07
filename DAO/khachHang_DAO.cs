using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class khachHang_DAO:dbConnection
    {
        public DataTable getListKhachHang()
        {
            return getData("select * from KHACHHANG").Tables[0];
        }

        public int addKhachHang(khachHang_DTO kh)
        {
            string sql = "insert into KHACHHANG values(N'"+kh.maKH+"', N'" + kh.sdtKH + "',N'" + kh.tenKH + "',N'" + kh.diaChiKH + "',N'" + kh.emailKH + "'," + kh.trangThai + ")";

            return updateData(sql);
        }

        public int updateKhachHang(khachHang_DTO kh)
        {
            string sql = "update KHACHHANG set MAKH = N'" + kh.maKH + "', SDT_KH = N'" + kh.sdtKH + "', TENKH = N'" + kh.tenKH + "', DC_KH = N'" + kh.diaChiKH + "', EMAIL_KH = N'" + kh.emailKH + "', TRANGTHAI_KH = " + kh.trangThai + " where MAKH = N'" + kh.maKH + "'";


            return updateData(sql);
        }

        public string getTenKhachHangByID(string maKH)
        {
            return getData("select TENKH from KHACHHANG where MAKH = '"+maKH+"'").Tables[0].Rows[0]["TENKH"].ToString();
        }

        public int deleteKhachHang(string maKH)
        {
            string sql = "update KHACHHANG set TRANGTHAI_KH = 0 where SDT_KH = N'" + maKH + "'";
            return updateData(sql);
        }

        public DataTable searchKhachHang(string search)
        {
            return getData("select * from KHACHHANG where MAKH like N'%" + search + "%' or TENKH like N'%" + search + "%' or SDT_KH like N'%" + search + "%' or DC_KH like N'%" + search + "%' or EMAIL_KH like N'%" + search + "%'").Tables[0];
        }
        public string getMaKHbyAll(string search)
        {
            DataTable d = new DataTable();
            d = getData("select * from KHACHHANG where MAKH like N'%" + search + "%' or TENKH like N'%" + search + "%' or SDT_KH like N'%" + search + "%' or DC_KH like N'%" + search + "%' or EMAIL_KH like N'%" + search + "%'").Tables[0];
            if (d.Rows.Count > 0)
            {
                return d.Rows[0]["MAKH"].ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
