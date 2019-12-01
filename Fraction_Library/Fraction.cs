using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction_Library
{
    public class Fraction
    {
        protected long Numerator;
        protected long Denominator;
        public Fraction(long numer, long denom)
        {
            Numerator = numer;
            Denominator = denom;
        }
        public Fraction(long numer)
        {
            Numerator = numer;
            Denominator = 1;
        }
        public static Fraction operator +(Fraction a)
            {
            return a;
            }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction result;
            if (a.Denominator == b.Denominator)
            {
                result = new Fraction(a.Numerator + b.Numerator, a.Denominator);
            }
            else
            {
                result = new Fraction(a.Numerator * b.Denominator + b.Numerator * a.Denominator, 
                                        a.Denominator * b.Denominator);
            }
            result.Simplify();
            return result;
        }
        public static Fraction operator +(Fraction a, long c)
        {
            Fraction result;
            Fraction b = new Fraction(c * a.Denominator, a.Denominator);
            if (a.Denominator == b.Denominator)
            {
                result = new Fraction(a.Numerator + b.Numerator, a.Denominator);
            }
            else
            {
                result = new Fraction(a.Numerator * b.Denominator + b.Numerator * a.Denominator,
                                        a.Denominator * b.Denominator);
            }
            result.Simplify();
            return result;
        }
        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a.Numerator, a.Denominator);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction result;
            if (a.Denominator == b.Denominator)
            {
                result = new Fraction(a.Numerator - b.Numerator, a.Denominator);
            }
            else
            {
                result = new Fraction(a.Numerator * b.Denominator - b.Numerator * a.Denominator,
                                        a.Denominator * b.Denominator);
            }
            result.Simplify();
            return result;
        }
        public static Fraction operator -(Fraction a, long c)
        {
            Fraction result;
            Fraction b = new Fraction(c * a.Denominator, a.Denominator);
            if (a.Denominator == b.Denominator)
            {
                result = new Fraction(a.Numerator - b.Numerator, a.Denominator);
            }
            else
            {
                result = new Fraction(a.Numerator * b.Denominator - b.Numerator * a.Denominator,
                                        a.Denominator * b.Denominator);
            }
            result.Simplify();
            return result;
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction result = new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
            result.Simplify();
            result.Fix();
            return result;
        }
        public static Fraction operator *(Fraction a, long b)
        {
            Fraction result = new Fraction(a.Numerator * b, a.Denominator);
            result.Simplify();
            result.Fix();
            return result;
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            Fraction result = a * !b;
            result.Simplify();
            result.Fix();
            return result;
        }
        public static Fraction operator /(Fraction a, long b)
        {
            Fraction c = new Fraction(b, 1);
            Fraction result = a * !c;
            result.Simplify();
            result.Fix();
            return result;
        }
        public static Fraction operator !(Fraction a)
        {
            Fraction result = new Fraction(a.Denominator, a.Numerator);
            result.Fix();
            return result;
        }
        public static explicit operator double(Fraction a)
        {
            return (double)a.Numerator / a.Denominator;
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            return (double)a == (double)b;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return (double)a != (double)b;
        }
        public static bool operator >(Fraction a, Fraction b)
        {
            return (double)a > (double)b;
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            return (double)a < (double)b;
        }
        public static bool operator >=(Fraction a, Fraction b)
        {
            return (double)a >= (double)b;
        }
        public static bool operator <=(Fraction a, Fraction b)
        {
            return (double)a <= (double)b;
        }
       
        public void Simplify()
        {
            long min;
            if (Numerator > Denominator)
            {
                min = Denominator;
            }
            else
            {
                min = Numerator;
            }
            long nsk = 1;
            for (long i = min; i > 0; i--)
            {
                if ((Numerator % i == 0) && (Denominator % i == 0))
                {
                    nsk = i;
                    break;
                }
            }
            Numerator /= nsk;
            Denominator /= nsk;
            
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
        public void Fix()
        {
            if ((Denominator <= 0 && Numerator <= 0) || (Denominator <= 0 && Numerator >= 0)) ;
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }
    }
}
