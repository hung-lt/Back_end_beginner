using HocCollections;
using System.Collections;
//1. ArrayList
//- là 1 mảng động
//- cho phép chứa các phần tử null và trùng nhau
//- truy xuất phần tử qua chỉ số

ArrayList list = new ArrayList();
//them phan tu vao ArrayList
list.Add("Mai");
list.Add(7.2);
list.Add(8);
list.Add('B');

SinhVien sv = new SinhVien();
sv.MaSV = "170110";
sv.HoTen = "Le Van An";
list.Add(sv);

//chen phan tu
list.Insert(1, "Dung");
//Xoa phan tu
list.Remove("Dung");    //Xoa theo gia tri
list.RemoveAt(1);       //Xoa theo chi so

//duyet cac phan tu trong ArrayList
foreach (object item in list)
{
    if (item is SinhVien)
    {
        SinhVien sinhvien = (SinhVien)item;
        Console.WriteLine(sinhvien.MaSV + ", " + sinhvien.HoTen);
    }
    else
    {
        Console.WriteLine(item);
    }
}

//2. Hashtable
//- moi phan tu la 1 cap <key,value>
//- key phai la duy nhat va khac null
//- truy xuat phan tu thong qua key

Hashtable hashtable = new Hashtable();
//Them phan tu vao Hashtable
hashtable.Add("mai", 10);
hashtable.Add(20, 50);
hashtable.Add("Kien", "Hung");
//hashtable.Add("Kien", 100);     //key khong duoc trung

//truy xuat phan tu trong Hashtable
Console.WriteLine(hashtable["mai"]);    //10
//duyet cac phan tu
ICollection keys = hashtable.Keys;
foreach (object key in keys)
{
    Console.WriteLine($"{key} - {hashtable[key]}");
}
