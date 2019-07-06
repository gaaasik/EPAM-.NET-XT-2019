using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_12
{
    class Program
    {
        static void Main(string[] args)
        {   again:
            Console.Clear();
            string string1 = "";
            string string2 = "";
            string endsting = "";

            Console.WriteLine("Введите первую строку:");
            string1 = Console.ReadLine();

            Console.WriteLine("Введите вторую строку:");
            string2 = Console.ReadLine();

            foreach (char symbol in string1)
                if (!string2.Contains(symbol))
                    endsting += symbol;
                else
                {
                    endsting += symbol;
                    endsting += symbol;
                }
            Console.WriteLine("Полученная  строка = " + endsting);
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
