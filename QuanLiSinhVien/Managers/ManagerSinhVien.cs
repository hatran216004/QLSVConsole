﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QuanLiSinhVien.Managers
{
    class ManagerSinhVien
    {
        public static List<SinhVien> ListSV = new List<SinhVien>();

        public void AddStudent()
        {
            string mssv;
            bool checkSV = false;
            do
            {
                Console.Write("Ma so sinh vien: ");
                mssv = Console.ReadLine();

                foreach (SinhVien sv in ListSV)
                {
                    if (sv.MSSV1 == mssv)
                    {
                        checkSV = true;
                        Console.WriteLine("Sinh vien da ton tai");
                    }
                }

            } while (checkSV);

            Console.WriteLine("----------------- Nhap thong tin sinh vien -----------------");
            SinhVien student = new SinhVien();
            Points points = new Points();

            student.MSSV1 = mssv;

            Console.Write("Ho ten: ");
            student.Ten1 = Console.ReadLine();

            Console.Write("Gioi tinh: ");
            student.GioiTinh1 = Console.ReadLine();

            Console.Write("Tuoi: ");
            student.Tuoi1 = int.Parse(Console.ReadLine());

            Console.Write("Ma nghanh: ");
            student.MaNghanh1 = Console.ReadLine();

            Console.Write("Ma lop: ");
            student.MaLop1 = Console.ReadLine();

            Console.Write("Nhap diem Toan cao cap: ");
            points.DToanCC1 = float.Parse(Console.ReadLine());

            Console.Write("Nhap diem Anh: ");
            points.DAnh1 = float.Parse(Console.ReadLine());

            Console.Write("Nhap diem Van: ");
            points.DVan1 = float.Parse(Console.ReadLine());

            points.MSSV2 = student.MSSV1;

            student.DTB1 = points.DiemTrungBinh();

            ManagerPoints.listPoints.Add(points);
            ListSV.Add(student);
            Console.WriteLine("Them sinh vien {0} thanh cong!", student.Ten1);
        }

        public void DelStudent()
        {
            string mssv;
            bool checkSV = false;
            do
            {
                Console.Write("Ma so sinh vien: ");
                mssv = Console.ReadLine();

                foreach (SinhVien sv in ListSV)
                {
                    if (sv.MSSV1 == mssv)
                    {
                        checkSV = true;
                        ListSV.Remove(sv);
                        Console.WriteLine("Xoa sinh vien {0} thanh cong!", sv.MSSV1);
                        break;
                    }
                }

                if (!checkSV)
                {
                    Console.WriteLine("Sinh vien khong ton tai!");
                }
            } while (!checkSV);
        }

        public void XuatDSSinhVien()
        {
            Console.WriteLine("\nMSSV\tHo ten\t\t\tTuoi\tGioi tinh\tMa lop\tMa nghanh\tDTB\tKet qua\t\tXep loai\n");
            foreach (SinhVien sv in ListSV)
            {
                sv.XuatTT1SinhVien();
            }
        }

        public void DocFileDSSV(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList nodeList = read.SelectNodes("/DSSV/SinhVien");
            foreach (XmlNode node in nodeList)
            {
                Points points = new Points();
                SinhVien sv = new SinhVien();
                sv.Ten1 = node["HoTen"].InnerText;
                sv.Tuoi1 = int.Parse(node["Tuoi"].InnerText);
                sv.GioiTinh1 = node["GioiTinh"].InnerText;
                sv.MSSV1 = node["MSSV"].InnerText;
                sv.MaLop1 = node["MaLop"].InnerText;
                sv.MaNghanh1 = node["MaNghanh"].InnerText;

                float DToanCC = float.Parse(node["DiemToan"].InnerText);
                float DAnh = float.Parse(node["DiemAnh"].InnerText);
                float DVan = float.Parse(node["DiemVan"].InnerText);

                points.DToanCC1 = DToanCC;
                points.DAnh1 = DAnh;
                points.DVan1 = DVan;
                points.MSSV2 = sv.MSSV1;
                ManagerPoints.listPoints.Add(points);
                sv.DTB1 = points.DiemTrungBinh();

                ListSV.Add(sv);
            }
        }

        public void SortDTB()
        {
            ListSV = ListSV.OrderBy(t => t.DTB1).ToList();
        }

        public void FilterResolveAndReject()
        {
            List<SinhVien> List1 = new List<SinhVien>();
            List<SinhVien> List2 = new List<SinhVien>();
            List1 = ListSV.Where(t => t.KetQua == "Dau").ToList();
            List2 = ListSV.Where(t => t.KetQua == "Tach").ToList();

            Console.WriteLine("\n\t\t\t------------------ Danh sach sinh vien qua mon ------------------\n");
            Console.WriteLine("\nMSSV\tHo ten\t\t\tTuoi\tGioi tinh\tMa lop\tMa nghanh\tDTB\tKet qua\t\tXep loai\n");
            foreach (SinhVien sv in List1)
            {
                sv.XuatTT1SinhVien();
            }

            Console.WriteLine("\n\t\t\t------------------ Danh sach sinh vien tach mon ------------------\n");
            Console.WriteLine("\nMSSV\tHo ten\t\t\tTuoi\tGioi tinh\tMa lop\tMa nghanh\tDTB\tKet qua\t\tXep loai\n");
            foreach (SinhVien sv in List2)
            {
                sv.XuatTT1SinhVien();
            }
        }

        public void EditInfoStudent()
        {
            string mssv;
            bool checkSV = false;

            do
            {
                Console.Write("Ma so sinh vien: ");
                mssv = Console.ReadLine();

                foreach (SinhVien sv in ListSV)
                {
                    if (mssv == sv.MSSV1)
                    {
                        foreach (Points p in ManagerPoints.listPoints)
                        {
                            if (mssv == p.MSSV2)
                            {
                                int options;
                                Console.WriteLine("\n\t\t\t------------------ Edit thong tin sinh vien {0} ------------------\n", sv.Ten1);

                                Console.WriteLine("1. Ma so sinh vien");
                                Console.WriteLine("2. Ten sinh vien");
                                Console.WriteLine("3. Ma lop");
                                Console.WriteLine("4. Ma nghanh");
                                Console.WriteLine("5. Tuoi");
                                Console.WriteLine("6. Gioi tinh");
                                Console.WriteLine("7. Diem Toan cao cap");
                                Console.WriteLine("8. Diem Anh");
                                Console.WriteLine("9. Diem Van");

                                Console.Write("Nhap lua chon: ");
                                options = int.Parse(Console.ReadLine());

                                switch (options)
                                {
                                    case 1:
                                        {
                                            Console.Write("Nhap ma so sinh vien moi: ");
                                            sv.MSSV1 = Console.ReadLine();
                                            Console.WriteLine("Da sua ma so sinh vien thanh cong!");
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Write("Nhap ten sinh vien moi: ");
                                            sv.Ten1 = Console.ReadLine();
                                            Console.WriteLine("Da sua ten sinh vien thanh cong!");
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Write("Nhap ma lop moi: ");
                                            sv.MaLop1 = Console.ReadLine();
                                            Console.WriteLine("Da sua ma lop thanh cong!");
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.Write("Nhap ma nghanh moi: ");
                                            sv.MaNghanh1 = Console.ReadLine();
                                            Console.WriteLine("Da sua ma nghanh thanh cong!");
                                            break;
                                        }
                                    case 5:
                                        {
                                            Console.Write("Nhap tuoi moi: ");
                                            sv.Tuoi1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Da sua tuoi thanh cong!");
                                            break;
                                        }
                                    case 6:
                                        {
                                            Console.Write("Nhap gioi tinh moi: ");
                                            sv.GioiTinh1 = Console.ReadLine();
                                            Console.WriteLine("Da sua gioi tinh thanh cong!");
                                            break;
                                        }
                                    case 7:
                                        {
                                            Console.Write("Nhap diem toan cao cap moi: ");
                                            p.DToanCC1 = float.Parse(Console.ReadLine());
                                            Console.WriteLine("Da sua diem toan cao cap thanh cong!");
                                            break;
                                        }
                                    case 8:
                                        {
                                            Console.Write("Nhap diem anh moi: ");
                                            p.DAnh1 = float.Parse(Console.ReadLine());
                                            Console.WriteLine("Da sua diem anh thanh cong!");
                                            break;
                                        }
                                    case 9:
                                        {
                                            Console.Write("Nhap diem Van moi: ");
                                            p.DVan1 = float.Parse(Console.ReadLine());
                                            Console.WriteLine("Da sua diem Van thanh cong!");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Lua chon khong hop le!");
                                            break;
                                        }
                                }
                            }
                        }

                        checkSV = true;
                        Console.WriteLine("\nMSSV\tHo ten\t\t\tTuoi\tGioi tinh\tMa lop\tMa nghanh\tDTB\tKet qua\t\tXep loai\n");
                        sv.XuatTT1SinhVien();
                        break; // Kết thúc vòng lặp khi tìm thấy sinh viên cần sửa
                    }
                }

                if (!checkSV)
                {
                    Console.WriteLine("Khong tim thay sinh vien co ma so {0}!", mssv);
                }

            } while (!checkSV);
        }

        public SinhVien TimKiemSinhVien(string mssv)
        {

            foreach (SinhVien sv in ListSV)
            {
                if (sv.MSSV1 == mssv)
                {
                    return sv;
                }
            }
            return null;

        }
    }

}
