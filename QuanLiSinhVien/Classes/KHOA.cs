using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien
{
     class KHOA
    {
        string MaKhoa;
        string TenKhoa;
        List<LOP> ListLop;

        public string MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }
        public string TenKhoa1 { get => TenKhoa; set => TenKhoa = value; }
        public List<LOP> ListLop1 { get => ListLop; set => ListLop = value; }

        public KHOA(string maKhoa, string tenKhoa, List<LOP> listLop)
        {
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
            ListLop = listLop;
        }
        public KHOA() { }
    }
}
