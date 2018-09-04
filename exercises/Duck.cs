using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    class Duck
    {
        public Duck()
        {
        }
        public void Speak()
        {
            Console.WriteLine("Quack");
        }
        public void Eat()
        {
            Console.WriteLine("Bread, please.");
        }
        public void Run()
        {
            Console.WriteLine("*Slap, slap, slap*");

        }
        public void Attack()
        {
            Console.WriteLine("*Uses bill attack*");
        }
    }
}
