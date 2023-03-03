using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i02_1_TemplateMethod
{
    abstract class CafiineBevarage
    {
        public abstract void prepareRecipe(); 
        
        public virtual void boilWater()
        {
            Console.WriteLine("Boiling water");
        }
        
        public virtual void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
