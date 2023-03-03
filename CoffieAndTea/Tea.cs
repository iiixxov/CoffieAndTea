using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i02_1_TemplateMethod
{

    class Tea : CafiineBevarage
    {
        public override void addCondiment()
        {
            Console.WriteLine("Adding lemon");
        }

        public override void brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}
