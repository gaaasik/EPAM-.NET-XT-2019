using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    class Program
    {
        public class Triangle
        {
           public  int a, b, c; 
          

            public int Perimeter
            {
                get
                {
                    if (!((a + b > c) && (a + c > b) && (b + c > a)&&((a>0)&&(b>0)&&(c>0))))
                    {
                        throw new ArgumentException("Такого треугольника не существует! Измените значения.");
                    }
                    else
                        return a + b + c ;
                }
            }
            public double Square
            {
                get
                {
                    double p = (a + b + c) / 2;
                    p = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    return p;
                        
                }
            }

        }
        static void Main(string[] args)
        { var triangle = new Triangle();

            Console.WriteLine("Введите стороны треугольника :");
            Console.Write("a = ");
            triangle.a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            triangle.b = int.Parse(Console.ReadLine());
            Console.Write("с = ");
            triangle.c = int.Parse(Console.ReadLine()); 
    
           Console.WriteLine("Периметр треугольника = " + triangle.Perimeter);
            Console.WriteLine("Площадь треугольника = " + triangle.Square);
            Console.ReadKey();
        }
    }
}
