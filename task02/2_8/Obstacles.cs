using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _2_8.Program;

namespace _2_8
{
   
    class Tree : DAMAGE, IPoint
    {
        public int x { get; set; }
        public int y { get; set; }

        public override void Damage()
        {
            Console.WriteLine("You crashed into a tree! You have lost your bonus! ");
        }
    }
    class Rock : DAMAGE, IPoint
    {
        public int x { get; set; }
        public int y { get; set; }

        public override void Damage()
        {
            Console.WriteLine("You hit a stone!You have lost your bonus!");
        }
    }
}
