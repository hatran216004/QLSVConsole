using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien
{
     class SinhVien
    {
        string MSSV;
        string MaNghanh;
        string MaLop;
        string HoTen;
        string GioiTinh;

        public string MSSV1 { get => MSSV; set => MSSV = value; }
        public string MaNghanh1 { get => MaNghanh; set => MaNghanh = value; }
        public string MaLop1 { get => MaLop; set => MaLop = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }

        public SinhVien()
        {
        }

        public SinhVien(string mSSV, string maNghanh, string maLop, string hoTen, string gioiTinh)
        {
            MSSV = mSSV;
            MaNghanh = maNghanh;
            MaLop = maLop;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
        }
    }

}
