using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Dog : Animal
    {
        public Dog(double weight)
        {
            Weight = weight;
        }

        public override string SaySound()
        {
            return "Wof-wof";
        }

        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Blue;
        }
    }
}
