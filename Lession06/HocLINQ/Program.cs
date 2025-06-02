using HocLINQ;
int[] numbers = { 4, 3, 9, 1, 6, 8 };
//- Query syntax
//var result = from x in numbers
//             where x % 2 == 0
//             select x;

//- Method syntex
//var result = numbers.Where(x => x % 2 == 0).Select(x => x);
//foreach(var item in result)
//{
//    Console.Write(item + " ");
//}

Console.OutputEncoding = System.Text.Encoding.UTF8;

List<Brand> brands = new List<Brand>()
{
    new Brand(){BrandId=1,BrandName="Công ty may 10"},
    new Brand(){BrandId=2,BrandName="Công ty CMC"},
    new Brand(){BrandId=3,BrandName="Nhà sách Trí Tuệ"},
    new Brand(){BrandId=4,BrandName="Công ty Xuân Hòa"}
};
List<Product> products = new List<Product>()
{
    new Product(){ProductId=1,ProductName="Laptop Dell",
        Price=15000000,Colors = new string[]{"Trắng","Đen"},BrandId=2},
    new Product(){ProductId=2,ProductName="Áo đồng phục",
        Price=250000,Colors = new string[]{"Trắng","Xanh"},BrandId=1},
    new Product(){ProductId=3,ProductName="Bàn học",
        Price=800000,Colors = new string[]{"Trắng","Nâu"},BrandId=4},
    new Product(){ProductId=4,ProductName="Đèn bàn",
        Price=400000,Colors = new string[]{"Xanh","Hồng"},BrandId=3},
    new Product(){ProductId=5,ProductName="Máy chiếu",
        Price=12000000,Colors = new string[]{"Trắng","Đen"},BrandId=2},
    new Product(){ProductId=6,ProductName="Cặp học sinh",
        Price=600000,Colors = new string[]{"Trắng","Hồng"},BrandId=3},
};

//Cac toan tu truy van
//1. Phep chieu
//- Query syntex
//var result = from b in brands
//             select b;

//- Methos syntex
//var result = brands.Select(b => b);

//foreach (var item in result)
//{
//    Console.WriteLine($"{item.BrandId}, {item.BrandName}");
//}

//Tra ve doi tuong vo danh
//- Query syntex
//var result = from p in products
//             select new
//             {
//                 MaSP = p.ProductId,
//                 TenSP = p.ProductName
//             };

//-Method syntex
//var result = products.Select(p => new
//{
//    MaSP = p.ProductId,
//    TenSP = p.ProductName
//});

//foreach (var item in result)
//{
//    Console.WriteLine($"{item.MaSP}, {item.TenSP}");
//}

//2. Phep loc
//- Query syntex
//var result = from p in products
//             where p.Price >= 10000000
//             select p;

//- Method syntex
//var result = products.Where(p => p.Price >= 10000000).Select(p => p);

//foreach (var item in result)
//{
//    Console.WriteLine($"{item.ProductName}, {item.Price}");
//}

//3. Sap xep
//- Query syntex
//var result = from b in brands
//             orderby b.BrandName ascending
//             select b;

//- Method syntex
//var result = brands.OrderBy(b => b.BrandName).Select(b => b);

//foreach (var item in result)
//{
//    Console.WriteLine($"{item.BrandId}, {item.BrandName}");
//}

//4. Phep noi
//-Query syntex
//var result = from p in products
//             join b in brands
//             on p.BrandId equals b.BrandId
//             select new
//             {
//                 TenSP = p.ProductName,
//                 TenTH = b.BrandName
//             };

//- Method syntex
//var result = products.Join(brands,
//                              p => p.BrandId,
//                              b => b.BrandId,
//                              (p, b) => new
//                              {
//                                  TenSP = p.ProductName,
//                                  TenTH = b.BrandName
//                              });

//foreach (var item in result)
//{
//    Console.WriteLine($"{item.TenSP},{item.TenTH}");
//}

//5. Gom nhom
//- Query synrex
//var result = from p in products
//             group p by p.BrandId;

//- Method syntex
//var result = products.GroupBy(p => p.BrandId);

//foreach (var brandGroup in result)
//{
//    Console.WriteLine($"- Thuong hieu: {brandGroup.Key}");
//    foreach (var item in brandGroup)
//    {
//        Console.WriteLine($"\t + {item.ProductId}, {item.ProductName}");
//    }
//}

//6. Chuyen kieu
//var List = products.ToList();
//var array = products.ToArray();

//7. Tong hop
//trung binh
//var avePrice = products.Average(p => p.Price);
//Console.WriteLine("Gia trung binh: " + avePrice);
////Dem so san pham co gia lon hon 10000000
//var countProduct = products.Count(p => p.Price > 10000000);
//Console.WriteLine("So san pham co gia > 10000000 la: " + countProduct);

//8. định lượng: All, Any, Contains
//var result = products.All(p => p.Price > 1000000); //false
//var result = products.Any(p => p.Price > 1000000);   //true
//Console.WriteLine($"{result}");

//9. Phan vung: skip, skipWhile, Take, TakeWhile
//List<string> list = new List<string>()
//{
//    "Mot", "Hai", "Ba", "Bon", "Nam", "Sau", "Bay", "Tam", "Chin", "Muoi"
//};
////var result = list.Skip(3);  //Bo qua 3 phan tu dau tien
//var result = list.Take(5);    //Lay 5 phan tu dau tien

//foreach (var item in result)
//{
//    Console.Write($"{item}");
//}

//10. sinh du lieu: Empty, Range, Repeat
//var result = Enumerable.Empty<int>();   //tra ve danh sach rong
//var result = Enumerable.Range(10, 5);   //sinh 5 phan tu tang dan tu 10
//var result = Enumerable.Repeat<int>(3, 10); // lap 10 lan so 3
//foreach (var item in result)
//{
//    Console.Write(item + " ");
//}

//11. Tap hop: Distinct, Except, Intersect, Union
//var list1 = new List<int>
//{
//    1,2,3,4,5,6,7,8
//};
//var list2 = new List<int>
//{
//    3,4,6,5,7
//};

////var result = list1.Distinct(); //tra ve cac phan tu khac nhau trong danh sach
////var result = list1.Except(list2); //tru
////var result = list1.Intersect(list2);  //giao
//var result = list1.Union(list2);    //hop
//foreach (var item in result)
//{
//    Console.Write(item + " ");
//}


//12. Phan tu: First, Last, Single ...
//var result = products.First(p => p.BrandId == 3); //dau tien
//var result = products.Last(p => p.BrandId == 3);  //cuoi cung
//var result = products.FirstOrDefault(p => p.BrandId == 3);
//var result = products.LastOrDefault(p => p.BrandId == 3);
//var result = products.Single(p => p.BrandId == 4);    //duy nhat
var result = products.SingleOrDefault(p => p.BrandId == 4);
Console.WriteLine($"{result.ProductName},{result.BrandId}");
