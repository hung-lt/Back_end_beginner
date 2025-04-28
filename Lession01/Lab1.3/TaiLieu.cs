using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3
{
    class TaiLieu
    {
        //Khai bao cac thuoc tinh
        protected string? maTL;
        protected string? tenNXB;
        protected int soBan;
        //Phuong thuc khoi tao mac dinh
        public TaiLieu() {  }
        //phuong thuc khoi tao co tham so
        public TaiLieu(string maTl, string tenNXB, int soBan)
        {
            this.maTL = maTl;
            this.tenNXB = tenNXB;
            this.soBan = soBan;
        }

        // nhap thong tin
        public virtual void Nhap()
        {
            try
            {
                Console.Write("+ ma tai lieu: ");
                maTL = Console.ReadLine();
                Console.Write("+ ten nha xuat ban: ");
                tenNXB = Console.ReadLine();
                Console.Write("+ so ban phat hanh: ");
                soBan = int.Parse(Console.ReadLine() ?? "0");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //hien thi thong tin tai lieu
        public virtual void Xuat()
        {
            Console.WriteLine($"+ ma tai lieu: {maTL}");
            Console.WriteLine($"+ ten nha xuat ban: {tenNXB}");
            Console.WriteLine($"+ so ban phat hanh: {soBan}");
        }
    }
}
