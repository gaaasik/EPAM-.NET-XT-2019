using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4._3
{
    class Program
    {

        static void Main()
        {
            Complete += Print;

            int[] arr = { 2, 3, 6, 9, 23, 1, 223, 65, 789, 5, 45, 32, 345 };

            SeparateSort(arr, (a, b) => a > b);
            SeparateSort(arr, (a, b) => a > b);
            SeparateSort(arr, (a, b) => a > b);
            SeparateSort(arr, (a, b) => a > b);
            SeparateSort(arr, (a, b) => a > b);
        }

        static void Print(string str)
        {
            Console.WriteLine(str);
        }
        public static event Action<string> Complete;

        /// <summary>
        /// сортирвка пузырьком
        /// </summary>
        /// <param name="compare">делегат сравнения </param>
        public static void Sort<T>(T[] array, Func<T, T, bool> compare)
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

        /// <summary>
        /// сортировка в отдельном потоке 
        /// </summary>
        public static void SeparateSort<T>(T[] array, Func<T, T, bool> compare)
        {
            Thread thread = new Thread(() =>
            {
                Console.WriteLine($"Начало потока #{Thread.CurrentThread.ManagedThreadId}");

                Sort(array, compare);

                Console.WriteLine($"Работаем ... #{Thread.CurrentThread.ManagedThreadId}");
               
                Complete?.Invoke($"Закончена сортировка #{Thread.CurrentThread.ManagedThreadId}.");
            });

            thread.Start();
        }

    }
}