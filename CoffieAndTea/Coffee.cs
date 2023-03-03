using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i02_1_TemplateMethod
{
    class Coffee : CafiineBevarage
    {
        public override void prepareRecipe()
        {
            boilWater();
            brewCoffeeGrinds();
            pourInCup();
            addSugarAndMilk();
        }

        private void addSugarAndMilk()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        private void brewCoffeeGrinds()
        {
            Console.WriteLine("Dripping coffee through filter");
        }
    }
}
