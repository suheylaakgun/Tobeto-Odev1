﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ValueTypes
            //Console.WriteLine("Hello World");
            int number1 = 2147483647; //-2147483648 ile 2147483647 arasındaki sayılardan oluşabilir.
            long number2 = 9223372036854775807; //–9223372036854775808 ile 9223372036854775807 arasında değer depolayabilmektedir.
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.ReadLine(); 
        }
    }
}