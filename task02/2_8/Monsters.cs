using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static _2_8.Program;
using System.Threading.Tasks;
using _2_8;

namespace _2_8
{
    public abstract class DAMAGE
    {
        
        public abstract void Damage();
        
    }
    
}



class monster_wolf : DAMAGE, IGo, IPoint
{
    int IPoint.x { get; set; }
    int IPoint.y { get; set; }

    public override void Damage()
    {
        Console.WriteLine("You met the wolf you lost 10 point Heаlth");
    }
      
    
    public void Go_Back() { }
    public void Go_Forward() { }
    public void Go_Left() { }
    public void Go_Right() { }
}
class monster_Bear : DAMAGE, IGo, IPoint
{
    int IPoint.x { get; set; }
    int IPoint.y { get; set; }

    public override void Damage()
    {
        Console.WriteLine("You met the Bear you lost 30 point Heаlth");
    }


    public void Go_Back() { }
    public void Go_Forward() { }
    public void Go_Left() { }
    public void Go_Right() { }
}


