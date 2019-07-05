using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int t = 3;
            int p = 5;
            int sum = 0;
            while (t < 1000)    
            {
                sum += t;
                t += 3;

            }
            while (p < 1000)        //кол-во иттераций в два раза меньше чем использование обычного if((i%3==0)||(i%5==0))
            {
                sum += p;
                p += 5;

            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }

    }
}
