using System;

namespace ConsoleApp5
{
    class PS
    {
        private int ts, ms;
        public PS()
        {
            ts = ms = 0;
        }
        public PS(int x, int y)
        {
            this.ts = ts;
            this.ms = ms;
        }
        public void nhap()
        {
            Console.WriteLine("nhap tu"); ts = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap mau"); ms = int.Parse(Console.ReadLine());
        }
        public void hien()
        {
            if (ms == 1)
            {
                Console.WriteLine("{0}", ts);
            }
            else
            {
                Console.WriteLine("{0}/{1}", ts, ms);
            }
        }
        public int Uscln(int x, int y)
        {
            x = Math.Abs(x); y = Math.Abs(y);
            while (x != y)
            {
                if (x > y) x = x - y;
                if (y > x) y = y - x;
            }
            return x;
        }
        public PS rutgon()
        {
            int uc = Uscln(this.ts, this.ms);
            this.ts = this.ts / uc;
            this.ms = this.ms / uc;
            return this;
        }
        public static PS operator +(PS t1, PS t2)
        {
            PS t = new PS();
            t.ts = t1.ts * t2.ms + t1.ms * t2.ts;
            t.ms = t1.ms * t2.ms;
            return t;
        }
        public static PS operator -(PS t1, PS t2)
        {
            PS t = new PS();
            t.ts = t1.ts * t2.ms - t1.ms * t2.ts;
            t.ms = t1.ms * t2.ms;
            return t;
        }
        public static PS operator /(PS t1, PS t2)
        {
            PS t = new PS();
            t.ts = t1.ts * t2.ms;
            t.ms = t1.ms * t2.ts;
            return t;
        }
        public static PS operator *(PS t1, PS t2)
        {
            PS t = new PS();
            t.ts = t1.ts * t2.ts;
            t.ms = t1.ms * t2.ms;
            return t;
        }
        public static bool operator >(PS t1, PS t2)
        {
            return t1.ts * t2.ms > t2.ts * t1.ms;
        }
        public static bool operator <(PS t1, PS t2)
        {
            return t1.ts * t2.ms < t2.ts * t1.ms;
        }
    }
}
