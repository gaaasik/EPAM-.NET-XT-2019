using System;

namespace _2_6
{
    class Program
    {
        class Ring
        {
            private double i_r, e_r, x, y;
            public double internel_radius //Внтренний
            {
                get
                {
                    return i_r;
                }
                set
                {
                    if (value <= 0) { throw new ArgumentException(" Введите корректные значения! "); }
                    i_r = value;
                }

            }
            public double externel_radius //внешний
            {
                get
                {
                    return e_r;
                }
                set
                {
                    if ((value <= 0)||(value <= internel_radius)) { throw new ArgumentException(" Введите корректные значения! "); }
                    e_r = value;
                }

            }
            public double Center_X
            {
                get => x;
                set
                {
                    x = value;
                }
            }
            public double Center_Y
            {
                get => y;
                set
                {
                    y = value;
                }
            }
            public double square
            {
                get => Math.PI * ( externel_radius * externel_radius - internel_radius * internel_radius); // S=PI*(R^2-r^2)
            }

            public double SumLength
            {
                get => 2 * Math.PI*(externel_radius + internel_radius);
            }

        }
        static void Main(string[] args)

        {
            Ring ring = new Ring();
            again:
            Console.Clear();
            Console.WriteLine("Введите данные");
            Console.Write("X = ");
            ring.Center_X = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            ring.Center_Y = double.Parse(Console.ReadLine());
            Console.Write("R = ");
            ring.externel_radius = double.Parse(Console.ReadLine());
            Console.Write("r = ");
            ring.internel_radius = double.Parse(Console.ReadLine());


            Console.Clear();
            Console.WriteLine("Кольцо с центрами в точке Х = {0} Y = {1} ;", ring.Center_X, ring.Center_Y);
            Console.WriteLine("С площадью S = " + ring.square);
            Console.WriteLine("Имеет суммарную длину окружностей L = " + ring.SumLength);

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
