using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i02_1_TemplateMethod
{

    class Tea : CafiineBevarage
    {

        public override void prepareRecipe()
        {
            boilWater();
            steepTeaBag();
            pourInCup();
            addLemon();
        }

        private void addLemon()
        {
            Console.WriteLine("Adding lemon");
        }

        private void steepTeaBag()
        {
            Console.WriteLine("Steeping the tea");
        }


    }
}
