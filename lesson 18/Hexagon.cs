using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_18
{
    //В класі Hexagon метод Draw() предопределеяється 
    class Hexagon: Sharpe
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name){ }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }
    }
}
