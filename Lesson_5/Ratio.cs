using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    internal struct Ratio
    {
        private int _m;
        private int _n;


        public int Numerator { get { return _m; } private set { _m = value; } }
        public int Denominator { get { return _n; } private set { _n = value; } }


        public Ratio(int Numerator, int Denominator)
        {
            _m = Numerator;
            _n = Denominator;
        }



        private static void CheckCarrent(Ratio r1, Ratio r2)
        {
            while ((r1._m / 2 > 0 && r1._m % 2 == 0 && r1._n / 2 > 0 && r1._n % 2 == 0)
                && (r2._m / 2 > 0 && r2._m % 2 == 0 && r2._n / 2 > 0 && r2._n % 2 == 0))
            {
                r1._m /= 2;
                r1._n /= 2;

                r2._m /= 2;
                r2._n /= 2;
            }
            while ((r1._m / 3 > 0 && r1._m % 3 == 0 && r1._n / 3 > 0 && r1._n % 3 == 0)
                && (r2._m / 3 > 0 && r2._m % 3 == 0 && r2._n / 3 > 0 && r2._n % 3 == 0))
            {
                r1._m /= 3;
                r1._n /= 3;

                r2._m /= 3;
                r2._n /= 3;
            }
        }
        private static void CarrentDenominator(Ratio r1, Ratio r2, out Ratio R1, out Ratio R2)
        {
            R1 = new Ratio(r1._m, r1._n);
            R2 = new Ratio(r2._m, r2._n);
            if (R1._n != R2._n)
            {
                R1._m = R1._m * R2._n;
                R2._m = R2._m * R1._n;

                R1._n = R1._n * R2._n;
                R2._n = R1._n;
            }
            CheckCarrent(R1, R2);
        }



        public static Ratio operator +(Ratio r1, Ratio r2)
        {
            if (r2._m == 0 || r2._n == 0) return new Ratio();
            Ratio R1;
            Ratio R2;
            CarrentDenominator(r1, r2, out R1, out R2);
            return new Ratio(R1._m + R2._m, R1._n);
        }
        public static Ratio operator -(Ratio r1, Ratio r2)
        {
            if (r2._m == 0 || r2._n == 0) return new Ratio();
            Ratio R1;
            Ratio R2;
            CarrentDenominator(r1, r2, out R1, out R2);
            return new Ratio(R1._m - R2._m, R1._n);
        }
        public static Ratio operator *(Ratio r1, Ratio r2)
        {
            if (r1._n == r2._n)
            {
                return new Ratio(r1._m * r2._m, r1._n);
            }
            return new Ratio(r1._m * r2._m, r1._n * r2._n);
        }
        public static Ratio operator %(Ratio r1, Ratio r2)
        {
            if (r2._m == 0 || r2._n == 0) return new Ratio();
            Ratio R1, R2;
            CarrentDenominator(r1, r2, out R1, out R2);
            while (R1._m >= R2._m)
            {
                R1._m -= R2._m;
            }
            return new Ratio(R1._m, R1._n);
        }
        public static Ratio operator /(Ratio r1, Ratio r2)
        {
            if (r2._m == 0 || r2._n == 0) return new Ratio();
            return new Ratio(r1._m * r2._n, r1._n * r2._m);
        }
        public static Ratio operator ++(Ratio r)
        {
            r._m++;
            r._n++;
            return r;
        }
        public static Ratio operator --(Ratio r)
        {
            r._m--;
            r._n--;
            return r;
        }
        public static Ratio operator -(Ratio r)
        {
            return new Ratio(-r._m, -r._n);
        }
        public static bool operator ==(Ratio r1, Ratio r2)
        {
            // что лучше это ? >>>> 
            return Equals(r1, r2); // рабочая версия 

            // или это ? >>> 
            if (r2._m == 0 || r2._n == 0) return false; // пример 
            Ratio R1;
            Ratio R2;
            CarrentDenominator(r1, r2, out R1, out R2);
            return (R1._m == R2._m && R1._n == R2._n);
        }
        public static bool operator !=(Ratio r1, Ratio r2)
        {
            return !(r1 == r2);
        }
        public static bool operator >(Ratio r1, Ratio r2)
        {
            if (r2._m == 0 || r2._n == 0) return false;
            Ratio R1;
            Ratio R2;
            CarrentDenominator(r1, r2, out R1, out R2);
            return R1._m > R2._m;
        }
        public static bool operator <(Ratio r1, Ratio r2)
        {
            if (r2._m == 0 || r2._n == 0) return false;
            Ratio R1;
            Ratio R2;
            CarrentDenominator(r1, r2, out R1, out R2);
            return R1._m < R2._m;
        }
        public static bool operator >=(Ratio r1, Ratio r2)
        {
            if (r2._m == 0 || r2._n == 0) return false;
            Ratio R1;
            Ratio R2;
            CarrentDenominator(r1, r2, out R1, out R2);
            return (R1._m >= R2._n || R1._n >= R2._n);
        }
        public static bool operator <=(Ratio r1, Ratio r2)
        {
            if (r2._m == 0 || r2._n == 0) return false;
            Ratio R1;
            Ratio R2;
            CarrentDenominator(r1, r2, out R1, out R2); ;
            return (R1._m <= R2._n || R1._n <= R2._n);
        }

        public override bool Equals(object r)
        {
            Ratio R;
            try
            {
                R = (Ratio)r;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return (this._m == R._m && this._n == R._n);
        }
        public override int GetHashCode()
        {
            //return base.GetHashCode();
            return HashCode.Combine(_m, _n);
        }
        public override string ToString()
        {
            return $"{_m}/{_n}";
        }

        public static implicit operator int(Ratio r)
        {
            return r._m / r._n;
        }
        public static implicit operator float(Ratio r)
        {
            return (float)r._m / r._n;
        }
    }
}
