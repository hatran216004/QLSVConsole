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

        public string MSSV1
        {
            get => MSSV;

            set
            {
                bool isValid = false;
                for (int i = 2; i < value.Length; i++)
                {
                    if (!char.IsDigit(value[i]))
                    {
                        isValid = true;
                        break;
                    }
                }

                if (isValid && !value.StartsWith("SV"))
                {
                    MSSV = "SV00";
                }
                else
                {
                    MSSV = value;
                }
            }
        }

        public string MaNghanh1 { get => MaNghanh; set => MaNghanh = value; }
        public string MaLop1 { get => MaLop; set => MaLop = value; }
        public float DTB1 { get => DTB; set => DTB = value; }
        public string KetQua
        {
            get
            {
                if (DTB >= DiemChuan)
                {
                    return "Dau";
                }
                else
                {
                    return "Tach";
                }
            }
        }

        public string XepLoai
        {
            get
            {
                if (DTB >= 8)
                {
                    return "Gioi";
                }
                else if (DTB >= 7)
                {
                    return "Kha";
                }
                else if (DTB >= 5)
                {
                    return "Trung Binh";
                }
                else
                {
                    return "Yeu";
                }
            }
        }

        public SinhVien()
        {
        }

        public SinhVien(string HoTen, string GioiTinh, int Tuoi, string pMSSV, string pMaNghanh, string pMaLop, float pDTB) : base(HoTen, GioiTinh, Tuoi)
        {
            MSSV = pMSSV;
            MaNghanh = pMaNghanh;
            MaLop = pMaLop;
            DTB = pDTB;
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Ma so sinh vien: ");
            MSSV = Console.ReadLine();

            Console.Write("Ma nghanh: ");
            MaNghanh = Console.ReadLine();
            Console.Write("Ma lop: ");
            MaLop = Console.ReadLine();

            Console.Write("Nhap diem Toan cao cap");
            float DToanCC = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Anh");
            float DAnh = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Van");
            float DVan = float.Parse(Console.ReadLine());
            Points managerPoints = new Points(DToanCC, DAnh, DVan, MSSV);
            DTB = managerPoints.DiemTrungBinh();
        }

        public void XuatTT1SinhVien()
        {
            Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t\t{4}\t{5}\t\t{6:0.0}\t{7}\t\t{8}", MSSV, Ten, Tuoi, GioiTinh, MaLop, MaNghanh, DTB, KetQua, XepLoai);
        }
    }
}
