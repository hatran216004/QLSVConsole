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

        public Course() { }

        public string MaMonHoc1 { get => MaMonHoc; set => MaMonHoc = value; }
        public string TenMonHoc1 { get => TenMonHoc; set => TenMonHoc = value; }

        public Course(string pMaMonHoc, string pTenMonHoc)
        {
            MaMonHoc = pMaMonHoc;
            TenMonHoc = pTenMonHoc;
        }

        public void NhapTTMonHoc()
        {
            Console.Write("Ten mon hoc: ");
            TenMonHoc = Console.ReadLine();
            Console.Write("Ma mon hoc: ");
            MaMonHoc = Console.ReadLine();
        }
    }
}
