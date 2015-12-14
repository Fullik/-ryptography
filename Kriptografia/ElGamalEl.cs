using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return mod(x*x*x+a*x+b,p);
        }

        public Point systemDouble(Point G)
        {
            // double l = (3 * Math.Pow(G.X, 2) + a)/2*G.Y;

            long part1 = (long)mod((3 * G.X*G.X + a), p);

            long part2 = mul((long)(2 * G.Y), p -1 - 1, p);

            long l = mod(part1 * part2, p);

            long x = mod(l*l - 2 * G.X, p);
            long y = mod((l * (G.X - x) - G.Y), p);

            return (new Point((int)x, (int)y));
        }

        public Point systemSum(Point a, Point b)
        {
            Point new_point = systemDouble(a);

            long part1 = (long)mod((b.Y - new_point.Y), p);

            long part2 = mul((long)(b.X - new_point.X), p - 1 - 1, p);

            long l = mod(part1 * part2, p);

            long x = mod(l*l - new_point.X - b.X, p);
            long y = mod((l * (new_point.X - x) - new_point.Y), p);

            return new Point((int)x, (int)y);
        }

        public long mod(long x, long m)
        {
            return (x % m + m) % m;
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

            q++;

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

            Point K = null;

            for (int i = 1; i < s.Length; i++)
            {

                if (s[i] == '1')
                {
                    if (K == null)
                    {
                        K = systemSum(G, G);
                    }
                    else
                    {
                        K = systemSum(K, G);
                    }

                }

                if (s[i] == '0')
                {

                    if (K == null)
                    {
                        K = systemDouble(G);
                    }
                    else
                    {
                        K = systemDouble(K);
                    }
                }
            }

            Point Db = K;

            s = "";
            while (k != 1 && k != 0)
            {
                s = k % 2 + s;
                k /= 2;
            }

            s = k + s;

            Point R = null;

            for (int i = 1; i < s.Length; i++)
            {

                if (s[i] == '1')
                {
                    if (R == null)
                    {
                        R = systemSum(G, G);
                    }
                    else
                    {
                        R = systemSum(R, G);
                    }

                }

                if (s[i] == '0')
                {

                    if (R == null)
                    {
                        R = systemDouble(G);
                    }
                    else
                    {
                        R = systemDouble(R);
                    }
                }
            }

            Point P = null;

            for (int i = 1; i < s.Length; i++)
            {

                if (s[i] == '1')
                {
                    if (P == null)
                    {
                        P = systemSum(Db, Db);
                    }
                    else
                    {
                        P = systemSum(P, Db);
                    }

                }

                if (s[i] == '0')
                {

                    if (P == null)
                    {
                        P = systemDouble(Db);
                    }
                    else
                    {
                        P = systemDouble(P);
                    }
                }
            }

            long e = mod(m * P.X, p);


            s = "";
            while (Cb != 1 && Cb != 0)
            {
                s = Cb % 2 + s;
                Cb /= 2;
            }

            s = Cb + s;
            Point Q = null;
            for (int i = 1; i < s.Length; i++)
            {

                if (s[i] == '1')
                {
                    if (Q == null)
                    {
                        Q = systemSum(R, R);
                    }
                    else
                    {
                        Q = systemSum(Q, R);
                    }

                }

                if (s[i] == '0')
                {

                    if (Q == null)
                    {
                        Q = systemDouble(R);
                    }
                    else
                    {
                        Q = systemDouble(R);
                    }
                }
            }

            long m1 = mod(e * mul(Q.X, p - 1 - 1, p), p);



            return "m = " + m + "\n R = " + "(" + R.X + "," + R.Y + ") " + "e = " + e + " m' = " + m1 + "\n ";
        }
    }

    public class Point
    {
        public long X { get; set; }
        public long Y { get; set; }
        public Point(long x, long y)
        {
            X = x;
            Y = y;
        }

        public Point()
        {

        }
    }
}
