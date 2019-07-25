using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    class Program
    {
        static Dictionary<string, int> Frequency(string str)
        {
            string[] words = str.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> frequency = new Dictionary<string, int>();

            foreach (string word in words )
            {

                if (frequency.ContainsKey(word.ToLower()))
                    frequency[word.ToLower()]++;
                else frequency.Add(word.ToLower(), 1);
            }

            return frequency;
         }


        static void Main(string[] args)
        {
            Console.Write("Введите текст : ");
            string str = Console.ReadLine();

            Dictionary<string, int> frequency = Frequency(str);
            foreach (string word in frequency.Keys)
            {
                Console.WriteLine(word + " - Встречается " + frequency[word] + " раз(а)");
            }
            Console.ReadKey();

        }
    }
}
