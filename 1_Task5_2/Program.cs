using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Task5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            const int a = 0;
            const int b = 50;
            int[] array = new int[n];
            int max = 0;
            int min = b+1;
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(a, b);
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();

            for (int t = 0; t < n; t++)
            {
               max = Math.Max(array[t], max);
               min = Math.Min(array[t], min);
            }
            Console.WriteLine("Максимальное значение в массиве - {0} ", max);
            Console.WriteLine("Минимальное значение в массиве - {0} ", min);
            Console.WriteLine("Сумма минимального и максимального значений равна - {0} ", min+max);
            Console.ReadKey();
        }
    }
}
