using QuanLiSinhVien.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Managers
{
    class Registration // Đăng ký môn học
    {
        public static Dictionary<SinhVien, List<Course>> registrations = new Dictionary<SinhVien, List<Course>>();

        // Đăng ký môn học cho một sinh viên
        public static void RegisterCourse(SinhVien student, Course course)
        {
            // Kiểm tra xem sinh viên đã có trong danh sách đăng ký chưa
            if (!registrations.ContainsKey(student))
            {
                // Nếu chưa có, thêm mới sinh viên và danh sách môn học vào danh sách
                registrations.Add(student, new List<Course>());
            }

            // Thêm môn học vào danh sách đăng ký của sinh viên
            registrations[student].Add(course);
        }


        public static void InDanhSachMHDangKy(string studentID)
        {
            foreach (var pair in registrations)
            {
                // Lấy key (sinh viên) từ cặp key-value
                var student = pair.Key;

                // Lấy value (danh sách môn học) từ cặp key-value
                var courses = pair.Value;

                // Kiểm tra xem mã sinh viên có trùng khớp không
                if (student.MSSV1 == studentID)
                {
                    Console.WriteLine("----------- Cac mon sinh vien {0} da dang ky -----------", student.Ten1);
                    Console.WriteLine("Ma mon hoc\t\tTen mon hoc");
                    foreach (var course in courses)
                    {
                        Console.WriteLine("{0}\t\t\t{1}", course.MaMonHoc1, course.TenMonHoc1);
                    }
                    return;
                }
            }

            // Nếu không tìm thấy sinh viên có mã sinh viên trùng khớp
            Console.WriteLine("Khong tim thay sinh vien co ma: {0}", studentID);
        }
    }

}
