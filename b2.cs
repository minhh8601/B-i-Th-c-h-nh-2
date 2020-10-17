using System;

namespace TH2B2
{
    class PS
    {
        private int ts, ms;
        public PS()
        {
            ts = 0;
            ms = 1;
        }
        public PS(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }
        public void Nhap()
        {
            Console.Write("Nhap tu so:");
            ts = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so:");
            ms = int.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            if (ms == 1)
                Console.WriteLine("{0}", ts);
            else
                Console.WriteLine("{0}/{1}", ts, ms);
        }
        public int  USCLN(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);
            while (x != y)
            {
                if (x > y) x = x - y;
                if (x < y) y = y - x;
            }
            return x;
        }
        public PS Rutgon()
        {
            int uc = USCLN(this.ts, this.ms);
            this.ts = this.ts / uc;
            this.ms = this.ms / uc;
            return this;
        }
        public PS Tong(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms + this.ms * t2.ms;
            t.ms = this.ms * t2.ms;
            return t.Rutgon();
        }
        public PS Hieu(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms - this.ms * t2.ms;
            t.ms = this.ms * t2.ms;
            return t.Rutgon();
        }
        public PS Tich(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ts;
            t.ms = this.ms * t2.ms;
            return t.Rutgon();
        }
        public PS Thuong(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms;
            t.ms = this.ms * t2.ts;
            return t.Rutgon();
        }
        
    }
}
