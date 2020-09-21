using System;
using System.Collections.Generic;
using System.Text;

namespace Animalvsinterface
{
    class Chicken : Animal, Edible
    {
        public override string MakeShound()
        {
            return "Chicken:cluck-cluck";
        }
        public string HowToEat()
        {
            return "could be fried";
        }

        
    }
}
