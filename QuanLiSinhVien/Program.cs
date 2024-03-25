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
            int options;
            do
            {
                Console.WriteLine("\n------------------ Menu ------------------\n");
                Console.WriteLine("1. Doc va xuat danh sach sinh vien");
                Console.WriteLine("2. Dang ki mon hoc");
                Console.WriteLine("3. Xuat danh sach mon hoc sinh vien da dang ki");
                Console.WriteLine("\n------------------ End ------------------\n");
                Console.Write("Nhap lua chon: ");
                options = int.Parse(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        {
                            ManagerSinhVien ds = new ManagerSinhVien();
                            ds.DocFileDSSV("C:\\Users\\ADMIN\\OneDrive\\Documents\\Project_school\\C#\\QuanLiSinhVien\\QuanLiSinhVien\\filesXML\\DanhSachSinhVien.xml");
                            ds.XuatDSSinhVien();
                            break;
                        }
                    case 2:
                        {
                            SinhVien student = new SinhVien();
                            Course course = new Course();

                            Console.WriteLine("\n----------------- Nhap thong tin mon hoc muon dang ki -----------------\n");
                            course.NhapTTMonHoc();
                            Console.Write("Ma so sinh vien: ");
                            student.MSSV1 = Console.ReadLine();
                            Console.Write("Ma ten sinh vien: ");
                            student.Ten1 = Console.ReadLine();
                            Registration.RegisterCourse(student, course);

                            Console.WriteLine("Dang ky thanh cong!");

                            break;
                        }
                    case 3:
                        {
                            SinhVien student1 = new SinhVien("Nguyen Van A", "Nam", 19, "SV001", "CNTT", "DHTH01", 9);
                            SinhVien student2 = new SinhVien("Nguyen Van B", "Nam", 18, "SV002", "CNTT", "DHTH01", 8);

                            Course course1 = new Course("C001", "Programming");
                            Course course2 = new Course("C002", "Database");
                            Course course3 = new Course("C003", "Web Development");

                            Registration.RegisterCourse(student1, course1);
                            Registration.RegisterCourse(student1, course2);
                            Registration.RegisterCourse(student2, course2);
                            Registration.RegisterCourse(student2, course3);

                            // In danh sách môn học đã đăng ký cho một sinh viên cụ thể
                            Registration.InDanhSachMHDangKy("SV001");

                            // In danh sách môn học đã đăng ký cho một sinh viên không tồn tại
                            //Registration.InDanhSachMHDangKy("SV002");

                            break;
                        }
                    default:
                        break;
                }
            } while (true);


            Console.ReadLine();
        }

    }
}
