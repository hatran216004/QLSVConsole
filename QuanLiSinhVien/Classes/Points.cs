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
        float DVan; // Điểm OOP

        public float DToanCC1 { get => DToanCC; set => DToanCC = value; }
        public float DAnh1 { get => DAnh; set => DAnh = value; }
        public float DVan1 { get => DVan; set => DVan = value; }

        public Points() { }

        public Points(float pDToanCC, float pDAnh, float pDOOP)
        {
            DToanCC = pDToanCC;
            DAnh = pDAnh;
            DVan = pDOOP;
        }

        public float DiemTrungBinh()
        {
            return (DToanCC + DAnh + DVan) / 3;
        }
    }
}
