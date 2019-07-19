using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _2_8.Program;

namespace _2_8
{
    public abstract class Bonus
    {
        public abstract void Pick_Up();
    }
    public class Apple :Bonus, IPoint
        {

        int IPoint.x { get; set; }
        int IPoint.y { get; set; }

        public override void Pick_Up()
        {
            Console.WriteLine("You ate an apple! Now your speed will increase! ");
        }

    }
    public class Cherry :Bonus,IPoint
    {
        int IPoint.x { get; set; }
        int IPoint.y { get; set; }

        public override void Pick_Up()
        {
            Console.WriteLine("You ate a Cherry! Now your Health will increase! ");
        }
    }
    public class watermelon : Bonus, IPoint
    {
        int IPoint.x { get; set; }
        int IPoint.y { get; set; }

        public override void Pick_Up()
        {
            Console.WriteLine("You ate a watermelon! You have a chance to rise from the dead  "); // арбузик
        }
    }
}
