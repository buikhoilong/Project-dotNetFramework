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
    public class khachHang_BUS
    {
        khachHang_DAO d = new khachHang_DAO();
        public DataTable getListKhachHang()
        {
            return d.getData("select * from KHACHHANG").Tables[0];
        }

        public int addKhachHang(khachHang_DTO kh)
        {
            return d.addKhachHang(kh);
        }

        public int updateKhachHang(khachHang_DTO kh)
        {
            return d.updateKhachHang(kh);
        }

        public string getTenKhachHangByID(string maKH)
        {
            return d.getTenKhachHangByID(maKH);
        }

        public int deleteKhachHang(string maKH)
        {
            return d.deleteKhachHang(maKH);
        }

        public DataTable searchKhachHang(string search)
        {
            return d.searchKhachHang(search);
        }
        /// <summary>
        /// Search Mã Khách hàng bằng mọi thuộc tính trong KHACHHANG (MAKH,TENKH,SDT_KH,DC_KH,EMAIL_KH).    
        /// 
        /// </summary>
        /// <param name="search"></param>
        /// <returns>Nếu có nhiều hơn 1 MAKH được tìm thì chỉ trả ra kết quả đầu tiên!</returns>
        public string getMaKHbyAll(string search)
        {
            return d.getMaKHbyAll(search);
        }
    }
}
