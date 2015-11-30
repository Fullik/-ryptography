using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kriptografia
{
    class Shamir
    {
        public long p;
        public long Ca;
        public long Cb;
        public long da;
        public long db;
        public long m;
        public int n;

        public Shamir(long m, int n)
        {
            this.m = m;
            this.n = n;
        }

        void extended_euclid(long a, long b, ref long x, ref long y, ref long d)
        {
            long q, r, x1, x2, y1, y2;
            if (b == 0)
            {
                d = a; x = 1; y = 0;
                return;
            }
            x2 = 1; x1 = 0; y2 = 0; y1 = 1;
            while (b > 0)
            {
                q = a / b; r = a - q * b;
                x = x2 - q * x1; y = y2 - q * y1;
                a = b; b = r;
                x2 = x1; x1 = x; y2 = y1; y1 = y;
            }
            d = a; x = x2; y = y2;
        }

        long nod(long a, long b)
        {
            if (b == 0)
                return a;
            else
                return nod(b, (a % b));
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

        public string perform()
        {
            p = 0;
            Random r = new Random();
            do
            {
                p = r.Next(1, n);
                Ca = r.Next(1, n);
                Cb = r.Next(1, n);
            } while (p <= m || !Diffi.isSimple(p) || !Diffi.isSimple(Ca)
                || !Diffi.isSimple(Cb) || nod(p - 1, Ca) != 1 || nod(p - 1, Cb) != 1);

            //p = 61;
            //Ca = 29;
            //Cb = 19;

            long x = 0, y = 0, d = 0;

            extended_euclid(p - 1, Ca, ref x, ref y, ref d);

            da = y;

            x = 0;
            y = 0; 
            d = 0;

            extended_euclid(p - 1, Cb, ref x, ref y, ref d);

            db = y;

            long X1 = mul(m, Ca, p);
            long X2 = mul(X1, Cb, p);

            if (da < 0)
            {
                da += p-1;
            }

            long X3 = mul(X2, da, p);

            if (db < 0)
            {
                db += p-1;
            }

            long X4 = mul(X3, db, p);

            return "p = " + p + " Ca = " + Ca + " Cb = " + Cb + " da = " + da + " db = " + db + " m = " + m + "\n"
                + "X1 = " + X1 + "\n"
                + "X2 = " + X2 + "\n"
                + "X3 = " + X3 + "\n"
                + "X4 = " + X4 + "\n";
        }
    }
}
