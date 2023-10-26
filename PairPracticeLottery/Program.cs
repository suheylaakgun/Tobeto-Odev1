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
            Console.WriteLine("Column enter:");
            int columnCount = Convert.ToInt32(Console.ReadLine());
            if (columnCount >=1 && columnCount <=8)
            {
                
                Random rnd = new Random();
                int tmp;

                for (int i = 1; i <= columnCount; i++)
                {
                    int[] arr = new int[6];
                    for (int j = 0; j < arr.Length; j++)
                    {
                        tmp = rnd.Next(1, 49);
                        if (IsDup(tmp, arr))
                        {
                            //tmp = rnd.Next(1, 49);
                            arr[j] = tmp;
                        }
                        else
                        {
                            j--;
                        }
                    }
                    Console.WriteLine(i + "kolon değerleri: " + string.Join(",",arr));
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
        //private static void PrintTheArray(int[] arr)
        //{
        //    foreach (var item in arr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        private static bool IsDup(int tmp, int[] arr)
        {
            if (arr.Length == 0) 
            {
            }

            foreach (var item in arr)
            {
                if (item == tmp)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
