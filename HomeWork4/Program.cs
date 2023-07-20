using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            float Sum = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i}:\t");
                array[i] = Convert.ToInt32(Console.ReadLine());
                Sum += array[i];
            }
            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < 7; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое элементов массива равно: {0:f2}", Sum / 7);
            Console.ReadKey();
        }
    }
}
