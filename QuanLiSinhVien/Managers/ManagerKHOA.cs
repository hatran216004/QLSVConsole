using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Managers
{
    class ManagerKHOA
    {
        public static List<KHOA> listKhoa = new List<KHOA>();
        public static KHOA CheckKhoa(String maKhoa)
        {
            foreach (KHOA khoa in listKhoa)
            {
                if (maKhoa.Equals(khoa.MaKhoa1))
                {
                    return khoa;
                }
            }
            return null;
        }

        public static void ThemKhoa()
        {
            string maKhoa;
            string tenKhoa;
            do
            {
                Console.Write("Nhap ma khoa: ");
                maKhoa = Console.ReadLine();
                if (CheckKhoa(maKhoa) != null)
                {
                    Console.WriteLine("Ma khoa da ton tai, hay nhap lai");
                }


            } while (CheckKhoa(maKhoa) == null);

            Console.WriteLine("Nhap ten khoa: ");
            tenKhoa = Console.ReadLine();
            listKhoa.Add(new KHOA(maKhoa, tenKhoa, new List<LOP>()));
        }

        public static void display()
        {
            int check = 0;
            Console.WriteLine("Ma khoa\t|\tTen khoa\t|");
            foreach (KHOA k in listKhoa)
            {
                check++;
                Console.WriteLine("{0}\t|\t{1}\t|", k.MaKhoa1, k.TenKhoa1);
            }
            if (check == 0)
            {
                Console.WriteLine("Khong co khoa de hien thi");
            }
        }

        public static void AllLopTrongKhoa(KHOA k)
        {
            if (k != null)
            {
                Console.Write("Ma khoa: {0}", k.MaKhoa1);
                Console.Write("Ten khoa: {0}", k.TenKhoa1);
                Console.Write("Ma lop\t|\tTen lop\t|");
                foreach (LOP lop in k.ListLop1)
                {
                    Console.Write("{0}\t|\t{1}\t|", lop.MaKhoa1, lop.TenLop1);
                }
            } else
            {
                Console.WriteLine("Khong tim thay khoa");
            }
        }

        public static int Menu()
        {
            int options;
            Console.WriteLine("------------- Quan ly Khoa -------------");
            Console.WriteLine("1. Danh sach khoa");
            Console.WriteLine("2. Tim khoa");
            Console.WriteLine("3. Them khoa");
            Console.WriteLine("4. Thoat");
            Console.Write("Nhap lua chon: ");
            options = int.Parse(Console.ReadLine());

            return options;

        }
    }
}
