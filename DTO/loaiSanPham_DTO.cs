using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class loaiSanPham_DTO
    {
        private string _maLoaiSP;

        public string maLoaiSP
        {
            get { return _maLoaiSP; }
            set { _maLoaiSP = value; }
        }

        private string _tenLoaiSP;

        public string tenLoaiSP
        {
            get { return _tenLoaiSP; }
            set { _tenLoaiSP = value; }
        }

        private int _trangThaiLoaiSP;

        public int trangThaiLoaiSP
        {
            get { return _trangThaiLoaiSP; }
            set { _trangThaiLoaiSP = value; }
        }

        public loaiSanPham_DTO(string maLoai, string tenLoai, int trangThai)
        {
            this._maLoaiSP = maLoai;
            this._tenLoaiSP = tenLoai;
            this._trangThaiLoaiSP = trangThai;
        }

        public void setLoaiSanPham(string maLoai, string tenLoai, string trangThai)
        {
            this._maLoaiSP = maLoai;
            this._tenLoaiSP = tenLoai;
            this._trangThaiLoaiSP = Int16.Parse(trangThai);
        }

        public void setLoaiSanPham(string maLoai, string tenLoai, int trangThai)
        {
            this._maLoaiSP = maLoai;
            this._tenLoaiSP = tenLoai;
            this._trangThaiLoaiSP = trangThai;
        }


    }
}
