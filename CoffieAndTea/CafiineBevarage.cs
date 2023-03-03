using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i02_1_TemplateMethod
{
    abstract class CafiineBevarage
    {
        public abstract void PrepareRecipe(); 
        
        public virtual void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        
        public virtual void PourlnCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
