//static int TinhTong(int a, int b)
//{
//    return a + b;
//}
static int TinhHieu(int a, int b)
{
    return a - b;
}
//static void LoiChao(string name)
//{
//    Console.WriteLine("Xin chao " + name);
//}
//2. Khoi tao
//TinhToan tt = TinhTong;
//Func<int, int, int> tt = TinhTong;
//co cach nao de viet ham TinhTong ngay tai day?

//--> su dung Anonymous method(phuong thuc nặc danh)
//Func<int, int, int> tt = delegate(int a, int b)
//{
//    return a + b;
//};

//Bieu thuc lambda: la cach viet rut gon cua phuong thuc nac danh
//Func<int, int, int> tt = delegate (int a, int b) {return a + b;};
//Func<int, int, int> tt = (int a, int b) => { return a + b; };
//Func<int, int, int> tt = (int a, int b) => a + b;
Func<int, int, int> tt = (a, b) => a + b;



//HienThi ht = LoiChao;
//Action<string> ht = LoiChao;
Action<string> ht = s => { Console.WriteLine("xin chao: " + s); };

//3. thuc thi
int kq = tt(3, 4);
Console.WriteLine("Ket qua: " + kq);

ht("mai");

//1. Khai bao delegate
//public delegate int TinhToan(int x, int y);
//public delegate void HienThi(string s);

