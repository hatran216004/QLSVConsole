using QuanLiSinhVien.Classes;
using QuanLiSinhVien.Managers;
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
        float DTB;
        public static float DiemChuan = 4;

        public string MSSV1 { get => MSSV; set => MSSV = value; }
        public string MaNghanh1 { get => MaNghanh; set => MaNghanh = value; }
        public string MaLop1 { get => MaLop; set => MaLop = value; }
        public float DTB1 { get => DTB; set => DTB = value; }
        public bool KetQua()
        { 
            if(DTB >= DiemChuan)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }

        public SinhVien()
        {
        }

        public SinhVien(string HoTen, string GioiTinh, int Tuoi,  string pMSSV, string pMaNghanh, string pMaLop, float pDTB) : base(HoTen, GioiTinh, Tuoi)
        {
            MSSV = pMSSV;
            MaNghanh = pMaNghanh;
            MaLop = pMaLop;
            DTB = pDTB;
        }

        public void NhapTT1SinhVien()
        {
            base.NhapThongTin();
            Console.Write("Ma so sinh vien: ");
            MSSV = Console.ReadLine();
            Console.Write("Ma nghanh: ");
            MaNghanh = Console.ReadLine();
            Console.Write("Ma lop: ");
            MaLop = Console.ReadLine();

            Console.Write("Nhap diem Toan CC");
            float DToanCC = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Anh");
            float DAnh = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem OOP");
            float DOOP = float.Parse(Console.ReadLine());
            Points managerPoints = new Points(DToanCC, DAnh, DOOP);
            DTB = managerPoints.DiemTrungBinh();
        }

        public void XuatTT1SinhVien()
        {
            string result;
            if(this.KetQua())
            {
                result = "Qua mon";
            }
            else
            {
                result = "Tach";
            }
            Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t\t{4}\t{5}\t\t{6:0.0}\t{7}", MSSV, Ten, Tuoi, GioiTinh, MaLop, MaNghanh , DTB, result);
        }
    }
}
