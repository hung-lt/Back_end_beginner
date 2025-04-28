using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab1._5_Bai2
{
    class Program
    {
        static void Main()
        {
            List<Hinh> danhSachHinh = new List<Hinh>();

            // Thêm các hình vào danh sách
            danhSachHinh.Add(new HinhTron(3));
            danhSachHinh.Add(new HinhVuong(4));
            danhSachHinh.Add(new HinhChuNhat(5, 2));
            danhSachHinh.Add(new HinhTamGiac(3, 4, 5));

            double tongChuVi = 0;
            double tongDienTich = 0;

            foreach (var hinh in danhSachHinh)
            {
                tongChuVi += hinh.TinhChuVi();
                tongDienTich += hinh.TinhDienTich();
            }
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Tổng chu vi: {tongChuVi:F2}");
            Console.WriteLine($"Tổng diện tích: {tongDienTich:F2}");
        }
    }
}
