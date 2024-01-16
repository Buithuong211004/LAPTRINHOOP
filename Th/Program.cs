using System;
using System.Globalization;
using System.Collections.Generic;
namespace thg
{
    class Program
    {
        static void Main(string[]args)
        {
            students s=new students("123","A",16,"yty");
            s.nhap();
            s.GPA();
            s.xuat();

            List<lecture>M=new List<lecture>
            {
                new lecture("123","A",19,"yt",9,"GS","GV"),
                new lecture("197","B",10,"yt",3,"GS","GV"),
                new lecture("123","A",19,"yt",19,"GS","GV"),

            };
            lecture.Sapxep(M);

        }
    }
    abstract class People
    {
        public string id,hoten,diachi;
        public int tuoi;
        public People(string id,string hoten,int tuoi, string diachi)
        {
            this.id=id;
            this.hoten=hoten;
            this.tuoi=tuoi;
            this.diachi=diachi;
        }
        public abstract void nhap();
        public virtual void xuat()
        {
            Console.Write($"ID:{id},HOTEN:{hoten},TUOI:{tuoi},DIACHI:{diachi}");
        }
    }
    class students:People
    {
        public string term;
        public double tp1,tp2,tp3;
        public students(string id,string hoten,int tuoi,string diachi):base(id,hoten,tuoi,diachi)
        {

        }
        public override void nhap()
        {
            Console.Write("nhap ten hoc phan:");
            term=Console.ReadLine();
            Console.Write("nhap tp1:");
            tp1=double.Parse(Console.ReadLine());
            Console.Write("nhap tp2:");
            tp2=double.Parse(Console.ReadLine());
            Console.Write("nhap tp3:");
            tp3=double.Parse(Console.ReadLine());

        }
        public string GPA()
        {
            double gpa=0.1*tp1+0.3*tp2+0.6*tp3;
            if(gpa<5)
            {
                return "D";
            }
            else if(gpa<8)
            {
                return "B";

            }
            else{
                return "A";
            }
        }
        public override void xuat()
        {
            base.xuat();
            Console.Write($"TEN HP:{term}, DIEM TP1:{tp1}, DIEM TP2:{tp2}, DIEM TP3:{tp3}");
            Console.WriteLine($", DTB:{0.1*tp1+0.3*tp2+0.6*tp3}, XEP LOAI:{GPA()}");
        }
    }
    class lecture:People
    {
        public int kinhnghiem;
        public string hocvi,chucvu;
        public lecture(string id,string hoten,int tuoi,string diachi,int kinhnghiem,string hocvi,string chucvu):base(id,hoten,tuoi,diachi)
        {
            this.kinhnghiem=kinhnghiem;
            this.hocvi=hocvi;
            this.chucvu=chucvu;
        }
        public override void nhap()
        {
            throw new System.NotImplementedException();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($", KINH NGHIEM:{kinhnghiem}, HOCVI:{hocvi}, CHUCVU:{chucvu}");
        }
        public static void Sapxep(List<lecture>DS)
        {
            var ds=DS.OrderByDescending(a=>a.kinhnghiem);
            foreach(var m in ds)
            {
                m.xuat();
            }
        }
    }
}