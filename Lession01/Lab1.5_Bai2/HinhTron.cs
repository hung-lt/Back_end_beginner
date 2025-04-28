using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._5_Bai2
{
    class HinhTron : Hinh
    {
        public double BanKinh { get; set; }

        public HinhTron(double r)
        {
            BanKinh = r;
        }

        public override double TinhChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }

        public override double TinhDienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }

    }
}
