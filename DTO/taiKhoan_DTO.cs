using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class taiKhoan_DTO
    {
        private string _username;

        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _password;

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _email;

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _moTaTK;

        public string moTaTK
        {
            get { return _moTaTK; }
            set { _moTaTK = value; }
        }

        private int _trangThaiTK;

        public int trangThaiTK
        {
            get { return _trangThaiTK; }
            set { _trangThaiTK = value; }
        }

        private string _loaiTaiKhoan;

        public string loaiTaiKhoan
        {
            get { return _loaiTaiKhoan; }
            set { _loaiTaiKhoan = value; }
        }

        public taiKhoan_DTO(string username, string password, string email, string moTaTK, int trangThai, string loaiTaiKhoan)
        {
            this._username = username;
            this._password = password;
            this._email = email;
            this._moTaTK = moTaTK;
            this._trangThaiTK = trangThai;
            this._loaiTaiKhoan = loaiTaiKhoan;
        }

        public void setTaiKhoan(string username, string password, string email, string moTaTK, int trangThai, string loaiTaiKhoan)
        {
            this._username = username;
            this._password = password;
            this._email = email;
            this._moTaTK = moTaTK;
            this._trangThaiTK = trangThai;
            this._loaiTaiKhoan = loaiTaiKhoan;
        }

        public void setTaiKhoan(string username, string password, string email, string moTaTK, string trangThai, string loaiTaiKhoan)
        {
            this._username = username;
            this._password = password;
            this._email = email;
            this._moTaTK = moTaTK;
            this._trangThaiTK = Int16.Parse(trangThai);
            this._loaiTaiKhoan = loaiTaiKhoan;
        }

    }
}
