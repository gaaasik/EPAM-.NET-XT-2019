using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_11
{
    class Program
    {
        static void Main(string[] args)
        {   again:

            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            string[] words = str.Split(' ', ',', '.', '!', '?', ';');

            int average = 0;
            float s=0;

            foreach (var word in words)
            {
                average += word.Length;
                s++;
                

            }

            s = average / s;

            Console.Write("Средняя длина слова = ");
            Console.WriteLine(s);

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
