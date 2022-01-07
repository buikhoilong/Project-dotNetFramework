using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class loaiTaiKhoan_DTO
    {
        private string _maLoaiTK;

        public string maLoaiTK
        {
            get { return _maLoaiTK; }
            set { _maLoaiTK = value; }
        }

        private string _tenLoaiTK;

        public string tenLoaiTK
        {
            get { return _tenLoaiTK; }
            set { _tenLoaiTK = value; }
        }

        private int _trangThaiLoaiTK;

        public int trangthaiLoaiTK
        {
            get { return _trangThaiLoaiTK; }
            set { _trangThaiLoaiTK = value; }
        }

        public loaiTaiKhoan_DTO(string maLoaiTK, string tenlToaiTK, int trangthai)
        {
            this._maLoaiTK = maLoaiTK;
            this._tenLoaiTK = tenlToaiTK;
            this._trangThaiLoaiTK = trangthai;
        }

        public void setLoaiTaiKhoan(string maLoaiTK, string tenlToaiTK, int trangthai)
        {
            this._maLoaiTK = maLoaiTK;
            this._tenLoaiTK = tenlToaiTK;
            this._trangThaiLoaiTK = trangthai;
        }

        public void setLoaiTaiKhoan(string maLoaiTK, string tenlToaiTK, string trangthai)
        {
            this._maLoaiTK = maLoaiTK;
            this._tenLoaiTK = tenlToaiTK;
            this._trangThaiLoaiTK = Int16.Parse(trangthai);
        }
    }
}
