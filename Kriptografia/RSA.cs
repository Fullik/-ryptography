using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kriptografia
{
    class RSA
    {
        private long m;
        private long Pa;
        private long Qa;
        private long Na;
        private long Db;
        private long Fi;
        private long E;
        private long Ca;
        private long m1;

        public RSA(long m, long Pa, long Qa, long Db)
        {
            this.m = m;
            this.Pa = Pa;
            this.Qa = Qa;
            this.Db = Db;
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
            Na = Pa * Qa;
            Fi = (Pa - 1) * (Qa - 1);
            Ca = mul(Db, Fi - 1, Fi);
            E = mul(m, Db, Na);
            m1 = mul(E, Ca, Na);
            return "m = " + m + " pa = " + Pa + " qa = " + Qa + " Na = " + Na + " db = " + Db + " fi = " + Fi + " e = " + E + " ca = " + Ca + " m' = " + m1 + "\n";
        }
    }
}
