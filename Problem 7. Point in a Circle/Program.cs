using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Point_in_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((n<1) && (y<1))
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
