using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Third_Digit_is_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if ((n/100)%10==7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("fasle");
            }
        }
    }
}
