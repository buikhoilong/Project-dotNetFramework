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
    public class nhaCungCap_DAO:dbConnection
    {
        public DataTable getListNhaCungCap()
        {
            string sql = "select * from NHACUNGCAP";
            return getData(sql).Tables[0];
        }

        public int addNhaCungCap(nhaCungCap_DTO nhaCungCap)
        {
            string sql = "insert into NHACUNGCAP values(N'" + nhaCungCap.maNCC + "',N'" + nhaCungCap.tenNCC + "','" + nhaCungCap.sdtNCC + "',N'" + nhaCungCap.diaChiNCC + "',N'" + nhaCungCap.tkNCC + "','" + nhaCungCap.stkNCC + "', " + nhaCungCap.trangThai + ")";
            return updateData(sql);
        }

        public int updateNhaCungCap(nhaCungCap_DTO nhaCungCap)
        {
            string sql = "update NHACUNGCAP set MANCC = N'" + nhaCungCap.maNCC + "', TENNCC = N'" + nhaCungCap.tenNCC + "', SDT_NCC = '" + nhaCungCap.sdtNCC + "', TK_NCC = N'" + nhaCungCap.tkNCC + "', STK_NCC = '" + nhaCungCap.stkNCC + "', TRANGTHAI_NCC = " + nhaCungCap.trangThai + " where MANCC = N'" + nhaCungCap.maNCC + "'";
            return updateData(sql);
        }

        public int deteleNhaCungCap(string maNCC)
        {
            string sql = "delete from NHACUNGCAP where MANCC = '" + maNCC + "'";
            return updateData(sql);
        }
    }
}
