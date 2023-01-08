using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_18
{
    //абстрактний базовий класс іерархії
    abstract class Sharpe
    {
        protected Sharpe(string name = "NoName")
        { PetName = name; }
        public string PetName { get; set; }
        //Единий віртуальний метод
        public  virtual void Draw()
        {
            Console.WriteLine("Inside Sharpe.Draw()");
        }
    }
}
