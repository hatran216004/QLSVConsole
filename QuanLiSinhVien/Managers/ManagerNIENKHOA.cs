using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Managers
{
    class ManagerNIENKHOA
    {
        public static List<NIENKHOA> listNienKhoa = new List<NIENKHOA>();
        public static NIENKHOA CheckNienKhoa(String maNienKhoa)
        {
            foreach (NIENKHOA n in listNienKhoa)
            {
                if (maNienKhoa.Equals(n.MaNienKhoa1))
                {
                    return n;
                }
            }
            return null;
        }

        public static void ThemNienKhoa()
        {
            string maNienKhoa;
            do
            {
                Console.Write("Nhap ma nien khoa: ");
                maNienKhoa = Console.ReadLine();
                if (CheckNienKhoa(maNienKhoa) != null)
                {
                    Console.WriteLine("Ma nien khoa da ton tai, hay nhap lai");
                }
            } while (CheckNienKhoa(maNienKhoa) != null);

            listNienKhoa.Add(new NIENKHOA(maNienKhoa, new List<LOP>()));
        }

        public static void display()
        {
            Console.WriteLine("Ma nien khoa");
            foreach(NIENKHOA k in listNienKhoa)
            {
                Console.WriteLine("{0}", k.MaNienKhoa1);
            }
        }

        public static void AllKhoaTrongNK(NIENKHOA nk)
        {
            if (nk != null)
            {
                Console.WriteLine("Ma khoa: {0}", nk.MaNienKhoa1);
                Console.WriteLine("Ma lop\t|\tTen lop\t|");
                foreach (LOP lop in nk.ListLop1)
                {
                    Console.WriteLine("{0}\t|\t{1}\t|", lop.MaKhoa1, lop.TenLop1);
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay nien khoa");
            }
        }
        public static int Menu()
        {
            int options;
            Console.WriteLine("------------- Quan ly nien khoa -------------");
            Console.WriteLine("1. Danh sach nien khoa");
            Console.WriteLine("2. Tim nien khoa");
            Console.WriteLine("3. Them nien khoa");
            Console.WriteLine("4. Thoat");
            Console.Write("Nhap lua chon: ");
            options = int.Parse(Console.ReadLine());

            return options;

        }
    }
}
