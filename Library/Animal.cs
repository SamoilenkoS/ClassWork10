using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public abstract class Animal
    {
        public double Weight { get; protected set; }

        public abstract string SaySound();

        public virtual ConsoleColor GetColor()
        {
            return ConsoleColor.Black;
        }
    }
}
