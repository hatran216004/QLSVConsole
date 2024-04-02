using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Managers
{
    class ManagerLOP
    {
        public static List<LOP> ListLop = new List<LOP>();
        public static void display()
        {
            int check = 0;
            Console.WriteLine("Ma lop\t|\tTen lop\t|\tNien khoa\t|\tKhoa|");
            foreach (LOP lop in ListLop)
            {
                check++;
                Console.WriteLine("{0}\t|\t{1}\t|\t{2}\t|\t{3}|", lop.MaLop1, lop.TenLop1);
            }
            if (check == 0)
            {
                Console.WriteLine("Khong co lop nao!");
            }
        }

        public static LOP CheckLop(string maLop)
        {
            foreach (LOP lop in ListLop)
            {
                if (maLop.Equals(lop.MaLop1))
                {
                    return lop;
                }
            }
            return null;
        }

        public static void ThemLop()
        {
            string maLop;
            string maKhoa;
            string tenLop;

            do
            {
                Console.Write("Nhap ma lop: ");
                maLop = Console.ReadLine();
                if (CheckLop(maLop) != null)
                {
                    Console.WriteLine("Ma lop da ton tai, hay nhap lai");
                }
            } while (CheckLop(maLop) == null);

            Console.Write("Nhap ten lop: ");
            tenLop = Console.ReadLine();

            do
            {
                Console.Write("Nhap ma khoa: ");
                maKhoa = Console.ReadLine();
                if (ManagerKHOA.CheckKhoa(maKhoa) == null)
                {
                    Console.WriteLine("Ma khoa khong ton tai, hay nhap lai");
                }
            } while (ManagerKHOA.CheckKhoa(maKhoa) != null);


            LOP lop = new LOP(maLop, maKhoa, tenLop, new List<SinhVien>());
            ListLop.Add(lop);
            KHOA k = new KHOA();
            k.ListLop1.Add(lop);
            NIENKHOA nk = new NIENKHOA();
            nk.ListLop1.Add(lop);
            Console.WriteLine("Them thanh cong");
        }

        public static int Menu()
        {
            int options;
            Console.WriteLine("------------- Quan ly Lop -------------");
            Console.WriteLine("1. Danh sach sinh vien");
            Console.WriteLine("2. Them sinh vien");
            Console.WriteLine("3. Xoa sinh vien");
            Console.WriteLine("4. Thoat");
            Console.Write("Nhap lua chon: ");
            options = int.Parse(Console.ReadLine());

            return options;

        }
    }
}
