using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class hoaDon_DTO
    {
        private string _maHD;

        public string maHD
        {
            get { return _maHD; }
            set { _maHD = value; }
        }

        private string _maKH;

        public string maKH
        {
            get { return _maKH; }
            set { _maKH = value; }
        }

        private UInt32 _tongTien;

        public UInt32 tongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }

        private string _loaiHD;

        public string loaiHD
        {
            get { return _loaiHD; }
            set { _loaiHD = value; }
        }

        private int _trangThai;

        public int trangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }

        private string _maNCC;

        public string maNCC
        {
            get { return _maNCC; }
            set { _maNCC = value; }
        }

        private string _ngayLap;

        public string ngayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = value; }
        }

        public hoaDon_DTO()
        {
            this._maHD = "";
            this._maKH = "";
            this._tongTien = 0;
            this._loaiHD = "";
            this._trangThai = 0;
            this._maNCC = "";
            this._ngayLap = "";
        }

        public void setHoaDon_Nhap(string maHD, string tongTien, string trangThai, string maNCC, string ngayLap)
        {
            this._maHD = maHD;
            this._maKH = "null";
            if (tongTien == "") tongTien = "0";
            this._tongTien = UInt32.Parse(tongTien);
            this._loaiHD = "N";
            this._trangThai = Int16.Parse(trangThai);
            this._maNCC = maNCC;
            this._ngayLap = ngayLap;
        }

        public void setHoaDon_Nhap(string maHD, string tongTien, string trangThai, string maNCC, DateTime ngayLap)
        {
            this._maHD = maHD;
            this._maKH = "null";
            if (tongTien == "") tongTien = "0";
            this._tongTien = UInt32.Parse(tongTien);
            this._loaiHD = "N";
            this._trangThai = Int16.Parse(trangThai);
            this._maNCC = maNCC;            
            this._ngayLap = ngayLap.ToString("yyyy-MM-dd hh:mm:ss");
        }

        public void setHoaDon_Ban(string maHD, string maKH, string tongTien, string trangThai, string ngayLap)
        {
            this._maHD = maHD;
            this._maKH = maKH;
            if (tongTien == "") tongTien = "0";
            this._tongTien = UInt32.Parse(tongTien);
            this._loaiHD = "X";
            this._trangThai = Int16.Parse(trangThai);
            this._maNCC = "null";
            this._ngayLap = ngayLap;
        }

        public void setHoaDon_Ban(string maHD, string maKH, string tongTien, string trangThai, DateTime ngayLap)
        {
            this._maHD = maHD;
            this._maKH = maKH;
            if (tongTien == "") tongTien = "0";
            this._tongTien = UInt32.Parse(tongTien);
            this._loaiHD = "X";
            this._trangThai = Int16.Parse(trangThai);
            this._maNCC = "null";
            this._ngayLap = ngayLap.ToString("yyyy-MM-dd hh:mm:ss");
        }
    }
}
