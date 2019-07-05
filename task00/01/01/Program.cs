using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        public static void String(int n)
        {
            for(int i = 1; i < n+1; i++ )
            {
                Console.Write(i);

                if (i == (n))
                { } else
                {
                    Console.Write(", ");
                }

            }

        }

        static void Main(string[] args)
        {
            Console.Write("ВВедите N = ");
            int n = int.Parse(Console.ReadLine());
            String(n);
            Console.ReadKey();
        }
    }
}
