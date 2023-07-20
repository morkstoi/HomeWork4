using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNxN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленное положительное число N:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        array[i, j] = 0;
                    }

                }

            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
