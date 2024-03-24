using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Classes
{
    class PERSON
    {
        protected string HoTen;
        protected string GioiTinh;
        protected string DiaChi;
        protected int Tuoi;

        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public int Tuoi1 { get => Tuoi; set => Tuoi = value; }

        public PERSON(string pHoTen, string pGioiTinh, string pDiaChi, int pTuoi)
        {
            HoTen = pHoTen;
            GioiTinh = pGioiTinh;
            DiaChi = pDiaChi;
            Tuoi = pTuoi;
        }

        public PERSON() { }

        protected void NhapTT()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap gioi tinh: ");
            GioiTinh = Console.ReadLine();

            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();

            Console.Write("Nhap tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());
        }
    }
}
