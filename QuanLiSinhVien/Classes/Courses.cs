using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Classes
{
    class Course
    {
        string MaMonHoc;
        string TenMonHoc;
        string LoaiMonHoc;
        double Price;

        public Course() { }

        public string MaMonHoc1 { get => MaMonHoc; set => MaMonHoc = value; }
        public string TenMonHoc1 { get => TenMonHoc; set => TenMonHoc = value; }
        public string LoaiMonHoc1 { get => LoaiMonHoc; set => LoaiMonHoc = value; }
        public double Price1 { get => Price; set => Price = value; }

        public Course(string pMaMonHoc, string pTenMonHoc, string pLoaiMonHoc, double pPrice)
        {
            MaMonHoc = pMaMonHoc;
            TenMonHoc = pTenMonHoc;
            LoaiMonHoc = pLoaiMonHoc;
            Price = pPrice;
        }

        public void NhapTTMonHoc()
        {
            Console.Write("Ten mon hoc: ");
            TenMonHoc = Console.ReadLine();

            Console.Write("Ma mon hoc: ");
            MaMonHoc = Console.ReadLine();

            Console.Write("Loai mon hoc: ");
            LoaiMonHoc = Console.ReadLine();

            Console.Write("Gia tien: ");
            Price = double.Parse(Console.ReadLine());
        }
    }
}
