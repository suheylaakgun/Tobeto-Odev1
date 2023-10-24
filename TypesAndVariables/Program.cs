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
            double number5 = 10.4; //64 bitlik (8 byte) gerçek sayı depolarlar. 1.7E +/- 308 (15 basamak)  arasında değer depolayabilmektedir.
            decimal number6 = 10.4m; //sayı sonuna eklenen harf m ya da M olabilir. 29 anlamlı basamağı destekler ve 7,9228 x 10^28'den büyük değerleri temsil edebilir. Özellikle çok sayıda basamak gerektiren ancak yuvarlama hatalarına dayanamayan finansal hesaplamalar için uygundur. varsayılan değeri Decimal 0'dır.
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
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Character is: {0}", (int)character);
            Console.ReadLine(); 
        }
    }
}
