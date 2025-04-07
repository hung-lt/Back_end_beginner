using System;

namespace Lab1._2 {

//Bai1: Viet mot hàm để tính tổng của tất cả các so chan trong mọt mảng
    class Program1
    {
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int value;
                while (true)
                {
                    Console.Write($"a[{i}]: ");
                    string? input = Console.ReadLine();

                    if (int.TryParse(input, out value))
                    {
                        a[i] = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập số nguyên.");
                    }
                }
            }
        }

        public static int TinhTong(int[] a, int n)
        {
             int tong= 0;
             for(int i = 0; i < n; i++)
             {
                tong += a[i];
             }
             return tong;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Khai báo biến n
            int n;
            while (true)
            {
                Console.Write("Nhập n: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out n) && n > 0)
                    break;
                else
                    Console.WriteLine("Vui lòng nhập một số nguyên dương.");
            }
            //Khai báo và khởi tạo mảng số nguyên có n phần tử
            int[] a = new int[n];
            //Gọi hàm nhập mảng
            NhapMang(a, n);
            //Gọi hàm Tính Tổng các phần tử trong mảng và hiển thị kết quả ra màn hình
            Console.WriteLine($"Tổng = {TinhTong(a, n)}");

        }
    }


 //Bai 2: Viết chuong trinh nhap  vào mang  gồm n phân tử  nhâp từ bàn phím. Viết hàm để kiểm tra xem mot so có phải so nguyen to khong
 // hiển thị  chỉ số và giá trị  của những  phần tử là số nguyên tố trong mảng
    class Program2
    {
         public static void NhapMang(int[] a, int n)
         {
              for (int i = 0; i < n; i++)
              {
                  int value;
                  while (true)
                  {
                      Console.Write($"a[{i}]: ");
                      string? input = Console.ReadLine();

                      if (int.TryParse(input, out value))
                      {
                          a[i] = value;
                          break;
                      }
                      else
                      {
                          Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập số nguyên.");
                      }
                  }
              }
         }
         public static bool CheckPrime(int n)
         {
              if (n < 2) return false;

              for (int i = 2; i <= Math.Sqrt(n); i++)
              {
                  if (n % i == 0)
                      return false;
              }
              return true;
         }
         static void Main(string[] args)
         {
              Console.OutputEncoding = System.Text.Encoding.UTF8;
              int n;
              while (true)
              {
                  Console.Write("Nhập n: ");
                  string? input = Console.ReadLine();

                  if (int.TryParse(input, out n) && n > 0)
                      break;
                  else
                      Console.WriteLine("Vui lòng nhập một số nguyên dương.");
              }
              //Khai báo và khởi tạo mảng số nguyên có n phần tử
              int[] a = new int[n];
              NhapMang(a, n);
              Console.WriteLine("Các phần tử là số nguyên tố:");
              for (int i = 0; i < a.Length; i++)
              {
                  if (CheckPrime(a[i]))
                  {
                     Console.WriteLine($"Index: {i}, Value: {a[i]}");
                  }
              }
         }
    }
   
//Bai 3: Viet một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử là so nguyen trong mảng
    class Program3
    {
        public static void NhapMang(int[] a, int n)
        {
             for (int i = 0; i < n; i++)
             {
                  int value;
                  while (true)
                  {
                       Console.Write($"a[{i}]: ");
                       string? input = Console.ReadLine();

                       if (int.TryParse(input, out value))
                       {
                           a[i] = value;
                           break;
                       }
                       else
                       {
                           Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập số nguyên.");
                       }
                  }
             }
        }
        public static int DemSoAm(int[] a, int n) 
        {
             int soSoAm = 0;
             for (int i = 0; i < n; i++)
             {
                 if (a[i] < 0)
                 {
                      soSoAm++;
                 }
             }
             return soSoAm;
        
        }
        public static int DemSoDuong(int[] a, int n)
        {
             int soSoDuong = 0;
              for (int i = 0; i < n; i++)
              {
                  if (a[i] > 0)
                  {
                      soSoDuong++;
                  }
              }
              return soSoDuong;
        }
        static void Main(string[] args)
        {
              Console.OutputEncoding = System.Text.Encoding.UTF8;

              int n;
              while (true)
              {
                  Console.Write("Nhập n: ");
                  string? input = Console.ReadLine();

                  if (int.TryParse(input, out n))
                      break;
                  else
                      Console.WriteLine("Vui lòng nhập một số nguyên.");
              }
              //Khai báo và khởi tạo mảng số nguyên có n phần tử
              int[] a = new int[n];
              NhapMang(a, n);
              Console.WriteLine($"Số lượng số âm là : {DemSoAm(a, n)}");
              Console.WriteLine($"Số lượng số dương là: {DemSoDuong(a,n)}");
        }
    }

//Bai 4: Viết hàm để tìm số lớn thứ 2 trong một mảng các số nguyên
    class Program4
    {
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int value;
                while (true)
                {
                    Console.Write($"a[{i}]: ");
                    string? input = Console.ReadLine();

                    if (int.TryParse(input, out value))
                    {
                        a[i] = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập số nguyên.");
                    }
                }
            }
        }
        public static int TimSoLonThuHai(int[] a, int n)
        {
            if (n < 2)
            {
                throw new ArgumentException("Mảng phải có ít nhất 2 phần tử.");
            }

            int max1 = int.MinValue;
            int max2 = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                if (a[i] > max1)
                {
                    max2 = max1;
                    max1 = a[i];
                }
                else if (a[i] > max2 && a[i] < max1)
                {
                    max2 = a[i];
                }
            }

            if (max2 == int.MinValue)
            {
                throw new InvalidOperationException("Không tồn tại số lớn thứ hai (do tất cả phần tử giống nhau).");
            }

            return max2;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int n;
            while (true)
            {
                Console.Write("Nhập n: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out n))
                    break;
                else
                    Console.WriteLine("Vui lòng nhập một số nguyên.");
            }
            //Khai báo và khởi tạo mảng số nguyên có n phần tử
            int[] a = new int[n];
            NhapMang(a, n);
            try
            {
                int soLonThuHai = TimSoLonThuHai(a, n);
                Console.WriteLine($"Số lớn thứ 2 trong mảng là: {soLonThuHai}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }

        }
    }

//Bai 5: Viết hàm hoán vị 2 số nguyên a và b nhập từ bàn phím
    class Program5
    {
        public static void HoanVi(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhập số nguyên a: ");
            int a = int.Parse(Console.ReadLine()!);

            Console.Write("Nhập số nguyên b: ");
            int b = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Trước khi hoán vị: a = {a}, b = {b}");

            HoanVi(ref a, ref b);

            Console.WriteLine($"Sau khi hoán vị: a = {a}, b = {b}");

        }
    }

 //Bai 6: Viết hàm sắp xếp mảng số thực n phần tử nhập từ bàn phím theo chiều tăng dần
    class Program6
    {
        public static void NhapMang(double[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int value;
                while (true)
                {
                    Console.Write($"a[{i}]: ");
                    string? input = Console.ReadLine();

                    if (int.TryParse(input, out value))
                    {
                        a[i] = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập số nguyên.");
                    }
                }
            }
        }
        public static void SapXepTangDan(double[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        double temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        public static void XuatMang(double[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int n;
            while (true)
            {
                Console.Write("Nhập số lượng phần tử n: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out n) && n > 0)
                    break;
                else
                    Console.WriteLine("Vui lòng nhập số nguyên dương.");
            }

            double[] a = new double[n];
            NhapMang(a, n);

            Console.WriteLine("Mảng trước khi sắp xếp:");
            XuatMang(a, n);

            SapXepTangDan(a, n);

            Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
            XuatMang(a, n);
        }


    }

}