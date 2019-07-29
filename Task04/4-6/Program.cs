using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._6
{
    public class Program
    {
      
        public static bool IsPositive(int x) => x > 0;

        public delegate bool Condition<T>(T x);

        public static   T[] ArrayFindAllPositive<T>(T[] array)
        {
            
            var resultList = new List<T>();

            var defaultComparer = Comparer<T>.Default;

            foreach (T element in array)
            {
                if (defaultComparer.Compare(element, default) > 0)
                {
                    resultList.Add(element);
                }
            }

            return resultList.ToArray();
        }

        public static T[] ArrayFindAll<T>(T[] array, Condition<T> condition)
        {
            NullCheck(condition);

            var resultList = new List<T>();

            foreach (T element in array)
            {
                if (condition(element))
                {
                    resultList.Add(element);
                }
            }

            return resultList.ToArray();
        }

        private static void NullCheck<T>(Condition<T> condition)
        {
            if (condition == null)
            {
                throw new ArgumentNullException($"{nameof(condition)} is null!");
            }
        }

        public static void Main(string[] args)
        {
            var array = new int[] { 1, 90, 3, -2, 11, };


            var positiveArray = ArrayFindAllPositive(array); //простой вызов метода

            var condition_instance = new Condition<int>(IsPositive); //экземпляр делегата
            var positiveArrayInstance = ArrayFindAll(array, condition_instance);

            //делегат в виде анонимного метода
            Condition<int> condition_anonymous = delegate (int x) { return x > 0; };    //делегат в виде анонимного метода

            var positiveArrayAnonymous = ArrayFindAll(array, condition_anonymous);

            var positiveArraylambda = ArrayFindAll(array, x => x > 0);    //делегат в виде лямбда-выражения

            var positiveArraylINQ = array.Where(x => x > 0).ToArray();
        }
    }
}