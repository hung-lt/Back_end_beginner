//Bai 1: Viet chương trinh nhap vao ten av tuoi, sau do
//in ra màn hình thong bao "Xin chao [ten], ban [tuoi] tuoi!".
Console.OutputEncoding = System.Text.Encoding.UTF8;

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