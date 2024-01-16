using System;
using System.Globalization;
using System.Collections.Generic;
namespace C6B4
{
    class Program
    {
        static void Main(string[]args)
        {
            List<standard>STA=new List<standard>
            {
                new standard("THUONG","0123",3),
                new standard("SEN","0124",8),
                new standard("DINH","0145",5),

            };
            List<vip>VIP=new List<vip>
            {
                new vip("HONG","123",4,"Luxury"),
                new vip("THAO","124",6,"Luxury"),
                new vip("CUONG","153",7,"President"),
            };
            Console.WriteLine("Thong tin thue phong standard");
            foreach(var k in STA)
            {
                k.tienthuephong();
                k.Xuat();
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Thong tin thue phong vip");
            int lu=0;
            foreach(var m in VIP)
            {
                m.tienthuephong();
                m.Xuat();
                if(m.loaiphong=="Luxury")
                {
                    lu=lu+m.k;
                }
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Tong doanh thu:{0}",Phong.DT);
            Console.WriteLine("Tong tien cho thue phong Standard:{0}",standard.dt);
            Console.WriteLine("Tong tien cho thue phong Vip:{0}",vip.dt);
            Console.WriteLine("Tong tien cho thue phong Vip_Luxury:{0}",lu);


        }
    }
    class Phong
    {
        public string tenkhachhang;
        public string cmnd;
        public int songaythue;
        public Phong(string tenkhachhang,string cmnd,int songaythue)
        {
            this.tenkhachhang=tenkhachhang;
            this.cmnd=cmnd;
            this.songaythue=songaythue;
        }
        public void Xuat()
        {
            Console.WriteLine($"TENKH:{tenkhachhang}___SO CMND:{cmnd}___SO NGAY THUE:{songaythue}");
        }
        public static int DT=0;
        public virtual void tienthuephong()
        {
            
        }

        
    }
    class standard:Phong
    {
       public int k;
       public static int dt=0;
        public standard(string tenkhachhang,string cmnd,int songaythue):base(tenkhachhang,cmnd,songaythue)
        {

        }
        public override void tienthuephong()
        {
            if(songaythue<=5)
            {
                k=songaythue*500;
                
                
            }
            else
            {
                k=songaythue*400;
               
            }
            DT=DT+k;
            dt=dt+k;
           
           
        }
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"TIEN THUE PHONG STANDARD LA:{k}");
        }

    }
    class vip:Phong
    {
        public int k;
        public static int dt=0;
        public string loaiphong;
        public vip(string tenkhachhang,string cmnd,int songaythue,string loaiphong):base(tenkhachhang,cmnd,songaythue)
        {
            this.loaiphong=loaiphong;

        }
        public override void tienthuephong()
        {
            if(songaythue<=5)
            {
                if(loaiphong=="Luxury")
                {
                    k=songaythue*1100;
                   
                }
                else if(loaiphong=="President")
                {
                    k=songaythue*1300;
                    
                }
            }
            else
            {
                k=songaythue*1000;
               

            }
            DT=DT+k;
            dt=dt+k;
           
        }
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine("LOAI PHONG:"+loaiphong);
            Console.WriteLine($"TIEN THUE PHONG VIP LA:{k}");
        }
    }
}
