using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //var result = Add2();

            //int number1; //out ile def değer şart değil ancak ref ile def değer şart.
            //int number2 = 100;
            //var result2 = Add3(out number1, number2);

            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2, 4, 5));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!!!!");
        }
        //Kural! : default parametre son parametrelere verilir.
        //Parametreye değer atanmışsa def. değer yerine atanan değer geçerli olur.
        static int Add2(int number1=20, int number2=30)
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            var result = number1 + number2;
            return result;
        }

        static int Multiply(int number1, int number2)
        { 
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
    }
}
