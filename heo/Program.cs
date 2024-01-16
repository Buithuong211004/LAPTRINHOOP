using System;
using System.Globalization;
using System.Collections.Generic;
namespace hes
{
    class Program
    {
        static void Main(string[]args)
        {
            phanso a=new phanso();
            a.nhap();
            phanso b=new phanso();
            b.nhap();
            
            phanso c= a.cong(b);
            c.xuat();
            
            

            
            

        }
    }
    class phanso
    {
        public int ts;
        public int ms;
        
        public void nhap()
        {
            ts=Convert.ToInt32(Console.ReadLine());
            ms=Convert.ToInt32(Console.ReadLine());
        }
        public phanso cong(phanso a)
        {
            phanso c=new phanso();
            c.ts=(this.ts*a.ms)+(a.ts+this.ms);
            c.ms=a.ms*this.ms;
            return c;

        }
        public void xuat()
        {

            Console.WriteLine($"KQ PHEP CONG:{ts}/{ms}");
        }
    }
}
