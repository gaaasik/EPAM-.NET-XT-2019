using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _2_8.Program;

namespace _2_8
{
    class Player : Bonus,IPoint, IGo
    {
        int IPoint.x { get; set; }
        int IPoint.y { get; set; }

        public void Go_Back()
        {
            
        }

        public void Go_Forward()
        {
           
        }

        public void Go_Left()
        {
           
        }

        public void Go_Right()
        {
            
        }

        public override void Pick_Up()
        {
           Console.WriteLine("You Pick up bonus!");
        }
    }
    class Program
    {
        public interface IPoint
        {
            int x { get; set; }
            int y { get; set; }
        }
        public interface IGo
        {
            void Go_Left();// идем в лево
            void Go_Right();
            void Go_Forward(); // идти вперед
            void Go_Back();
        }

        static void Main(string[] args)
        {
            
        }
    }
}
