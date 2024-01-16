using System;
using System.Globalization;
namespace C5B2
{
    class Program
    {
        static void Main(string[]args)
        {
            Students s1=new Students("123","BUI",13,"BIEN");
            s1.Nhap();
            s1.Xuat();
            

            List<Lecture>L=new List<Lecture>
            {
                new Lecture("123","HA",25,"CADY",8,"GS","GV"),
                new Lecture("456","HAo",26,"CADY",1,"GS","GV"),
                new Lecture("12","yA",27,"CADY",9,"GS","GV"),

            };
           
            Lecture.Sapxep(L);


        }
    }
    class People
    {
        public string ID{get;set;}
        public string Hoten{get;set;}
        public int Tuoi{get;set;}
        public string Diachi{get;set;}
        public People(string ID,string Hoten,int Tuoi,string Diachi)
        {
            this.ID=ID;
            this.Hoten=Hoten;
            this.Tuoi=Tuoi;
            this.Diachi=Diachi;
        }
        public virtual void Nhap()
        {
            Console.WriteLine("NHAP");
        }
        public virtual void Xuat()
        {
            Console.WriteLine("XUAT");
        }

    }
    class Students:People
    {
        public string Term;
        public double TP1;
        public double TP2;
        public double TP3;
        public Students(string ID, string Hoten, int Tuoi, string Diachi) : base(ID, Hoten, Tuoi, Diachi)
        {
        }
        public override void Nhap()
        {
            Console.Write("Nhap ten hoc phan:");
            Term=Console.ReadLine();
            Console.Write("Nhap diem TP1: ");
            TP1=double.Parse(Console.ReadLine());
            Console.Write("Nhap diem TP2: ");
            TP2=double.Parse(Console.ReadLine());
            Console.Write("Nhap diem TP3: ");
            TP3=double.Parse(Console.ReadLine());
        }
        public string GPA()
        {
            double DTB=TP1*0.1+TP2*0.3+TP3*0.6;
            if(DTB<4)
            {
                return "F";
            }
            else if(DTB<8)
            {
                return  "B";
            }
            else
            {
                return "A";
            }
        }
        public override void Xuat()
        {
            Console.WriteLine("THONG TIN SINH VIEN:");
            Console.WriteLine(ID+","+Hoten+","+Tuoi+","+Diachi);
            Console.WriteLine(Term+","+TP1+","+TP2+","+TP3);
            Console.WriteLine(TP1*0.1+TP2*0.3+TP3*0.6+","+GPA());

        }
    }
    class Lecture:People
    {
        public int Kinhnghiem;
        public string Hocvi;
        public string Chucvu;
        public Lecture(string ID,string Hoten,int Tuoi,string Diachi,int Kinhnghiem,string Hocvi,string Chucvu):base(ID,Hoten,Tuoi,Diachi)
        {
            this.Kinhnghiem=Kinhnghiem;
            this.Hocvi=Hocvi;
            this.Chucvu=Chucvu;
        }
        public static void Sapxep(List<Lecture>DS)
        {
            var DSsau=DS.OrderByDescending(a=>a.Kinhnghiem);
            foreach(var k in DSsau)
            {
                k.Xuat();
            }
            
        }
        public override void Xuat()
        {
            Console.WriteLine($"ID:{ID};HoTen:{Hoten};Tuoi:{Tuoi};Diachi:{Diachi};Kinhnghiem:{Kinhnghiem};Hocvi:{Hocvi};Chucvu:{Chucvu}");
            
        }
    }

}
