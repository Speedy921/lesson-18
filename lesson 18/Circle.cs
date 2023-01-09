using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_18
{
    //у классі Circle метод Draw() не переоределяється 
    class Circle: Sharpe
    {
        public Circle() { }
        public Circle(string Name): base(Name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }
    }

    

}
