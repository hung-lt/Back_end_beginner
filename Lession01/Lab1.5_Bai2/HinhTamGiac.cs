using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._5_Bai2
{
    class HinhTamGiac : Hinh
    {
        public double a, b, c;

        public HinhTamGiac(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                throw new ArgumentException("Ba cạnh không tạo thành tam giác!");
            }
        }

        public override double TinhChuVi()
        {
            return a + b + c;
        }

        public override double TinhDienTich()
        {
            double p = TinhChuVi() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Công thức Heron
        }

    }
}
