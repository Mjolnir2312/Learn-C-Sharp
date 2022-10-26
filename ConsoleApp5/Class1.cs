using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    interface IAnimal
    {
        void animalSound();
    }
    class Dog
    {
        public void animalSound()
        {
            Console.WriteLine("The dog says : go go");
        }
    }
}
