using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7
{
    class Program
    {
        static void Sort(int[] A) // сортировка методом пузырька
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        int z = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = z;
                    }
                }
            }

        }
        static void Print(int[] A)// вывод массива на экран 

        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
        }



         static void max(int[] A)
        { int max = A[0];
            for(int i = 0;i<A.Length;i++)
            {
                if (max < A[i])
                    max = A[i];
            }
            Console.WriteLine("максимальный элемент = " + max);
        }



        static void min (int[] A)
        {
            int min = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (min > A[i])
                    min = A[i];
            }
            Console.WriteLine("минимальный элемент = " + min);
        }




        static void Main(string[] args)
        {   again:
            Console.Write("Введите размер массива = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] arr = new int[n];
            Random rand = new Random(); // рандомный массив от - 100 до 100

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            max(arr);
            min(arr);
            
            Sort(arr);  // вызов функции
            Console.WriteLine();
            Console.WriteLine("Отсортированный масиив:");
            Console.WriteLine();
            Print(arr);
            Console.WriteLine();


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
