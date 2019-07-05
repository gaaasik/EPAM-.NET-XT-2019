using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            again:
            Console.Clear();
            Console.WriteLine("Введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] a = new int[n];

            for (int i =0; i<n; i++)
            {
                a[i] = rand.Next(-10,20);                       //заполнение рандомом
                Console.Write(a[i] + " ");
                if (a[i] > 0)               // проверка на неотрицательные числа
                    sum += a[i];
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Сумма неотрицательных элементов " + sum);
            ConsoleKeyInfo key;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Если хочешь попробовать еще нажми Enter");
            Console.WriteLine();

            Console.WriteLine("Для выхода из программы нажми Escape");
            Console.WriteLine();

            key = Console.ReadKey(); // повторение программы 
            if (key.Key == ConsoleKey.Enter) goto again;
        }
    }
}
