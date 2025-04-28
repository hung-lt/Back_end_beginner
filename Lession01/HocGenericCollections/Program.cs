using HocGenericCollections;
//1.List<T>: tuong tu nhu ArrayList, nhung cac phan tu phai duoc xac dinh kieu du lieu truoc
List<int> list = new List<int>();
list.Add(10);
list.Add(20);
list.Add(12);
//tu C# 3.0 co the viet lai nhu sau:
List<int> list2 = new List<int>()
{
    10,20,12
};


//List<Customer> customers = new List<Customer>();
//Customer cus1 = new Customer();
//cus1.Id = 1;
//cus1.Name = "Mai";

//Customer cus2 = new Customer();
//cus2.Id = 2;
//cus2.Name = "Hien";

//Customer cus3 = new Customer();
//cus3.Id = 3;
//cus3.Name = "Hung";

//customers.Add(cus1);
//customers.Add(cus2);
//customers.Add(cus3);

//tu C# 3.0 cos the viet lai nhu sau
List<Customer> customers = new List<Customer>()
{
    new Customer(){Id = 1, Name = "Mai"},
    new Customer(){Id = 2, Name = "Hienn"},
    new Customer(){Id = 3, Name = "Hung"}
};

//cac phuong thuc thi tuong tu nhu ArrayList

//Dictionary<K,V>: tuong tu nhu Hashtable, nhung cac phan tu phai duoc xac dinh kieu du lieu truoc
Dictionary<int, string> dic = new Dictionary<int, string>();
dic.Add(10, "hi abc");
dic.Add(20, "no thank");
dic.Add(2, "dsd");
//cac phuong thuc thi tuong tu nhu Hasktable

