using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class trangThaiCoBan_DTO
    {
        private int _trangThai;

        public int trangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }

        private string _tenTrangThai;

        public string tenTrangThai
        {
            get { return _tenTrangThai; }
            set { _tenTrangThai = value; }
        }


    }
}
