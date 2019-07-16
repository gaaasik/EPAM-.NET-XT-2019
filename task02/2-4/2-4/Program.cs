using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4
{
    class MyString
    {
        public string StrOne = "";
        public string StrTwo = "";
        public char[] ToArray() //преобразование строки в массив
        {
            return StrOne.ToCharArray(); 
            
        }

        public void ToString(char[] MyArray) //преобразование массива в строку
        {
            string toString = String.Concat<char>(MyArray);
            Console.WriteLine("Результат преобразования массива в строку :" + toString );
        }

        public void PrintArray(char[] MyArray) // вывод массива на экран
        {
            Console.WriteLine("Вывод на экран массива из строки:");
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }
            
            
        }


        public void Conkat() //конкатенация строк(соединение строк)
        {
            string conkatResult = StrOne + " " + StrTwo;
            Console.WriteLine($"\nРезультат конкатенации строк: {conkatResult}");
            Console.ReadKey();
        }


        

        public void Search() //поиск символа ch
        {   Console.WriteLine("Введите символ для поиска");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Первая позиция символа "+ ch + " в строке: {0}", StrOne.IndexOf(ch));
            Console.ReadKey();
        }


        public void Compare() //сравнение строк
        {
            int result = String.Compare(StrOne, StrTwo);
            if (result < 0)
            {
                Console.WriteLine("Строка StrOne перед строкой StrTwo");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка StrOne стоит после строки StrTwo");
            }
            else
            {
                Console.WriteLine("Строки StrOne и StrTwo одинаковые");
            }
            Console.ReadKey();
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            MyString mystring = new MyString();

            Console.Write("Введите первую строку : ");
            mystring.StrOne = Console.ReadLine();

            Console.Write("Введите вторую строку : ");
            mystring.StrTwo = Console.ReadLine();

            again:                              //метка AGAIN
            Console.Clear();
            char[] MyArray = mystring.ToArray();
            mystring.PrintArray(MyArray);

            Console.WriteLine("Введите 1 для конкатенации строк "); // меню
            Console.WriteLine("Введите 2 для конвертации массива в строку ");
            Console.WriteLine("Введите 3 для конвертации строки в массив ");
            Console.WriteLine("Введите 4 для поиска символа в строке");
            Console.WriteLine("Введите 5 для сравнения  строк ");
            Console.WriteLine("Введите 6 для вывода строки на экран ");
            Console.WriteLine("Введите 7 для выхода из программы ");

            int caseSwitch = int.Parse(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1: mystring.Conkat();
                    goto again;
                    

                case 2: mystring.ToString(MyArray);
                    goto again;

                case 3:mystring.ToArray();
                    goto again;
                   
                case 4: mystring.Search();
                    goto again;
                    
                case 5: mystring.Compare();
                    goto again;

                case 6: mystring.PrintArray(MyArray);
                    goto again;
                case 7 : Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Default case");
                    goto again;
                    

            }
            

            Console.ReadKey(); 
        }
    }
}
