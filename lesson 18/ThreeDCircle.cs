using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_18
{
    class ThreeDCircle: Circle
    {
        //сховати свойство PetName, котре вище у ієрархії
        public new string PetName { get; set; }

        //сховати будь-яку реалізацію Draw(), що знаходится вище у ієрархії
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
    }
}
