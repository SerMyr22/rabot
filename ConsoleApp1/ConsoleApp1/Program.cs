﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double g;
            Console.WriteLine("Введите х");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = Convert.ToDouble(Console.ReadLine());


            g = x * Math.Exp(-y) + (Math.Pow(2, x + y)) / 2 * Math.Pow(3, Math.Cos(x));

            Console.WriteLine(g);
        }
    }
}
