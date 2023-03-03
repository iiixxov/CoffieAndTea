﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i02_1_TemplateMethod
{
    abstract class CafiineBevarage
    {
        public virtual void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            addCondiment();
        } 

        public abstract void brew();

        public abstract void addCondiment();
        
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
