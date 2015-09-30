using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Prime_Number_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("true");
                    break;
                }
                else if ((n%i)!=0)
                {
                    {
                    Console.WriteLine("false");
                    break;
                }
                }
                
            }
        }
    }
}