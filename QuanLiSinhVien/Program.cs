using QuanLiSinhVien.Classes;
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
            ManagerPoints mp = new ManagerPoints();
            ManagerSinhVien ds = new ManagerSinhVien();
            ds.DocFileDSSV("../../filesXML/DanhSachSinhVien.xml");
            ManagerCourses courses = new ManagerCourses();
            courses.DocFileDSMonHoc("../../filesXML//DanhSachMonHoc.xml");
            Registration registration = new Registration();

            int options;
            do
            {
                Console.WriteLine("\n------------------ Menu ------------------\n");
                Console.WriteLine("1. Xuat danh sach sinh vien");
                Console.WriteLine("2. Dang ki mon hoc");
                Console.WriteLine("3. Xuat danh sach mon hoc sinh vien da dang ki");
                Console.WriteLine("4. Huy dang ki mon hoc");
                Console.WriteLine("5. Them sinh vien");
                Console.WriteLine("6. Xoa sinh vien");
                Console.WriteLine("7. Sap xep sinh vien DTB tang dan");
                Console.WriteLine("8. Xuat thong tin diem sinh vien cac mon hoc");
                Console.WriteLine("9. Loc tat ca sinh vien qua & tach mon");
                Console.WriteLine("10. Sua thong tin sinh vien");
                Console.WriteLine("11. Tim kiem sinh vien");
                Console.WriteLine("\n------------------ End ------------------\n");
                Console.Write("Nhap lua chon: ");
                options = int.Parse(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        {
                            ds.XuatDSSinhVien();
                            break;
                        }
                    case 2:
                        {
                            string mssv;
                            Console.Write("Nhap ma so sinh vien can dang ky: ");
                            mssv = Console.ReadLine();

                            courses.XuatDanhSachMonHoc();
                            string selectedCourse;
                            bool checkCourse = false;
                            bool checkSV = false;

                            foreach (SinhVien sv in ManagerSinhVien.ListSV)
                            {
                                if (mssv == sv.MSSV1)
                                {
                                    string a;
                                    do
                                    {
                                        checkSV = true;
                                        Console.Write("\nNhap ten mon hoc can dang ky: ");
                                        selectedCourse = Console.ReadLine();

                                        foreach (Course course in courses.ListCourse)
                                        {
                                            if (course.TenMonHoc1 == selectedCourse)
                                            {
                                                checkCourse = true;
                                                registration.RegisterCourse(sv, course);
                                            }
                                        }

                                        if (!checkCourse)
                                        {
                                            Console.WriteLine("Mon hoc khong ton tai!");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Dang ky thanh cong!");
                                        }

                                        Console.WriteLine("Ban muon tiep tuc dang ky ? Co / Khong");
                                        a = Console.ReadLine();
                                    } while (a == "Co");
                                }
                            }

                            if (checkSV == false)
                            {
                                Console.WriteLine("Ma sinh vien khong ton tai!");
                            }
                            break;
                        }
                    case 3:
                        {
                            string mssv;
                            Console.Write("Nhap ma so sinh vien: ");
                            mssv = Console.ReadLine();
                            registration.InDanhSachMHDangKy(mssv);
                            break;
                        }
                    case 4:
                        {
                            string mssv;
                            Console.Write("Nhap ma so sinh vien muon huy dang ky: ");
                            mssv = Console.ReadLine();

                            string selectedCourse;
                            bool checkCourse = false;
                            bool checkSV = false;

                            foreach (SinhVien sv in ManagerSinhVien.ListSV)
                            {
                                if (mssv == sv.MSSV1)
                                {
                                    checkSV = true;
                                    Console.Write("\nNhap ten mon hoc muon huy dang ky: ");
                                    selectedCourse = Console.ReadLine();

                                    foreach (Course course in courses.ListCourse)
                                    {
                                        if (course.TenMonHoc1 == selectedCourse)
                                        {
                                            checkCourse = true;
                                            registration.CancelRegisterCourse(sv, course);
                                        }
                                    }

                                    if (!checkCourse)
                                    {
                                        Console.WriteLine("Mon hoc khong ton tai!");
                                        break;
                                    }
                                }
                            }

                            if (checkSV == false)
                            {
                                Console.WriteLine("Ma sinh vien khong ton tai!");
                            }
                            break;
                        }
                    case 5:
                        {
                            ds.AddStudent();
                            break;
                        }
                    case 6:
                        {
                            ds.DelStudent();
                            break;
                        }
                    case 7:
                        {
                            ds.SortDTB();
                            ds.XuatDSSinhVien();
                            break;
                        }
                    case 8:
                        {
                            mp.ShowPointsStudents();
                            break;
                        }
                    case 9:
                        {
                            ds.FilterResolveAndReject();
                            break;
                        }
                    case 10:
                        {
                            ds.EditInfoStudent();
                            break;
                        }
                    case 11:
                        {
                            string mssv;
                            SinhVien sinhVien = new SinhVien();
                            do
                            {
                                Console.Write("\nNhap ma so sinh vien: ");
                                mssv = Console.ReadLine();
                                sinhVien = ds.TimKiemSinhVien(mssv);
                                if (sinhVien != null)
                                {
                                    Console.WriteLine("\nMSSV\tHo ten\t\t\tTuoi\tGioi tinh\tMa lop\tMa nghanh\tDTB\tKet qua\t\tXep loai\n");
                                    sinhVien.XuatTT1SinhVien();
                                }
                                else
                                {
                                    Console.WriteLine("Vui long nhaop dung ma so sinh vien!");
                                }

                            } while (sinhVien == null);
                            break;
                        }
                    default:
                        break;
                }
            } while (true);
        }

    }
}
