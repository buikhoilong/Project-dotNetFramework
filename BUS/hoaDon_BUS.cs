using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class hoaDon_BUS
    {
        hoaDon_DAO d = new hoaDon_DAO();

        public DataTable getListHoaDon(string loaiHD)
        {
            return d.getListHoaDon(loaiHD);
        }

        public int addHoaDon(hoaDon_DTO hoaDon)
        {
            return d.addHoaDon(hoaDon);
        }

        public int updateHoaDon(hoaDon_DTO hoaDon)
        {
            return d.updateHoaDon(hoaDon);
        }

        public int updateTongTienHoaDon(string maHD, string tongTien)
        {

            return d.updateTongTienHoaDon(maHD, tongTien);
        }

        public int deleteHoaDon(string maHD)
        {
            return d.deleteHoaDon(maHD);
        }
    }
}
