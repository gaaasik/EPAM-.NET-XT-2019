using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, k;
            again:
            Console.Write("Введите N = ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j < n - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            ConsoleKeyInfo key;
            Console.WriteLine("Если хочешь попробовать еще нажми Enter");
            Console.WriteLine();

            Console.WriteLine("Для выхода из программы нажми Escape");
            Console.WriteLine();

            key = Console.ReadKey(); // повторение программы 
            if (key.Key == ConsoleKey.Enter) goto again;
        }
    }
}
