using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    class Program
    {
        class Player
        {
            public int serial_number
            {
                get;
            }
            public Player(int serial_number)
            {
                this.serial_number = serial_number;
            }
        }
        static void CreatingList(List<Player> players,int n )
        {
            for (int i = 0; i < n; i++)
            {
                players.Add(new Player(i + 1));
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Введите количетво игроков N = ");
            int N = int.Parse(Console.ReadLine());

            List<Player> players = new List<Player>(N);
            CreatingList(players, N);
            for (int j = 1; j < N + 1 ; j++)
                Console.Write("  " + j);
            Console.WriteLine();
            int count = 1;
            int i = 0;
            while (players.Count != 1)
            {
                if (count == 2)
                {
                    Console.WriteLine("Удален игрок под номером " + players[i].serial_number);
                    players.RemoveAt(i);
                    count = 1;
                    i--;
                }
                else count++;
                if (i == players.Count-1)
                {
                    i = 0;
                }
                else i++;
                
            }
            Console.WriteLine();
            Console.WriteLine("Выйграл игрок с номером "+ players[0].serial_number);
            Console.ReadKey();
        }


    }
}
