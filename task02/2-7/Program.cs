using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7
{
    class Program
    { class Point
        {
            public int x_1;
            public int X_1
            {
                get => x_1;
                set
                {
                    x_1 = value;
                }
            }

            public int y_1;
            public int Y_1
            {
                get => y_1;
                set
                {
                    y_1 = value;
                }
            }
            public virtual void Show()
            {
                Console.WriteLine("x_1 = {0}  y_1 = {1}", x_1, y_1);
            }

        }
        class Line : Point
        {

            private int x_2;
            public int X_2
            {
                get => x_2;
                set
                {
                    x_2 = value;
                }
            }
            private int y_2;
            public int Y_2
            {
                get => y_2;
                set
                {
                    y_2 = value;
                }
            }
            public override void Show()
            {
                Console.WriteLine("Линия из точки X1 = {0} Y1 = {1} в точку X2 ={2}  Y2 = {3}", x_1, y_1, x_2, y_2);
            }

        }
        class Circle : Point //окружность
        {
            private int r;
            public int R
            {
                get => r;
                set
                { if (value <= 0)
                        throw new ArgumentException("Введите корректные значения!");
                    r = value;
                }
            }
            public override void Show()
            {
                Console.WriteLine("Окружность с радиусом R = " + R + " Длина этой окружности равна L = " + 2 * Math.PI * r);
            }
        }
        class A_Circle : Circle
        {
            private int radius;
            public int Radius
            {
                get
                {
                    return radius;
                }
                set
                {
                    if (value <= 0)
                        throw new ArgumentException("Введите корректные значения!");
                        radius = value;
                }
            }
            public override void Show()
            {
                Console.WriteLine("Круг имеет радиус R = " + Radius + "Длину его окружности = "+ (2 * Math.PI * Radius) + " и площадь круга = " +( Math.PI * Radius * Radius));
            }
        }
        class Ring : Point //класс Кольцо
        {
            private int inter_radius;
            public int Inter_Radius
            {
                get
                {
                    return inter_radius;
                }
                set
                {
                    inter_radius = value;
                }
            }
            private int extern_radius;
            public int Extern_Radius
            {
                get
                {
                    return extern_radius;
                }
                set
                {
                    extern_radius = value;
                }
            }
            public override void Show()

            {
                Console.WriteLine("Кольцо с площадью: "+ (Math.PI * (Extern_Radius * Extern_Radius - Inter_Radius * Inter_Radius)));
            }
        }
        class Rectangle : Point //класс Прямоугольник
        {
            private int A;
            public int SideA
            {
                get
                {
                    return A;
                }
                set
                {
                    A = value;
                }
            }
            private int B;
            public int SideB
            {
                get
                {
                    return B;
                }
                set
                {
                    B = value;
                }
            }
            public override void Show()

            {
                Console.WriteLine("Прямоугольник с периметром P = " + 2 * (SideA + SideB) + " и площадью S = " + SideA * SideB);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 для создания точки ");
            Console.WriteLine("Введите 2 для создания линии ");
            Console.WriteLine("Введите 3 для создания окружности");
            Console.WriteLine("Введите 4 для создания круга");
            Console.WriteLine("Введите 5 для создания кольца");
            Console.WriteLine("Введите 6 для создания прямоугольника");
       
            int caceSwitch = int.Parse(Console.ReadLine());
            switch (caceSwitch)
            {
                case 1:

                Point point = new Point();
                point.X_1 = 5;
                point.Y_1 = 7;
                point.Show();
                    break;
                case 2:
                    Line line = new Line();

                    line.X_1 = 5;
                    line.Y_1 = 7;
                    line.X_2 = 50;
                    line.Y_2 = 70;
                    line.Show();
                    break;

                case 3:

                    Circle circle = new Circle();
                    circle.R = 10;
                    circle.Show();
                    break;

                case 4:
                    A_Circle a_circle = new A_Circle();
                    a_circle.Radius = 6;
                    a_circle.Show();
                    break;
                 case 5:
                    Ring ring = new Ring();
                    ring.Inter_Radius = 5;
                    ring.Extern_Radius = 7;
                    ring.Show();
                 break;
                case 6:
                    Rectangle rectangle = new Rectangle();
                    rectangle.SideA = 5;
                    rectangle.SideB = 6;
                    rectangle.Show();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;

            }
            Console.ReadKey();

        }
    }
}
