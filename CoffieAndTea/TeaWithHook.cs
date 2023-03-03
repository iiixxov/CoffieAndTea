using i02_1_TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i02_1_TemplateMethod
{
    class TeaWithHook : CaffiineBeverageWithHook
    {
            public override void addCondiment()
            {
                Console.WriteLine("Adding lemon");
            }

            public override void brew()
            {
                Console.WriteLine("Steeping the tea");
            }

            public override bool customerWantsCondiments()
            {
                Console.WriteLine("Would you like lemon with your tea (y/n)? ");
                return Console.ReadLine() == "y";
            }
        }
}
