using QuanLiSinhVien.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien
{
     class SinhVien : Person
    {
        string MSSV;
        string MaNghanh;
        string MaLop;

        public string MSSV1 { get => MSSV; set => MSSV = value; }
        public string MaNghanh1 { get => MaNghanh; set => MaNghanh = value; }
        public string MaLop1 { get => MaLop; set => MaLop = value; }

        public SinhVien()
        {
        }

        public SinhVien(string HoTen, string DiaChi, string GioiTinh, int Tuoi,  string pMSSV, string pMaNghanh, string pMaLop) : base(HoTen, DiaChi, GioiTinh, Tuoi)
        {
            MSSV = pMSSV;
            MaNghanh = pMaNghanh;
            MaLop = pMaLop;
        }
    }

}
