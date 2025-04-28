async static Task SomeMethod()
{
    Console.WriteLine("Ham Some bat dau");
    await Task.Delay(2000);
    Console.WriteLine("\n");
    Console.WriteLine("Ham Some ket thuc!");
}

Console.WriteLine("Bat dau");
await SomeMethod();
Console.WriteLine("Ket thuc");



