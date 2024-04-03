using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Classes
{
    class Person
    {
        protected string Ten, GioiTinh;
        protected int Tuoi;

        public string Ten1 { get => Ten; set => Ten = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public int Tuoi1 { get => Tuoi; set => Tuoi = value; }

        public Person() { }

        public Person(string pTen, string pGioiTinh, int pTuoi)
        {
            Ten = pTen;
            GioiTinh = pGioiTinh;
            Tuoi = pTuoi;
        }

        public virtual void NhapThongTin()
        {
            Console.Write("Ho ten: ");
            Ten = Console.ReadLine();
            Console.Write("Gioi tinh: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());
        }
    }
}
