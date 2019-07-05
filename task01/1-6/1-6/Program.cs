using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_6
{
    class Program
    {
        enum tracings { Bold = 1, Italic, Underline } //список начинается с 1 дальше +1

        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            int p1 = 0, p2 = 0, p3 = 0; //для проверки повторений
            string br = "       ";      // отступы для красоты
            Console.Write("параметры надписи: ");
 
             again:     // меткф again 
            
            if ((p1==0)&&(p2==0)&&(p3==0))
            { Console.WriteLine("none"); }
            
            Console.WriteLine();                                               //изначальное меню
            Console.WriteLine("введите:");
            
            Console.WriteLine(br.PadLeft(2)+"1:" + tracings.Bold);          
            Console.WriteLine(br.PadLeft(2) + "2:" + tracings.Italic);
            Console.WriteLine(br.PadLeft(2) + "3:" + tracings.Underline);
            Console.WriteLine(br.PadLeft(2) + "4:" + "Для выхода из программы");

                

            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case (int)tracings.Bold:
                    Console.Write("параметры надписи: ");
                    if (p2==1)                      // проверяем повторения  Italics
                    Console.Write(tracings.Italic + " ");
                    if (p3 == 1)                    // проверяем повторения  Underline в других case то же самое
                        Console.Write(tracings.Underline + " "); //если р =1 то значит выводим если нет то нет ))
                    if (p1==1)
                    {
                        p1 = 0;
                        break;
                    }
                    p1 += 1;
                    Console.WriteLine(tracings.Bold+" ");
                    break;



                case (int)tracings.Italic:
                    Console.Write("параметры надписи: ");
                    if (p1 == 1)
                        Console.Write(tracings.Bold + " ");
                    if (p3 == 1)
                        Console.Write(tracings.Underline + " ");
                    if (p2 == 1)
                    {
                        p2 = 0;
                        break;
                    }

                    p2 += 1;
                    Console.WriteLine(tracings.Italic + " ");
                    break;




                case (int)tracings.Underline:
                    Console.Write("параметры надписи: ");

                    if (p1 == 1)
                        Console.Write(tracings.Bold + " ");
                    if (p2 == 1)
                        Console.Write(tracings.Italic + " ");
                   
                    if (p3 == 1)
                    {
                        p3 = 0;
                        break;
                    }

                    p3 += 1;
                    Console.WriteLine(tracings.Underline + " ");
                    break;

                    case 4 :                //выход из программы
                    Environment.Exit(0);
                    break;



            }
            
            
            goto again;
           
        }
    }
}
