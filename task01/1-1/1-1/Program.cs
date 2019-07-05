using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            again:                      //метка  again
            Console.Write("Введите а = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите b = ");
            int b = int.Parse(Console.ReadLine());
            if ((a <= 0) || (b <= 0)) // проверка на отрицательные числа и ноль  
            {
                Console.WriteLine("Введите корректные значения!");
                Console.WriteLine();
                goto again;
            }
            else
            {
                int s = 0;
                s = a * b;
                Console.WriteLine("Площадь прямоугальника = " + s);
                Console.WriteLine();
            }
            ConsoleKeyInfo key;
            Console.WriteLine("Если хочешь попробовать еще нажми Enter");
            Console.WriteLine();

            Console.WriteLine("Для выхода из программы нажми Escape");
            Console.WriteLine();

            key = Console.ReadKey();            // повторение программы
            if (key.Key == ConsoleKey.Enter)  goto again;
            
        }
    }
}
    

