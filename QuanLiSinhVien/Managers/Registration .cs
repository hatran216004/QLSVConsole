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
        public Dictionary<SinhVien, List<Course>> registrations = new Dictionary<SinhVien, List<Course>>();

        // Đăng ký môn học cho một sinh viên
        public void RegisterCourse(SinhVien student, Course course)
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


        public void InDanhSachMHDangKy(string studentID)
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
                    Console.WriteLine("Ma mon hoc\tTen mon hoc\t\t\tGia\n");
                    foreach (Course course in courses)
                    {
                        Console.WriteLine("{0}\t\t{1, -20}\t\t{2} VND", course.MaMonHoc1, course.TenMonHoc1, course.Price1);
                    }
                    Console.WriteLine("\nTong: {0} VND", courses.Sum(t => t.Price1));
                    return;
                }
            }

            // Nếu không tìm thấy sinh viên có mã sinh viên trùng khớp
            Console.WriteLine("Khong tim thay sinh vien co ma: {0}", studentID);
        }

        public void CancelRegisterCourse(SinhVien student, Course course)
        {
            // Kiểm tra xem sinh viên có trong danh sách đăng ký không
            if (registrations.ContainsKey(student))
            {
                // Lấy danh sách môn học đã đăng ký của sinh viên
                var courses = registrations[student];

                // Kiểm tra xem môn học cần hủy đăng ký có trong danh sách không
                if (courses.Contains(course))
                {
                    // Hủy đăng ký môn học
                    courses.Remove(course);
                    Console.WriteLine("Da huy dang ky mon hoc {0} cua sinh vien: {1}", course.TenMonHoc1, student.Ten1);
                }
                else
                {
                    Console.WriteLine("Sinh vien {0} chua dang ky mon hoc: {1}", student.Ten1, course.TenMonHoc1);
                }
            }
            else
            {
                Console.WriteLine("Sinh vien {0} chua dang ky bat ky mon hoc nao.", student.Ten1);
            }
        }

    }

}
