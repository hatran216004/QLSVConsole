using QuanLiSinhVien.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            run();

            Console.ReadLine();
        }

        static int Menu()
        {
            int options;
            Console.WriteLine("---------------------- Menu ----------------------");
            Console.WriteLine("1. Danh sach lop");
            Console.WriteLine("2. Quan ly lop");
            Console.WriteLine("3. Them lop");
            Console.WriteLine("4. Quan ly khoa");
            Console.WriteLine("5. Quan ly nien khoa");
            Console.WriteLine("6. Thoat");
            Console.WriteLine("---------------------- Menu ----------------------");
            Console.Write("Nhap lua chon: ");
            options = int.Parse(Console.ReadLine());
            return options;
        }

        static void run()
        {
            int options;
            do
            {
                options = Menu();
                switch (options)
                {
                    case 1:
                        {
                            ManagerLOP.display();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Nhap ma lop: ");
                            string maLop = Console.ReadLine();
                            LOP lop = ManagerLOP.CheckLop(maLop);
                            int menuLop;
                            if (lop != null)
                            {
                                do
                                {
                                    menuLop = ManagerLOP.Menu();
                                    switch (menuLop)
                                    {
                                        case 1:
                                            {
                                                ManagerSinhVien.display(lop);
                                                break;
                                            }
                                        case 2:
                                            {
                                                ManagerSinhVien.AddStudent(lop.MaLop1);
                                                break;
                                            }
                                        case 3:
                                            {
                                                ManagerSinhVien.DelStudent(lop);
                                                break;
                                            }
                                        case 4:
                                            {
                                                break;
                                            }
                                        default:
                                            Console.WriteLine("Hay nhap 1 - 4");
                                            break;
                                    }

                                } while (menuLop != 4);

                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay lop");
                            }

                            break;
                        }
                    case 3:
                        {
                            if (ManagerNIENKHOA.listNienKhoa.Count == 0)
                            {
                                Console.WriteLine("Hay them nien khoa truoc khi them lop!");
                            }
                            else if (ManagerKHOA.listKhoa.Count == 0)
                            {
                                Console.WriteLine("Hay them khoa truoc khi them lop!");
                            }
                            else
                            {
                                ManagerLOP.ThemLop();
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Nhap ma khoa");
                            string maKhoa = Console.ReadLine();
                            KHOA khoa = ManagerKHOA.CheckKhoa(maKhoa);

                            int menuKhoa;
                            if (khoa != null)
                            {
                                do
                                {
                                    menuKhoa = ManagerKHOA.Menu();
                                    switch (menuKhoa)
                                    {
                                        case 1:
                                            {
                                                ManagerKHOA.display();
                                                break;
                                            }
                                        case 2:
                                            {
                                                // Tìm khoa để in ra các lớp trong khoa
                                                Console.WriteLine("Nhap ma khoa muon tim");
                                                string mk = Console.ReadLine();
                                                KHOA k = ManagerKHOA.CheckKhoa(mk);
                                                ManagerKHOA.AllLopTrongKhoa(k);
                                                break;
                                            }
                                        case 3:
                                            {
                                                ManagerKHOA.ThemKhoa();
                                                break;
                                            }
                                        case 4:
                                            break;
                                        default:
                                            Console.WriteLine("Hay nhap 1 - 4");
                                            break;
                                    }
                                } while (menuKhoa != 4);
                            }

                            break;
                        }
                    case 5:
                        {
                            int menuNienKhoa;
                            do
                            {
                                menuNienKhoa = ManagerNIENKHOA.Menu();
                                switch (menuNienKhoa)
                                {
                                    case 1:
                                        {
                                            ManagerNIENKHOA.display();
                                            break;
                                        }
                                    case 2:
                                        {
                                            // Tìm nien khoa để in ra các lớp trong khoa
                                            Console.WriteLine("Nhap ma nien khoa muon tim: ");
                                            string maNK = Console.ReadLine();
                                            NIENKHOA _nk = ManagerNIENKHOA.CheckNienKhoa(maNK);
                                            ManagerNIENKHOA.AllKhoaTrongNK(_nk);
                                            break;
                                        }
                                    case 3:
                                        {
                                            ManagerNIENKHOA.ThemNienKhoa();
                                            break;
                                        }
                                    case 4:
                                        break;
                                    default:
                                        Console.WriteLine("Hay nhap 1 - 4");
                                        break;
                                }
                            } while (menuNienKhoa != 4);
                            break;
                        }
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Vui long nhap 1 - 6");
                        break;
                }
            } while (options != 6);
        }
    }
}
