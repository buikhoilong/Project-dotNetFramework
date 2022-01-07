using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class sanPham_DTO
    {
        private string _maSanPham;

        public string maSanPham
        {
            get { return _maSanPham; }
            set { _maSanPham = value; }
        }

        private string _tenSanPham;

        public string tenSanPham
        {
            get { return _tenSanPham; }
            set { _tenSanPham = value; }
        }

        private UInt32 _giaNhap;

        public UInt32 giaNhap
        {
            get { return _giaNhap; }
            set { _giaNhap = value; }
        }

        private UInt32 _giaBan;

        public UInt32 giaBan
        {
            get { return _giaBan; }
            set { _giaBan = value; }
        }

        private int _tonKho;

        public int tonKho
        {
            get { return _tonKho; }
            set { _tonKho = value; }
        }

        private int _trangThaiSP;

        public int trangThaiSP
        {
            get { return _trangThaiSP; }
            set { _trangThaiSP = value; }
        }
        private string _maLoai;

        public string maLoai
        {
            get { return _maLoai; }
            set { _maLoai = value; }
        }
        private string _maNhaCungCap;

        public string maNhaCungCap
        {
            get { return _maNhaCungCap; }
            set { _maNhaCungCap = value; }
        }
        private string _moTaSP;

        public string moTaSP
        {
            get { return _moTaSP; }
            set { _moTaSP = value; }
        }
        public sanPham_DTO(string maSanPham, string tenSanPham, int gianhap, int giaban, int tonKho, int trangthai, string maLoai, string mancc, string mota)
        {
            this._maSanPham = maSanPham;
            this._tenSanPham = tenSanPham;
            this._giaNhap = UInt32.Parse(gianhap.ToString());
            this._giaBan = UInt32.Parse(giaban.ToString());
            this.tonKho = tonKho;
            this._trangThaiSP = trangthai;
            this._maLoai = maLoai;
            this._maNhaCungCap = mancc;
            this._moTaSP = mota;
        }

        public sanPham_DTO()
        {
            this._maSanPham = "";
            this._tenSanPham = "";
            this._giaNhap = 0;
            this._giaBan = 0;
            this.tonKho = 0;
            this._trangThaiSP = 0;
            this._maLoai = "";
            this._maNhaCungCap = "";
            this._moTaSP = "";
        }

        public void setsanPham(string maSanPham, string tenSanPham, int gianhap, int giaban, int tonKho, int trangthai, string maLoai, string mancc, string mota)
        {
            this._maSanPham = maSanPham;
            this._tenSanPham = tenSanPham;            
            this._giaNhap = UInt32.Parse(gianhap.ToString());
            this._giaBan = UInt32.Parse(giaban.ToString());
            this._tonKho = tonKho;
            this._trangThaiSP = trangthai;
            this._maLoai = maLoai;
            this._maNhaCungCap = mancc;
            this._moTaSP = mota;
        }

        public void setsanPham(string maSanPham, string tenSanPham, string gianhap, string giaban, string tonKho, string trangthai, string maLoai, string mancc, string mota)
        {
            this._maSanPham = maSanPham; 
            this._tenSanPham = tenSanPham;
            if (gianhap == "")
            {
                gianhap = "0";
            }
            if(giaban == "")
            {
                giaban = "0";
            }
            if (tonKho == "")
            {
                tonKho = "0";
            }
                this._giaNhap = UInt32.Parse(gianhap);
            this._giaBan = UInt32.Parse(giaban);
            this.tonKho = Int16.Parse(tonKho);
            this._trangThaiSP = Int16.Parse(trangthai);
            this._maLoai = maLoai;
            this._maNhaCungCap = mancc;
            this._moTaSP = mota;
        }
    }
}
