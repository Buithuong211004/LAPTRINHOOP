using System;
using System.Globalization;
using System.Collections.Generic;
namespace on
{
    class Program
    {
        static void Main(string[]args)
        {
            while (true)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("BAM 0: DUNG");
                Console.WriteLine("BAM 1: XE MAY");
                Console.WriteLine("BAM 2: XE OTO");
                Console.WriteLine("BAM 3: DICH VU GIAO HANG");
                Console.WriteLine("---------------------------");
                Console.Write("NHAP DICH VU MA BAN MUON:");
                int num=Convert.ToInt32(Console.ReadLine());
                if(num==1)
                {
                    xemay x=new xemay();
                    x.nhap();
                    x.phidichvu();
                    x.xuat();
                }
                else if(num==2)
                {
                    oto o=new oto();
                    o.nhap();
                    o.phidichvu();
                    o.xuat();
                }
                else if(num==3)
                {
                    giaohang g=new giaohang();
                    g.nhap();
                    g.phidichvu();
                    g.xuat();
                }
                else if(num==0)
                {
                    break;
                }
                

            }

        }
    }
    abstract class DICHVU
    {
        public string tenkhach,diemnhan,diemden;
        public double khoangcach,dongia,giamgia;
        public virtual void nhap()
        {
            Console.Write("nhap ten khach hang:");
            tenkhach=Console.ReadLine();
            Console.Write("nhap diem nhan:");
            diemnhan=Console.ReadLine();
            Console.Write("nhap diem den:");
            diemden=Console.ReadLine();
            Console.Write("nhap khoang cach:");
            khoangcach=double.Parse(Console.ReadLine());
            Console.Write("nhap don gia:");
            dongia=double.Parse(Console.ReadLine());
            Console.Write("nhap giam gia:");
            giamgia=double.Parse(Console.ReadLine());


        }
        public abstract void phidichvu();
        public virtual void xuat()
        {
            Console.WriteLine("TEN:{0}",tenkhach);
            Console.WriteLine("DIEM NHAN:{0}",diemnhan);
            Console.WriteLine("DIEM DEN:{0}",diemden);
            Console.WriteLine("KHOANG CACH:{0}",khoangcach);
            Console.WriteLine("DON GIA:{0}",dongia);
            Console.WriteLine("GIAM GIA:{0}",giamgia);

        }

    }
    class xemay:DICHVU
    {
        public double pdv;
        public override void nhap()
        {
            base.nhap();

        }
        public override void phidichvu()
        {
            pdv=dongia*khoangcach-giamgia;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("PHI:{0}",pdv);

        }
    }
    class oto:DICHVU
    {
        public double pdv;
        public int loaixe,hesoloaixe;
        public override void nhap()
        {
            base.nhap();
            Console.Write("nhap loai xe:");
            loaixe=Convert.ToInt32(Console.ReadLine());
        }
        public override void phidichvu()
        {
            if(loaixe==4)
            {
                hesoloaixe=1;
            }
            else if(loaixe==7)
            {
                hesoloaixe=2;
            }
            pdv=(dongia*khoangcach)*hesoloaixe-giamgia;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("LOAI XE:{0}",loaixe);
            Console.WriteLine("HE SO:{0}",hesoloaixe);
            Console.WriteLine("PHI:{0}",pdv);
        }


    }
    class giaohang:DICHVU
    {
        public double giasp,pdv;
        public override void nhap()
        {
            base.nhap();
            Console.Write("nhap gia san pham:");
            giasp=double.Parse(Console.ReadLine());

        }
        public override void phidichvu()
        {
            pdv=(dongia*khoangcach)+giasp-giamgia;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("GIA SAN PHAM:{0}",giasp);
            Console.WriteLine("PHI:{0}",pdv);
        }
    }
}
