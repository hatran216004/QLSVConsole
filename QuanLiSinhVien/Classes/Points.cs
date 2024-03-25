using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Managers
{
    class Points : SinhVien
    {
        float DToanCC; // Điểm toán cao cấp 
        float DAnh; // Điểm anh
        float DOOP; // Điểm OOP

        public float DToanCC1 { get => DToanCC; set => DToanCC = value; }
        public float DAnh1 { get => DAnh; set => DAnh = value; }
        public float DOOP1 { get => DOOP; set => DOOP = value; }

        public Points() { }

        public Points(float pDToanCC, float pDAnh, float pDOOP)
        {
            DToanCC = pDToanCC;
            DAnh = pDAnh;
            DOOP = pDOOP;
        }

        public float DiemTrungBinh()
        {
            return (DToanCC + DAnh + DOOP) / 3;
        }

        public void GanDiemTrungBinhChoSinhVien()
        {
            base.DTB1 = DiemTrungBinh();
        }
    }
}
