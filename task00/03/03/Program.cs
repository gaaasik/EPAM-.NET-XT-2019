using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Squere(int n )
        {
            float x = n/2;
            float y = n/2;
            for (int i = 0; i < n; i++)
            {   
                for (int j = 0; j < n; j++)
                {   
                    if ((x != i)||(y != j))
                    {
                       
                         Console.Write("*");

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите N = ");
            int n = int.Parse(Console.ReadLine());
            Squere(n);
            Console.ReadKey();
        }
    }
}
