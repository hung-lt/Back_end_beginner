using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3
{
    internal class Sach : TaiLieu
    {
        //khai bao thoc tinh 
        private string? tenTG;
        private int soTrang;

        //Phuong thuc khoi tao mac dinh
        public Sach() { }
        //Phuong thuc khoi tao co tham so
        public Sach(string maTL, string tenNXB, int soBan, string tenTG, int soTrang) : base(maTL, tenNXB, soBan)
        {
            this.tenTG = tenTG;
            this.soTrang = soTrang;
        }

        //Phuong thuc nhap thong tin sach
        public override void Nhap()
        {
            try
            {
                base.Nhap();
                Console.Write("+ Ten tac gia: ");
                tenTG = Console.ReadLine();
                Console.Write("+ So trang: ");
                soTrang = int.Parse(Console.ReadLine() ?? "0");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }      
        }
        //Phuong thuc hien thi thong bao tin sach
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"+ Ten tac gia: {tenTG}:");
            Console.WriteLine($"+ So trang: {soTrang}");
        }
    }
}
