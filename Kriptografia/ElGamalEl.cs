using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Kriptografia
{
    class ElGamalEl
    {
        private long p;
        private long a;
        private long b;
        private long m;
        private long k;
        private Point G;
        private long Cb;

        public ElGamalEl(long p, long a, long b, long x, long y, long Cb, long m, long k)
        {
            this.p = p;
            this.a = a;
            this.b = b;
            this.m = m;
            this.Cb = Cb;
            this.k = k;
            G = new Point((int)x, (int)y);
        }

        private long fx(int x)
        {
            return x*x*x+a*x+b;
        }

        private long lasum(Point x, Point x1)
        {
            if (x1.X - x.X == 0)
            {
                return 0;
            }
            if ((x.Y - x1.Y) % (x1.X - x.X) != 0)
            {
               return (x.Y - x1.Y) * mul((x1.X - x.X), p - 1 - 1, p);
            }
            return ((x.Y - x1.Y) / (x1.X - x.X)) % p;
        }

        private long ladouble (Point x)
        {
            if ((3 * x.X * x.X + a) % (2 * x.Y) != 0)
            {
                long temp = mul(2 * x.Y, p - 1 - 1, p);
                return (3 * x.X * x.X + a) * temp;
            }
            return ((3 * x.X * x.X + a)/2*x.Y) % p;
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

        private Point systemDouble(Point x)
        {
            long temp = ladouble(x);
            long x3 = (temp*temp - 2*x.X);
            if (x3 < 0)
            {
                x3 %= p;
                x3 += p;
            }
            else
                x3 %= p;
            long y3 = temp * (x.X - x3) - x.Y;
            if (y3 < 0)
            {
                y3 %= p;
                y3 += p;
            }
            else y3 %= p;

            Point j = new Point((int)x3, (int)y3);

            return j;
        }

        private Point systemSum(Point x, Point x1)
        {
            long temp = lasum(x, x1);
            long x3 = (temp * temp - x.X - x1.X);
            if (x3 < 0)
            {
                x3 %= p;
                x3 += p;
            }
            else
                x3 %= p;

            long y3 = temp * (x.X - x3) - x.Y;
            if (y3 < 0)
            {
                y3 %= p;
                y3 += p;
            }
            else y3 %= p;

            Point j = new Point((int)x3, (int)y3);

            return j;
        }

        public string perform()
        {
            int q = 0;
            for (int i = 0; i < p; i++)
            {
                long h = fx(i);
                if (Math.Sqrt(h)%1 == 0 || Math.Sqrt(h%p)%1 == 0)
                {
                    if (Math.Sqrt(h) == 0 || Math.Sqrt(h%p) == 0)
                    {
                        q++;
                    } else q += 2;
                }
            }

            if (!Diffi.isSimple(q))
            {
                int i = 2;
                while (q >= i)
                {
                    while(q % i == 0)
                    {
                        q /= i;
                    }

                    if (q <= i)
                        break;

                    do
                    {
                        i++;
                    } while (!Diffi.isSimple(i));
                }
                q = i;
            }

            string s = "";
            long tempCb = Cb;
            while (tempCb != 1 && tempCb != 0)
            {
                s = tempCb % 2 + s;
                tempCb /= 2;
            }

            s = tempCb + s;

            Point Q = G;
            Point Q1 = G;

            for (int i = 1; i < s.Length; i++)
            {
                
                if (s[i] == '0')
                {
                    Q = systemDouble(Q);
                }
                else
                    if (s[i] == '1')
                    {
                        Q = systemSum(systemDouble(Q), Q1);
                    }
            }

            s = "";
            while (k != 1 && k != 0)
            {
                s = k % 2 + s;
                k /= 2;
            }

            s = k + s;

            Point R = G;
            Q1 = G;

            for (int i = 1; i < s.Length; i++)
            {

                if (s[i] == '0')
                {
                    R = systemDouble(R);
                }
                else
                    if (s[i] == '1')
                    {
                        R = systemSum(systemDouble(R), Q1);
                    }
            }

            Point P = Q;
            Q1 = G;

            for (int i = 1; i < s.Length; i++)
            {

                if (s[i] == '0')
                {
                    P = systemDouble(P);
                }
                else
                    if (s[i] == '1')
                    {
                        P = systemSum(systemDouble(P), Q1);
                    }
            }

            long e = m * P.X % p;


            s = "";
            while (Cb != 1 && Cb != 0)
            {
                s = Cb % 2 + s;
                Cb /= 2;
            }

            s = Cb + s;
            Q1 = R;
            for (int i = 1; i < s.Length; i++)
            {

                if (s[i] == '0')
                {
                    R = systemDouble(R);
                }
                else
                    if (s[i] == '1')
                    {
                        R = systemSum(systemDouble(R), Q1);
                    }
            }

            long m1 = e * mul(R.X, 9, p);



            return "";
        }
    }
}
