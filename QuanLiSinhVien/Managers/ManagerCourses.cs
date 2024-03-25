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
        public static List<Course> ListCourse = new List<Course>();    

        public void DocFileDSMonHoc(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList nodeList = read.SelectNodes("/DSMonHoc/MonHoc");
            foreach (XmlNode node in nodeList)
            {
                Course mh = new Course();
                mh.TenMonHoc1 = node["TenMonHoc"].InnerText;
                mh.MaMonHoc1 = node["MaMonHoc"].InnerText;
                ListCourse.Add(mh);
            }
        }

        public void XuatDanhSachMonHoc()
        {
            Console.WriteLine("\n--------------- Danh sach mon hoc ---------------\n");
            Console.WriteLine("Ma mon hoc\tTen mon hoc\n");

            for(int i = 0; i < ListCourse.Count; i++)
            {
                
                    Console.WriteLine("{0}. {1}\t\t{2}", i ,ListCourse[i].MaMonHoc1, ListCourse[i].TenMonHoc1);
            }

            foreach (Course course in ListCourse)
            {
                
            }
        }
    }
}
