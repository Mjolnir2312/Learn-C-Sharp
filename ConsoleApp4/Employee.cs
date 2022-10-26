using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Employee
    {
        private int ID;
        private string name;

        public Employee()
        {
            ID = 0;
            name = " ";
        }
        public void Input()
        {
            Console.Write("Enter ID : ");
            ID = Int32.Parse(Console.ReadLine());
            Console.Write("Enter name : ");
            name = Console.ReadLine();
        }

        public void Show()
        {
            Console.Write("ID: " + ID);
            Console.WriteLine("; Ten: " + name);
        }
    }

    class Scientist: Employee
    {
        private int pub;
        
        public Scientist(): base()
        {
            pub = 0;
        }

        public new void Input()
        {
            base.Input();
            Console.Write("Enter the Scientist: ");
            pub = Int32.Parse(Console.ReadLine());
        }
        
        public new void Show()
        {
            base.Show();
            Console.WriteLine("Scientific: " + pub);
        }
    }
    
    class Manager: Employee
    {
        private string contract;
        public Manager():base()
        {
            contract = " ";
        }
        
        public new void Input()
        {
            base.Input();
            Console.Write("Enter the content of contract: ");
            contract = Console.ReadLine();
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine("Contract: " + contract);
        }
    }
    class Worker: Employee
    {

    }

}
