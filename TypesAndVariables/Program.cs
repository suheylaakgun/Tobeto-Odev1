using System;
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
            char character = 'A';
            bool condition = false;
            byte number4 = 255; //0 ile 255 arasında değişen işaretsiz 8 bit (1 bayt) tamsayıları tutar.
            short number3 = 32767; //+ - 32768 e kadar çıkabilen ve tam sayıları tutabilen bir veri tipidir.
            int number1 = 2147483647; //-2147483648 ile 2147483647 arasındaki sayılardan oluşabilir.
            long number2 = 9223372036854775807; //–9223372036854775808 ile 9223372036854775807 arasında değer depolayabilmektedir.
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Character is: {0}", (int)character);
            Console.ReadLine(); 
        }
    }
}
