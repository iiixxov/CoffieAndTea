using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i02_1_TemplateMethod
{
    class CoffieWithHook : CaffiineBeverageWithHook
    {
        public override void addCondiment()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override void brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        public override bool customerWantsCondiments()
        {
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");
            return Console.ReadLine() == "y";
        }
    }
}
