using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность трехмерного массива = ");
            int t = int.Parse(Console.ReadLine());
            int[,,] m = new int[t, t, t];
            
            int n = -3;                 // начинаем с -3 потом будет - 2 - 1 и тд

            for (int x = 0; x < t; x++)
            {
                for (int y = 0; y < t; y++)
                {
                    for (int z = 0; z < t; z++)
                    {
                        m[x, y, z] = n++;   // сначала три цифры отрицательные остальные положительные

                        if (m[x, y, z]<0)
                        {
                            m[x, y, z] = 0;
                        }
                        Console.Write(m[x, y, z]);

                    }
                   


                }
               
                Console.ReadLine();
                
            }
        }

    }
}
