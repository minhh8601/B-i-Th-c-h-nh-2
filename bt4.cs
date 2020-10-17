using System;

namespace bt4
{
    class DaThuc
    {
        private int n;
        private double x;
        private double[] a;
        public DaThuc()
        {
            n = 0;
            a = null;
        }
        public  DaThuc(int Bac)
        {
            n = Bac;
            a = new double[n];
        }
        public void Nhap()
        {
            Console.Write("Nhap he so:");
            n = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap x=");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap cac he so");
            for(int i = 0; i <= n; ++i)
            {
                Console.Write("a[{0}]=", i);
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        public void Hien()
        {
            Console.WriteLine("Thong tin da thuc");
            for (int i = 0; i < n; ++i)
                Console.Write("a{0}", i);
        }
        public DaThuc Tong(DaThuc t2)
        {
            if (this.n == t2.n)
            {
                DaThuc t = new DaThuc(this.n);
                for (int i = 0; i < n; ++i)
                    t.a[i] = this.a[i] + t2.a[i];
                return t;
            }
            else 
                return null;
        }
        public DaThuc Hieu(DaThuc t2)
        {
            if (this.n == t2.n)
            {
                DaThuc t = new DaThuc(this.n);
                for (int i = 0; i < n; ++i)
                    t.a[i] = this.a[i] - t2.a[i];
                return t;
            }
            else
                return null;
        }
    }
}
