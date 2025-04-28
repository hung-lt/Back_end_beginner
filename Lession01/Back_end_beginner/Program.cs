Console.WriteLine("Hello, World!");
//1. Khai bao bien
int? x; //? cho phép x nhận giá trị null
x = null;
Console.WriteLine("x = " + x);

// 2. Toán tử hợp nhất null
int? a = null;
int b = a ?? 5; // nếu a là null, thì b sẽ nhận giá trị 5

//3. Chuỗi nội suy
string name = "Hung";
int age = 20;
//string message = "Xin chao " + name + ", bạn đã " + age + "tuoi";
string message = $"xin chao {name}, ban da {age} tuoi";
Console.WriteLine(message);
