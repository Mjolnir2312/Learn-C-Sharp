using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Cat
    {
        private int size;

        public void setSize(int s)
        {
            if (s > 0) size = s;
            else Console.WriteLine("You cant set size like this");
        }

        public int getSize()
        {
            return size;
        }

        public String name;
        public String breed;

        public Cat(int size, String name, String breed)
        {
            this.size = size;
            this.name = name;
            this.breed = breed;
        }

        public void immanent()
        {
            Console.WriteLine(name + " is a " + breed + "braks moew moew");
        }
    }
}
