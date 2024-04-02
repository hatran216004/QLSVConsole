using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien
{
     class LOP
    {
        string MaLop;
        string MaKhoa;
        string TenLop;
        List<SinhVien> ListSV;

        public string MaLop1 { get => MaLop; set => MaLop = value; }
        public string MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }
        public string TenLop1 { get => TenLop; set => TenLop = value; }
        public List<SinhVien> ListSV1 { get => ListSV; set => ListSV = value; }

        public LOP(string maLop, string maKhoa, string tenLop, List<SinhVien> listSV)
        {
            MaLop = maLop;
            MaKhoa = maKhoa;
            TenLop = tenLop;
            ListSV = listSV;
        }
        public LOP() { }
    }
}
