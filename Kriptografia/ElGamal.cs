using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kriptografia
{
    class ElGamal
    {
        long p;
        long m;
        long g;
        long cb;
        long k;
        long r;
        long e;
        long m1;
        long db;

        public ElGamal(long p, long m, long g, long cb, long k)
        {
            this.p = p;
            this.m = m;
            this.g = g;
            this.cb = cb;
            this.k = k;
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

        public long mul(long q, long a, long k, long n)
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
            return q * b % n;
        }

        public string Perform()
        {
            db = mul(g, cb, p);
            r = mul(g, k, p);
            e = mul(m, db, k, p);
            m1 = mul(e, r, p - 1 - cb, p);

            return "r = " + r + " e = " + e + " m` = " + m1 + " db = " + db + "\n";
        }
    }
}
