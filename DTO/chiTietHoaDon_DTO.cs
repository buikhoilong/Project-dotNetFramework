using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class chiTietHoaDon_DTO
    {
        private string _maHD;

        public string maHD
        {
            get { return _maHD; }
            set { _maHD = value; }
        }

        private string _maSP;

        public string maSP
        {
            get { return _maSP; }
            set { _maSP = value; }
        }

        private int _soLuong;

        public int soLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        private UInt32 _donGia;

        public UInt32 donGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }

        private UInt32 _giam;

        public UInt32 giam
        {
            get { return _giam; }
            set { _giam = value; }
        }

        private UInt32 _thanhTien;

        public UInt32 thanhTien
        {
            get { return _thanhTien; }
            set { _thanhTien = value; }
        }

        private int _trangThai;

        public int trangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }

        public chiTietHoaDon_DTO()
        {
            this._maHD = "";
            this._maSP = "";
            this._soLuong = 0;
            this._donGia = 0;
            this._giam = 0;
            this._thanhTien = 0;
            this._trangThai = 0;
        }

        public void setChiTietHoaDon(string maHD, string maSP, string soLuong, string donGia, string giam, string thanhTien, string trangThai)
        {
            this._maHD = maHD;
            this._maSP = maSP;
            if (soLuong == "") soLuong = "0";
            this._soLuong = Int16.Parse(soLuong);
            if (donGia == "") donGia = "0";
            this._donGia = UInt32.Parse(donGia);
            if (giam == "") giam = "0";
            this._giam = UInt32.Parse(giam);
            if (thanhTien == "") thanhTien = "0";
            this._thanhTien = UInt32.Parse(thanhTien);
            this._trangThai = Int16.Parse(trangThai);
        }
    }
}
