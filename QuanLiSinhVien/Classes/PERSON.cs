using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Classes
{
    class Person
    {
        protected string Ten, DiaChi, GioiTinh;
        protected int Tuoi;

        public string Ten1 { get => Ten; set => Ten = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public int Tuoi1 { get => Tuoi; set => Tuoi = value; }

        public Person() { }

        public Person(string ten, string diaChi, string gioiTinh, int tuoi)
        {
            Ten = ten;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            Tuoi = tuoi;
        }
    }
}
