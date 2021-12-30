using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    internal readonly struct Fraction
    {
        public readonly int num;
        public readonly int den;

        public Fraction(int numerator, int denominator)
        {
            this.num = numerator;
            this.den = denominator;
        }

        public static Fraction operator +(Fraction a)
        {
            return a;
        }
        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a.num, a.den);
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.num*b.den + b.num*a.den, a.den*b.den);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return a + (-b);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.num*b.num, a.den*b.den);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.den, a.den * b.num);
        }

    }
}
