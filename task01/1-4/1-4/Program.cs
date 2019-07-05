using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4
{
    class Program
    {
        static void triangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    string br = new String('*', j);
                    Console.WriteLine(br.PadLeft(n + 2) + "*" + br);
                }
            }
        }
        static void Main(string[] args)
        {
            int n , k;
            again:
            Console.Write("Введите N = ");
            n = int.Parse(Console.ReadLine());
            
            
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
