using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1den 5e kadar sayı artış");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);   
            }

            Console.WriteLine("1den 5e kadar tek sayı artış");
            for (int i = 1; i <= 5; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("0dan 5e kadar çift sayı artış");
            for (int i = 0; i <= 5; i=i+2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("5ten 1e kadar sayı azalış");
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
