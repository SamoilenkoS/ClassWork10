using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Cat : Animal
    {
        public Cat(double weight)
        {
            Weight = weight;
        }

        public override string SaySound()
        {
            return "Meow";
        }
    }
}
