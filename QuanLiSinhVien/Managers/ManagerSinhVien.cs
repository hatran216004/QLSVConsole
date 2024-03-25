using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Managers
{
    class ManagerSinhVien
    {
        //  Biến tĩnh list sv lưu các obj SinhVien
        public static List<SinhVien> ListSV = new List<SinhVien>();
        public static SinhVien CheckSV(string MSSV)
        {
            foreach (SinhVien sv in ListSV)
            {
                // Nếu mã số sinh viên tồn tại, return sinh viên
                if (sv.MSSV1 == MSSV)
                {
                    return sv;
                }
            }
            // Mã số vinh viên không tồn tại
            return null;
        }

        public static void AddStudent(string MaLop)
        {
            string MSSV;
            string MaNghanh;
            string HoTen;
            string GioiTinh;
            string DiaChi;
            int Tuoi;
            SinhVien sv;

            do
            {
                Console.Write("Ma so sinh vien: ");
                MSSV = Console.ReadLine();

                sv = ManagerSinhVien.CheckSV(MSSV);

                if (sv != null)
                {
                    Console.WriteLine("Ma so sinh vien da ton tai, vui long nhap lai!");
                }
            } while (sv != null);

            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap gioi tinh: ");
            GioiTinh = Console.ReadLine();

            Console.Write("Nhap ma nganh: ");
            MaNghanh = Console.ReadLine();

            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();

            Console.Write("Nhap ma nganh: ");
            Tuoi = int.Parse(Console.ReadLine());

            sv = new SinhVien(HoTen, DiaChi, GioiTinh, Tuoi, MSSV, MaNghanh, MaLop);
            ListSV.Add(sv);

            if (ManagerLOP.CheckLop(MaLop) != null)
            {
                ManagerLOP.CheckLop(MaLop).ListSV1.Add(sv);
            }

        }

        public static void DelStudent(LOP lop)
        {
            string MSSV;
            SinhVien sv;
            do
            {
                Console.Write("Nhap ma so sinh vien can xoa: ");
                MSSV = Console.ReadLine();

                sv = CheckSV(MSSV);

                // Check mssv xem có tồn tại sv hay không, nếu có thì xóa
                if (sv == null)
                {
                    Console.WriteLine("Ma so sinh vien khong ton tai, vui long nhap lai!");
                }
                else
                {
                    ListSV.Remove(sv);
                    lop.ListSV1.Remove(sv);
                    Console.WriteLine("Xoa sinh vien thanh cong!");
                }
            } while (sv == null);

        }

        public static void display(LOP lop)
        {
            int check = 0;
            Console.WriteLine("Ten lop: {0}", lop.TenLop1);
            Console.WriteLine("MSSV\t|\tMa nghanh\t|\tHo ten\t|\tGioi tinh\t|\tMa lop\t|\tDia chi\t|\tTuoi|");
            foreach (SinhVien sv in lop.ListSV1)
            {
                check++;
                Console.WriteLine("{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|\t{4}\t|\t{5}\t|\t{6}|", sv.MSSV1, sv.MaNghanh1, sv.Ten1, sv.GioiTinh1, lop.MaLop1, sv.DiaChi1, sv.Tuoi1);
            }
            if (check == 0)
            {
                Console.WriteLine("Lop trong!");
            }
        }

    }

}
