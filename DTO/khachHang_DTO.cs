using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class khachHang_DTO
    {
        private string _maKH;

        public string maKH
        {
            get { return _maKH; }
            set { _maKH = value; }
        }


        private string _sdtKH;

        public string sdtKH
        {
            get { return _sdtKH; }
            set { _sdtKH = value; }
        }

        private string _tenKH;

        public string tenKH
        {
            get { return _tenKH; }
            set { _tenKH = value; }
        }

        private string _diaChiKH;

        public string diaChiKH
        {
            get { return _diaChiKH; }
            set { _diaChiKH = value; }
        }

        private string _emailKH;

        public string emailKH
        {
            get { return _emailKH; }
            set { _emailKH = value; }
        }

        private int _trangThai;

        public int trangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }

        public khachHang_DTO()
        {
            this._maKH = "";
            this._sdtKH = "";
            this._tenKH = "";
            this._diaChiKH = "";
            this._emailKH = "";
            this._trangThai = 0;
        }

        public khachHang_DTO(string maKH, string tenKH, string sdt, string diaChi, string email, int trangThai)
        {
            this._maKH = maKH;
            this._sdtKH = sdt;
            this._tenKH = tenKH;
            this._diaChiKH = diaChi;
            this._emailKH = email;
            this._trangThai = trangThai;
        }

        public void setKhachHang(string maKH, string tenKH, string sdt, string diaChi, string email, int trangThai)
        {
            this._maKH = maKH;
            this._sdtKH = sdt;
            this._tenKH = tenKH;
            this._diaChiKH = diaChi;
            this._emailKH = email;
            this._trangThai = trangThai;
        }

        public void setKhachHang(string maKH, string tenKH, string sdt, string diaChi, string email, string trangThai)
        {
            this._maKH = maKH;
            this._sdtKH = sdt;
            this._tenKH = tenKH;
            this._diaChiKH = diaChi;
            this._emailKH = email;
            this._trangThai = Int16.Parse(trangThai);
        }

    }
}
