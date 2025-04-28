using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._5_Bai1
{
    class Program
    {
        static void Main()
        {
            List<PhanSo> danhSach = new List<PhanSo>();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số lượng phân số: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập phân số thứ {i + 1}:");
                PhanSo ps = new PhanSo();
                ps.Nhap();
                danhSach.Add(ps);
            }

            PhanSo tong = new PhanSo(0, 1);
            foreach (PhanSo ps in danhSach)
            {
                tong = PhanSo.Cong(tong, ps);
            }

            Console.Write("Tổng các phân số là: ");
            tong.HienThi();
        }

    }
}
