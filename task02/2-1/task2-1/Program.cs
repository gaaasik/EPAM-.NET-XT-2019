using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_1
{
    class Program
    {
        public class Round
        {
            private double x, y, r;
            public double Radius
            {
                get
                {
                    return r;
                }

                set
                {
                    x = y = 0;
                    if (value <= 0) { throw new ArgumentException(" Введите корректные значения! "); }
                    r = value;
                }
            }

            public double Square
            {
                get
                {
                    return Math.PI * r * r;
                }
            }

            public double Length
            {
                get
                {
                    return 2 * Math.PI * r;
                }
            }           
        }

        static void Main(string[] args)
        {
            var Round = new Round();
            Console.Write("Введите радиус = ");
            int n = int.Parse(Console.ReadLine());
            Round.Radius = n;
            Console.WriteLine("Площадь круга = {0}", Round.Square);
            Console.WriteLine("Длина окружности = {0}", Round.Length);
            Console.ReadKey();
        }
    }
}