using QuanLiSinhVien.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QuanLiSinhVien.Managers
{
    class ManagerCourses
    {
        public List<Course> ListCourse = new List<Course>();

        public void DocFileDSMonHoc(string file)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);

            // Trích xuất danh sách các môn học từ các phần tử "MonHoc" trong tệp XML
            XmlNodeList lapTrinhWebNodes = doc.SelectNodes("/DSMonHoc/LapTrinhWeb/MonHoc");
            XmlNodeList ngoaiNguNodes = doc.SelectNodes("/DSMonHoc/NgoaiNgu/MonHoc");
            XmlNodeList toanNodes = doc.SelectNodes("/DSMonHoc/Toan/MonHoc");

            foreach (XmlNode node in lapTrinhWebNodes)
            {
                Course course = new Course();
                course.TenMonHoc1 = node["TenMonHoc"].InnerText;
                course.MaMonHoc1 = node["MaMonHoc"].InnerText;
                course.Price1 = double.Parse(node["Price"].InnerText);
                course.LoaiMonHoc1 = "Lap trinh web";
                ListCourse.Add(course);
            }

            foreach (XmlNode node in ngoaiNguNodes)
            {
                Course course = new Course();
                course.TenMonHoc1 = node["TenMonHoc"].InnerText;
                course.MaMonHoc1 = node["MaMonHoc"].InnerText;
                course.Price1 = double.Parse(node["Price"].InnerText);
                course.LoaiMonHoc1 = "Ngoai ngu";
                ListCourse.Add(course);
            }

            foreach (XmlNode node in toanNodes)
            {
                Course course = new Course();
                course.TenMonHoc1 = node["TenMonHoc"].InnerText;
                course.MaMonHoc1 = node["MaMonHoc"].InnerText;
                course.Price1 = double.Parse(node["Price"].InnerText);
                course.LoaiMonHoc1 = "Toan";
                ListCourse.Add(course);
            }
        }

        public void XuatDanhSachMonHoc()
        {
            int options;
            do
            {
                Console.WriteLine("\n--------------- Phan loai mon hoc ---------------\n");
                Console.WriteLine("\n1. Lap trinh web");
                Console.WriteLine("2. Ngoai ngu");
                Console.WriteLine("3. Toan");
                Console.WriteLine("4. Xuat danh sach tat ca mon hoc");
                Console.WriteLine("5. Exit");


                Console.Write("Nhap lua chon: ");
                options = int.Parse(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        {
                            Console.WriteLine("\n--------------- Danh sach mon hoc Lap trinh web ---------------\n");
                            Console.WriteLine("Ma mon hoc\tTen mon hoc\t\t\tGia\n");
                            // Lặp qua danh sách các môn học trong nhóm Lap trinh web
                            foreach (Course monHoc in ListCourse.Where(mh => mh.LoaiMonHoc1 == "Lap trinh web"))
                            {
                                Console.WriteLine("{0}\t\t{1, -20}\t\t{2} VND", monHoc.MaMonHoc1, monHoc.TenMonHoc1, monHoc.Price1);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\n--------------- Danh sach mon hoc Ngoai ngu ---------------\n");
                            Console.WriteLine("Ma mon hoc\tTen mon hoc\t\t\tGia\n");
                            // Lặp qua danh sách các môn học trong nhóm Ngoai ngu
                            foreach (Course monHoc in ListCourse.Where(mh => mh.LoaiMonHoc1 == "Ngoai ngu"))
                            {
                                Console.WriteLine("{0}\t\t{1, -20}\t\t{2} VND", monHoc.MaMonHoc1, monHoc.TenMonHoc1, monHoc.Price1);
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\n--------------- Danh sach mon hoc Toan ---------------\n");
                            Console.WriteLine("Ma mon hoc\tTen mon hoc\t\t\tGia\n");
                            // Lặp qua danh sách các môn học trong nhóm Toan
                            foreach (Course monHoc in ListCourse.Where(mh => mh.LoaiMonHoc1 == "Toan"))
                            {
                                Console.WriteLine("{0}\t\t{1, -20}\t\t{2} VND", monHoc.MaMonHoc1, monHoc.TenMonHoc1, monHoc.Price1);
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\n--------------- Danh sach cac mon hoc ---------------\n");
                            Console.WriteLine("Ma mon hoc\tTen mon hoc\t\t\tGia\n");
                            foreach (Course monHoc in ListCourse)
                            {
                                Console.WriteLine("{0}\t\t{1, -20}\t\t{2} VND", monHoc.MaMonHoc1, monHoc.TenMonHoc1, monHoc.Price1);
                            }
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while (options != 5);
        }
    }
}
