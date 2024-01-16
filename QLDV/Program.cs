using System;
using System.Globalization;
namespace QLDV
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("| Bam 0: Dung                                              |");
            Console.WriteLine("| Bam 1: In ra thong tin va chi phi dich vu cua xe may     |");
            Console.WriteLine("| Bam 2: In ra thong tin va chi phi dich vu cua xe oto     |");
            Console.WriteLine("| Bam 3: In ra thong tin va chi phi dich vu cua giao hang  |");
            Console.WriteLine("------------------------------------------------------------");
            while(true)
            {
                Console.Write("Xin chon loai dich vu: ");
                int k=Convert.ToInt32(Console.ReadLine());
                if(k==1)
                {
                    xemay xm=new xemay();
                    xm.nhap();
                    xm.phidichvu();
                    
                    Console.WriteLine("Quy khach da lua chon dich vu xe may, thong tin chi tiet nhu sau:");
                    Console.WriteLine($"Ten:{xm.tenkhach}");
                    Console.WriteLine($"Diem nhan:{xm.diemnhan}");
                    Console.WriteLine($"Diem den:{xm.diemden}");
                    Console.WriteLine($"Khoang cach:{xm.khoangcach}");
                    Console.WriteLine($"Don gia:{xm.dongia}");
                    Console.WriteLine($"Giam gia:{xm.giamgia}");
                    Console.WriteLine($"Chi phi dich vu:{xm.pdv}");
                }
                else if(k==2)
                {
                    oto o=new oto();
                    o.nhap();
                    o.phidichvu();

                    Console.WriteLine("Quy khach da lua chon dich vu xe oto, thong tin chi tiet nhu sau:");
                    Console.WriteLine($"Ten:{o.tenkhach}");
                    Console.WriteLine($"Diem nhan:{o.diemnhan}");
                    Console.WriteLine($"Diem den:{o.diemden}");
                    Console.WriteLine($"Khoang cach:{o.khoangcach}");
                    Console.WriteLine($"Don gia:{o.dongia}");
                    Console.WriteLine($"Giam gia:{o.giamgia}");
                    Console.WriteLine($"Loai xe:{o.loaixe}");
                    Console.WriteLine($"He so loai xe:{o.hesoloaixe}");
                    Console.WriteLine($"Chi phi dich vu:{o.pdv}");

                }
                else if(k==3)
                {
                    giaohang gh=new giaohang();
                    gh.nhap();
                    gh.phidichvu();

                    Console.WriteLine("Quy khach da lua chon dich vu giao hang, thong tin chi tiet nhu sau:");
                    Console.WriteLine($"Ten:{gh.tenkhach}");
                    Console.WriteLine($"Diem nhan:{gh.diemnhan}");
                    Console.WriteLine($"Diem den:{gh.diemden}");
                    Console.WriteLine($"Khoang cach:{gh.khoangcach}");
                    Console.WriteLine($"Don gia:{gh.dongia}");
                    Console.WriteLine($"Giam gia:{gh.giamgia}");
                    Console.WriteLine($"Gia san pham:{gh.giasp}");
                    Console.WriteLine($"Chi phi dich vu:{gh.pdv}");

                }
                else if(k==0)
                {
                    Console.WriteLine("KET THUC DICH VU");
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
            Console.Write("nhap ten khach:");
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


    }
    class oto:DICHVU
    {
        public int loaixe;
        public int hesoloaixe;
        public double pdv;
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap loai xe:");
            loaixe=Convert.ToInt32(Console.ReadLine());
        }
        public override void phidichvu()
        {
            if(loaixe==4)
            {
                hesoloaixe=1;
            }
            if(loaixe==7)
            {
                hesoloaixe=2;
            }
            pdv=(dongia*khoangcach)*hesoloaixe-giamgia;
        }

    }
    class giaohang:DICHVU
    {
        public double giasp;
        public double pdv;
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap gia san pham:");
            giasp=double.Parse(Console.ReadLine());
        }
        public override void phidichvu()
        {
            pdv=(dongia*khoangcach)+giasp-giamgia;
        }
    }

}
