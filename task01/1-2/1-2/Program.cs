using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2
{
    class Program
    {      static void triangle(int n)
          {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                   
                        Console.Write("*");
                   
                }
                Console.WriteLine();
            }

          }

        static void Main(string[] args)
        {   again:
            Console.Write("введите N = ");
            int n = int.Parse(Console.ReadLine());
            triangle(n);
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
