using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2
{
    class Program
    {
        static bool Compare(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return true;
            }

            if (str1.Length == str2.Length)
            {
                if (str1[0] < str2[0]) return false;

                for (int i = 1; i < str1.Length; i++)
                {
                    if (str1[i] > str2[i])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

       

        /// <summary>
        /// Сортирует произвольный массив в порядке возрастании
        /// </summary>
        /// <param name="compare">делегат для сравния</param>

        public static void SortArray<T>(T[] array, Func<T, T, bool> compare)
        {
            if (compare == null)
            {
                throw new ArgumentNullException();
            }

            for (int i = 0; i <= array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (compare(array[j], array[j + 1]))
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static void Main()
        {
            string[] array = { "meet", "my", "family","there","are", "five", "of", "us","parents" ,"elder", "brother"};

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            SortArray(array, Compare);

            Console.WriteLine("Отсортированный массив:");

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
