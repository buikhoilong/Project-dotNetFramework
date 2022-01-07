using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class nhaCungCap_DTO
    {
        private string _maNCC;

        public string maNCC
        {
            get { return _maNCC; }
            set { _maNCC = value; }
        }

        private string _tenNCC;

        public string tenNCC
        {
            get { return _tenNCC; }
            set { _tenNCC = value; }
        }

        private string _sdtNCC;

        public string sdtNCC
        {
            get { return _sdtNCC; }
            set { _sdtNCC = value; }
        }

        private string _diaChiNCC;

        public string diaChiNCC
        {
            get { return _diaChiNCC; }
            set { _diaChiNCC = value; }
        }

        private string _tkNCC;

        public string tkNCC
        {
            get { return _tkNCC; }
            set { _tkNCC = value; }
        }

        private string _stkNCC;

        public string stkNCC
        {
            get { return _stkNCC; }
            set { _stkNCC = value; }
        }

        private int _trangThai;

        public int trangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }

        public nhaCungCap_DTO()
        {
            this._maNCC = "";
            this._tenNCC = "";
            this._sdtNCC = "";
            this._diaChiNCC = "";
            this._tkNCC = "";
            this._stkNCC = "";
            this.trangThai = 0;
        }

        public nhaCungCap_DTO(string maNCC, string tenNCC, string sdtNCC, string diaChi, string taiKhoanNH, string soTaiKhoanNH, int trangThai)
        {
            this._maNCC = maNCC;
            this._tenNCC = tenNCC;
            this._sdtNCC = sdtNCC;
            this._diaChiNCC = diaChi;
            this._tkNCC = taiKhoanNH;
            this._stkNCC = soTaiKhoanNH;
            this.trangThai = trangThai;
        }

        public void setNhaCungCap (string maNCC, string tenNCC, string sdtNCC, string diaChi, string taiKhoanNH, string soTaiKhoanNH, int trangThai)
        {
            this._maNCC = maNCC;
            this._tenNCC = tenNCC;
            this._sdtNCC = sdtNCC;
            this._diaChiNCC = diaChi;
            this._tkNCC = taiKhoanNH;
            this._stkNCC = soTaiKhoanNH;
            this.trangThai = trangThai;
        }

        public void setNhaCungCap (string maNCC, string tenNCC, string sdtNCC, string diaChi, string taiKhoanNH, string soTaiKhoanNH, string trangThai)
        {
            this._maNCC = maNCC;
            this._tenNCC = tenNCC;
            this._sdtNCC = sdtNCC;
            this._diaChiNCC = diaChi;
            this._tkNCC = taiKhoanNH;
            this._stkNCC = soTaiKhoanNH;
            this.trangThai = Int16.Parse(trangThai);
        }
}
}
