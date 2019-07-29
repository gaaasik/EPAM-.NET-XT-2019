using System;

namespace NUMBER_ARRAY_SUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] int_arr = { 1, 2, 3, 4, 5, 6, 7 };
            float[] float_arr2 = { 1.1f, 2.1f, 3.1f, 4.1f, 5.1f, 6.1f, 7.1f };
           
            Console.WriteLine("Int array sum: {0}", int_arr.Sum());
            Console.WriteLine("Float array sum: {0}", float_arr2.Sum());
              }
    }

    static class ArraySum
    {
        public static int Sum(this int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            return sum;
        }
        public static float Sum(this float[] arr)
        {
            float sum = 0;
            foreach (float item in arr)
            {
                sum += item;
            }
            return sum;
        }
    }
}