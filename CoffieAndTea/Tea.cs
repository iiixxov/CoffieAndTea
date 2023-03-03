using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i02_1_TemplateMethod
{

    class Tea : CafiineBevarage
    {
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

        private void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        private void steepTeaBag()
        {
            Console.WriteLine("Steeping the tea");
        }

    }
}
