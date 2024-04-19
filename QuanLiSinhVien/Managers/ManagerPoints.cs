using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Managers
{
    class ManagerPoints
    {
        public static List<Points> listPoints = new List<Points>();
        public void ShowPointsStudents()
        {
            string mssv;
            bool checkSV = false;

            do
            {
                Console.Write("Nhap ma so sinh vien: ");
                mssv = Console.ReadLine();
                Console.WriteLine("\n-------------- Thong tin diem tung mon --------------\n");
                foreach (SinhVien sv in ManagerSinhVien.ListSV)
                {
                    if (mssv == sv.MSSV1)
                    {
                        foreach (Points p in listPoints)
                        {

                            if (mssv == p.MSSV2)
                            {
                                checkSV = true;
                                Console.WriteLine("\nMSSV\tHo ten\t\tTuoi\tGioi tinh\tMa lop\tMa nghanh\tToan\tAnh\tVan\n");
                                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t\t{4}\t{5}\t\t{6}\t{7}\t{8}", sv.MSSV1, sv.Ten1, sv.Tuoi1, sv.GioiTinh1, sv.MaLop1, sv.MaNghanh1, p.DToanCC1, p.DAnh1, p.DVan1);
                            }
                        }
                    }
                }

                if (!checkSV)
                {
                    Console.WriteLine("Sinh vien khong ton tai!");
                }

            } while (!checkSV);
        }
    }
}
