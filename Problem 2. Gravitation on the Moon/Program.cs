﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Gravitation_on_the_Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());
           double moon = 0.17;
           double weightMoon = weight * moon;
           Console.WriteLine(weightMoon);
        }
    }
}
