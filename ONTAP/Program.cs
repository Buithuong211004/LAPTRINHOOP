using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
namespace B1
{
    class Program
    {
        static void Main(string[]args)
        {
            Basic b1=new Basic{ID="123",Area=10,Floor=2};
            Console.WriteLine(b1.ID+"   "+b1.Area+"   "+b1.Floor+"   "+b1.gia());
            Basic b2=new Basic{ID="345",Area=15,Floor=4};
            Console.WriteLine(b2.ID+"   "+b2.Area+"   "+b2.Floor+"   "+b2.gia());
            Condo c1=new Condo{ID="456",Area=8,Floor=1,View="Bien"};
            Console.WriteLine(c1.ID+"   "+c1.Area+"   "+c1.Floor+"   "+c1.View+"   "+c1.gia());
            Condo c2=new Condo{ID="678",Area=13,Floor=2,View="Thanh pho"};
            Console.WriteLine(c2.ID+"   "+c2.Area+"   "+c2.Floor+"   "+c2.View+"   "+c2.gia());
            Condo c3=new Condo{ID="876",Area=8,Floor=1,View="Dao"};
            Console.WriteLine(c3.ID+"   "+c3.Area+"   "+c3.Floor+"   "+c3.View+"   "+c3.gia());

            string id=b1.ID; double gia=b1.gia();
            if (gia<b2.gia())
            {
                id=b2.ID;gia=b2.gia();
            }
             if (gia<c1.gia())
            {
                id=c1.ID;gia=c1.gia();
            }
             if (gia<c2.gia())
            {
                id=c2.ID;gia=c2.gia();
            }
             if (gia<c3.gia())
            {
                id=c3.ID;gia=c3.gia();
            }
            Console.WriteLine("CAN HO CO MUC GIA CAO NHAT CO ID, GIA LAN LUOT LA:{0}  {1}",id,gia);
            
        }
    }
    class CANHO
    {
        public string ID{get;set;}
        public double Area{get;set;}
        public int Floor{get;set;}
        
        public virtual double gia()
        {
            return 0;
        }
    }
    class Basic:CANHO
    {
        public override double gia() 
        {
            return 1000*Area;
        }
    }
    class Condo:CANHO
    {
        public string View{get;set;}
        public override double gia()
        {
            if(View=="Bien")
            {
                return 2000*Area*1.4;
            }
            else if(View=="Ho boi")
            {
                return 2000*Area*1.1;
            }
            else if(View=="Thanh pho")
            {
                return 2000*Area*1.2;
            }
            else
            {
                return 2000*Area;
            }
        }
    }
}