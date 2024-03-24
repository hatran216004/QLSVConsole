using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien
{
     class NIENKHOA
    {
        string MaNienKhoa;
        List<LOP> ListLop;

        public string MaNienKhoa1 { get => MaNienKhoa; set => MaNienKhoa = value; }
        public List<LOP> ListLop1 { get => ListLop; set => ListLop = value; }

        public NIENKHOA(string maNienKhoa, List<LOP> listLop)
        {
            MaNienKhoa = maNienKhoa;
            ListLop = listLop;
        }
        public NIENKHOA() { }
    }
}
