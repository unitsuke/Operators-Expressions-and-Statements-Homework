using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Four_Digit_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d = n%10;
            int c = (n/10) % 10;
            int b = (n/100) % 10;
            int a = (n/1000) % 10;
            int t = a + b + c + d;
            Console.WriteLine(t);
            Console.WriteLine("{0}{1}{2}{3}", d, c,b,a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
