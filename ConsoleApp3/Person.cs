using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Person
    {
        private String name;
        private int age;
        private double salary;

        public Person()
        {
            name = " ";
            age = 0;
            salary = 0;
        }

        public void input()
        {
            Console.Write("Enter name : ");
            name = Console.ReadLine();

            Console.Write("Enter age : ");
            age = Int32.Parse(Console.ReadLine());

            Console.Write("Enter salary : ");
            salary = Double.Parse(Console.ReadLine());
        }

        //public Person(String name, int age, double salary)
        //{
        //    this.name = name;
        //    this.age = age;
        //    this.salary = salary;
        //}

        public void show()
        {
            Console.WriteLine("Name: " + name +"; age : " + age + "; salary: " + salary); 
        }
    }
}
