using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class khoHinh_DTO
    {
        private string _maHinh;

        public string maHinh
        {
            get { return _maHinh; }
            set { _maHinh = value; }
        }

        private string _maDoiTuong;

        public string maDoiTuong
        {
            get { return _maDoiTuong; }
            set { _maDoiTuong = value; }
        }

        private string _tenFile;

        public string tenFile
        {
            get { return _tenFile; }
            set { _tenFile = value; }
        }

        private string _ghiChu;

        public string ghiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        public khoHinh_DTO()
        {
            this._maHinh = "";
            this._maDoiTuong = "";
            this._tenFile = "";
            this._ghiChu = "";
        }

        public khoHinh_DTO(string maDoiTuong, string tenFile, string ghiChu)
        {
            this._maHinh = "";
            this._maDoiTuong = maDoiTuong;
            this._tenFile = tenFile;
            this._ghiChu = ghiChu;
        }

        public void setKhoHinh(string maHinh, string maDoiTuong, string tenFile, string ghiChu)
        {
            this._maHinh = maHinh;
            this._maDoiTuong = maDoiTuong;
            this._tenFile = tenFile;
            this._ghiChu = ghiChu;
        }

        public void setKhoHinh(string maDoiTuong, string tenFile, string ghiChu)
        {
            this._maHinh = "";
            this._maDoiTuong = maDoiTuong;
            this._tenFile = tenFile;
            this._ghiChu = ghiChu;
        }
    }
}
