using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._5_Bai1
{
    class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo() { }

        public PhanSo(int tu, int mau)
        {
            TuSo = tu;
            MauSo = mau == 0 ? 1 : mau; // tránh mẫu số bằng 0
        }

        public void Nhap()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());
            if (MauSo == 0)
            {
                Console.WriteLine("Mẫu số không được bằng 0. Đặt mẫu số = 1.");
                MauSo = 1;
            }
        }

        public static PhanSo Cong(PhanSo a, PhanSo b)
        {
            int tuMoi = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            int mauMoi = a.MauSo * b.MauSo;
            return RutGon(new PhanSo(tuMoi, mauMoi));
        }

        public static PhanSo RutGon(PhanSo ps)
        {
            int ucln = UCLN(Math.Abs(ps.TuSo), Math.Abs(ps.MauSo));
            return new PhanSo(ps.TuSo / ucln, ps.MauSo / ucln);
        }

        private static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public void HienThi()
        {
            Console.WriteLine($"{TuSo}/{MauSo}");
        }
    }
}
