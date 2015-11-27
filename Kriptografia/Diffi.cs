using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kriptografia
{
    class Diffi
    {
        public long p;
        public long g = 0;
        public long Xa;
        public long Xb;
        public long Ya;
        public long Yb;
        public long Zab;
        public long Zba;

        public Diffi(long p, long Xa, long Xb)
        {
            this.p = p;
            this.Xa = Xa;
            this.Xb = Xb;
        }


        public static bool isSimple(long p)
        {
            bool prost = true;
            for (int i = 2; i <= p / 2; i++)
            {
                if (p % i == 0)
                {
                    prost = false;
                    break;
                }
            }

            return prost;
        }

        public long mul(long a, long k, long n)
        {
            long b = 1;

            while (k > 0)
            {
                if (k % 2 == 0)
                {
                    k /= 2;
                    a = (a * a) % n;
                }
                else
                {
                    k--;
                    b = (b * a) % n;
                }
            }
            return b;
        }

        public string Perform()
        {
            bool f = true;
            Random r = new Random();
            while(f)
            {
                g = r.Next(30000);

                Ya = mul(g, Xa, p);
                Yb = mul(g, Xb, p);

                Zab = mul(Yb, Xa, p);
                Zba = mul(Ya, Xb, p);

                if (Zab == Zba)
                    f = false;
            }

            return "g = " + g + " Ya = " + Ya + "Yb = " + Yb + " Zab = Zba = " + Zab + "\n";
        }


    }
}
