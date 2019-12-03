using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fraction_Library;

namespace Fraction_Console
{
    class Program
    {
        static void Main(string[] args)
        {          
            Fraction a = new Fraction(15, 3);
            Fraction b = new Fraction(2,6);
            Fraction c = new Fraction(-3, 5);
            Fraction d;
            Console.WriteLine($"a = {a}\nb = {b}\nc = {c}");
            d = a + b - c;
            Console.WriteLine($"a + b -c = {d}");
            d = (a * b + c - 10)/(d * 2);
            Console.WriteLine($"(a * b + c - 10) / 2 * previous result = {d}");
            if (d > a)
            {
                Console.WriteLine($"{d} is larger than {a}");
            }
            else if (d < a)
            {
                Console.WriteLine($"{d} is less than {a}");
            }
            else
            {
                Console.WriteLine($"{d} is equal to {a}");
            }
            Console.WriteLine($"{d} is also = {(double)d}");
            Console.ReadKey();
        }
    }
}
