using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Scientist s1 = new Scientist();
            Console.WriteLine("A Scientist: ");
            s1.Input();
            Console.WriteLine("");
            s1.Show();

            Console.WriteLine("\nA Manager: ");
            Manager m1 = new Manager();
            m1.Input();
            Console.WriteLine("");
            m1.Show();

            Worker w1 = new Worker();
            Console.WriteLine("\nA Worker: ");
            w1.Input();
            Console.WriteLine("");
            w1.Show();

            Console.ReadLine();
        }
    }
}
