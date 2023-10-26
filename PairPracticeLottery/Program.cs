using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairPracticeLottery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PracticeLotterySuh();
            Console.WriteLine("Kolon sayısı giriniz:");
            int columnCount = Convert.ToInt32(Console.ReadLine());
            printArray(columnCount);
        }

        static void printArray(int columnCount)
        {
            if (columnCount >= 1 && columnCount <= 8)
            {
                Random rnd = new Random();
                int[] numbers = new int[6];
                for (int i = 1; i <= columnCount; i++)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        int tmp = rnd.Next(1, 50);
                        while (numbers.Contains(tmp)) //numbers dizisinde tmp sayısı varsa tekrar tmp üret.
                        {
                            tmp = rnd.Next(1, 50);
                        }
                        numbers[j] = tmp;
                    }
                    Console.WriteLine(i + ". kolon değerleri: " + string.Join(",", numbers));
                    Console.ReadLine();
                    /*for (int j = 0; j < numbers.Length; j++)
                    {
                        Console.Write(numbers[j] + " ");
                    }
                    Console.WriteLine();*/
                }
            }
            else
            {
                Console.WriteLine("Kolon sayısı 1 ile 8 arasında olmalıdır!");
            }
        }

        private static void PracticeLotterySuh()
        {
            Console.WriteLine("Column enter:");
            int columnCount = Convert.ToInt32(Console.ReadLine());
            if (columnCount >= 1 && columnCount <= 8)
            {

                Random rnd = new Random();


                for (int i = 1; i <= columnCount; i++)
                {
                    int[] arr = new int[6];
                    for (int j = 0; j < arr.Length; j++)
                    {
                        int tmp = rnd.Next(1, 50);
                        while (arr.Contains(tmp)) //numbers dizisinde tmp sayısı varsa tekrar tmp üret.
                        {
                            tmp = rnd.Next(1, 50);
                        }
                        arr[j] = tmp;
                    }
                    Console.WriteLine(i + "kolon değerleri: " + string.Join(",", arr));
                }
                //PrintTheArray(arr);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız!");
                Console.WriteLine("Column enter:");
                Console.ReadLine();
            }
        }

    }
}
