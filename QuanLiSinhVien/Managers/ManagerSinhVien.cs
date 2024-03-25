using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QuanLiSinhVien.Managers
{
    class ManagerSinhVien
    {
        //  Biến tĩnh list sv lưu các obj SinhVien
        public List<SinhVien> ListSV = new List<SinhVien>();
        public SinhVien CheckSV(string MSSV)
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



        public void AddStudent()
        {

        }

        public void DelStudent()
        {

        }

        public void NhapDSSinhVien()
        {
            SinhVien sv  = new SinhVien();
            sv.NhapTT1SinhVien();
            ListSV.Add(sv);
        }

        public void XuatDSSinhVien()
        {
            Console.WriteLine("\nMSSV\tHo ten\t\tTuoi\tGioi tinh\tMa lop\tMa nghanh\tDTB\tKet qua\n");
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
                SinhVien sv = new SinhVien();
                sv.Ten1 = node["HoTen"].InnerText;
                sv.Tuoi1 = int.Parse(node["Tuoi"].InnerText);
                sv.GioiTinh1 = node["GioiTinh"].InnerText;
                sv.MSSV1 = node["MSSV"].InnerText;
                sv.MaLop1 = node["MaLop"].InnerText;
                sv.MaNghanh1 = node["MaNghanh"].InnerText;
                sv.DTB1 = float.Parse(node["DiemTB"].InnerText);
                ListSV.Add(sv);
            }
        }
    }

}
