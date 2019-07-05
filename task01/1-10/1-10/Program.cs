using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_10
{
    class Program
    {
        static void Main(string[] args)
        { Random rand = new Random();
            again:
            Console.WriteLine("Введите размерность ");
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rand.Next(10);
                    Console.Write(a[i, j]+" ");
                    if ( (i+j) % 2 == 0)                        //проверка на четность
                    {
                        sum += a[i, j]; 
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Сумма элементов стоящих на четных позициях " + sum);
            Console.ReadKey();
            ConsoleKeyInfo key;
        
            Console.Clear();
            Console.WriteLine("Если хочешь попробовать еще нажми Enter");
            Console.WriteLine();

            Console.WriteLine("Для выхода из программы нажми Escape");
            Console.WriteLine();

            key = Console.ReadKey(); // повторение программы 
            if (key.Key == ConsoleKey.Enter) goto again;
        }
    }
}
