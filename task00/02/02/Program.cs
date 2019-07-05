using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {   public static bool PrimeNumber(int n )
        {
            for (int i = 2; i < (int)(n / 2); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {  
            Console.Write("Введите N = ");
            int ch = int.Parse(Console.ReadLine());

            if (PrimeNumber(ch))
            {
                Console.WriteLine("Число явдяется простым!");

            }
            else
            {
                Console.WriteLine("FALSE");

                
            }
            
            Console.ReadKey();
        }

        
    }
}
