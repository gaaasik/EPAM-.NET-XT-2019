using System;

namespace _4._5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            var myString = Console.ReadLine();

            if (myString.IsInt())
            {
                Console.WriteLine($"{myString} is positive integer");
            }
            else
            {
                Console.WriteLine($"{myString} is NOT positive integer");
            }
            Console.ReadKey();
        }
    }

    public static class StringExtension
    {
        public static bool IsInt(this string str)
        {
            if (str == null || str=="")
            {
                throw new ArgumentNullException($"Введите корректные значения {nameof(str)} !!");
            }

            str = str.Trim();

            if (str.Length == 1 & str[0] == '0')
            {
                return false;
            }

            foreach (char symbol in str)
            {
                if (!char.IsDigit(symbol))  
                {
                    return false;
                }
            }

            return true;
        }

       
    }
}