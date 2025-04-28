Console.OutputEncoding = System.Text.Encoding.UTF8;

//Bai 1: Viet chương trinh nhap vao ten av tuoi, sau do
//in ra màn hình thong bao "Xin chao [ten], ban [tuoi] tuoi!".

string? ten;
int tuoi;
//Nhạp du lieu tu ban phim
Console.Write("Nhap ten: ");
ten = Console.ReadLine();
Console.Write("nhap tuoi: ");
tuoi = int.Parse(Console.ReadLine() ?? "0");
// xuat ra màn hinh
Console.WriteLine($"Xin chao {ten}, ban {tuoi} tuoi!");

//Bai 2: viêt chuong trinh tinh dien tich hình chữ nhật
// khi ng dùng nhập chiều dài và chiều rộng

double chieuDai, chieuRong, dienTich;
try
{
    // nhap dữ liệu từ bàn phím
    Console.Write("Chieu dai: ");
    chieuDai = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Chieu rong: ");
    chieuRong = double.Parse(Console.ReadLine() ?? "0");

    if (chieuDai <= 0 || chieuRong <= 0)
        throw new Exception("do dai phai lon hon 0");

    //tinh dien tich
    dienTich = chieuDai * chieuRong;
    Console.WriteLine($"dien tich hcn : {dienTich}");
}

catch (FormatException ex)
{
    Console.WriteLine("Loi nhap lieu: " + ex.Message);
}

catch (Exception ex)
{
    Console.WriteLine("Loi " + ex.Message);
}

//Bai3. Viết chương trình chuyển đổi nhiệt độ từ đọ C sang độ F
Console.Write("Nhập nhiệt độ (°C): ");
if (double.TryParse(Console.ReadLine(), out double celsius))
{
    double fahrenheit = (celsius * 9 / 5) + 32;
    Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
}
else
{
    Console.WriteLine("Vui lòng nhập một số hợp lệ.");
}

//Bai4. Viết chương trình nhập vào một sô nguyên và kiểm tra xem số đó có phải là số chẵn hay không
Console.Write("Nhap vao mot so nguyen to: ");
if(int.TryParse(Console.ReadLine(), out int n))
{
    if(n % 2 ==0)
    {
        Console.WriteLine($"{n} la mot so chan");
    }
    else
    {
        Console.WriteLine($"{n} khong phai la so chan");
    }

}
else
{
    Console.WriteLine("Vui lòng nhập một số hợp lệ.");
}


//Bai5. Viết chương trình tính tổng và tích của 2 số nhập từ bàn phím
double soMot, soHai, tich, tong;
    // nhap dữ liệu từ bàn phím
    Console.Write("nhap so thu nhat: ");
    soMot = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("nhap so thu hai: ");
    soHai = double.Parse(Console.ReadLine() ?? "0");

    //tinh toan
    tich = soHai * soMot;
    tong = soMot + soHai;
    Console.WriteLine($"tong của hai so da nhap : {tong}");
    Console.WriteLine($"tich của hai so da nhap : {tich}");

//Bai6. Viết chương trình kiểm tra xem một số nhập vào có phải số dương, số âm hay số không
double? number;
Console.Write("Nhap vao mot so bat ky: ");
number = double.Parse(Console.ReadLine() ?? "0");

if(number > 0)
{
    Console.WriteLine($"{number} là so duong");
}
else if(number < 0){
    Console.WriteLine($"{number} la so am");
}
else
{
    Console.WriteLine($"{number} la so khong");
}

//Bai7. Viết chương trình kiểm tra xem một năm nhập vào có phải năm nhuận hay không 
int? nam;
Console.Write("nhap vao mot nam: ");
nam = int.Parse(Console.ReadLine() ?? "0");

if((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
{
    Console.WriteLine($"{nam} la nam nhuan");
}
else
{
    Console.WriteLine($"{nam} khong phai la nam nhuan");
}

//Bai8. viết chương trình in ra bảng cửu chương từ 1 đến 10
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Bảng cửu chương {i}:");
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

//Bai9. Viet chương trình tính giai thừa của một số nguyên dương
int soNguyenDuong;
Console.Write("Nhap vao mot so nguyen duong: ");
soNguyenDuong = int.Parse(Console.ReadLine() ?? "0");
long giaThua = 1;
for (int i = 1; i<= soNguyenDuong; i++)
{
    giaThua *= i;
}
Console.WriteLine($"{soNguyenDuong}! = {giaThua}");

//Bai10. viet chương trình kiểm tra xem một số có phải là số nguyên tố hay không
int num;
Console.Write("Nhap vao mot so bat ky: ");
num = int.Parse(Console.ReadLine() ?? "0");
if(num < 2)
{
    Console.WriteLine($"{num} khong phai so nguyen to");
}
else
{
    bool laSoNguyenTo = true;
    for (int i = 2; i * i <= num; i++)
    {
        if (num % i == 0)
        {
            laSoNguyenTo = false;
            break; // Không cần kiểm tra thêm nữa
        }
    }

    if (laSoNguyenTo)
        Console.WriteLine($"{num} la so nguyen to.");
    else
        Console.WriteLine($"{num} khong phai la so nguyen to.");
}