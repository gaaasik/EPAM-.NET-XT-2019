using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 21, -23, 32, 1, 23, 5, 3, -76, 432, 654, 3, -2, 6, 9, -54, 21, 6, 12};
            
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            SortArray(array, (a, b) => a > b);

            Console.WriteLine("Отсортированный массив:");

            foreach (var item in array)
            {
                Console.Write(item+ " ");
            }
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
            
            for (int i = 0; i < array.Length; i++)
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
    }
}
