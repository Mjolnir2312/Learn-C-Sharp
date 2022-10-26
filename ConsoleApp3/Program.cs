using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter numbers of member n = ");
            n = Int32.Parse(Console.ReadLine());
            Person []p = new Person[n];
            {
                for (int i = 0; i < n; i++)
                {
                    p[i] = new Person();
                    p[i].input();
                }
            }

            //p.input();
            for (int i = 0; i < n; i++)
            {
                p[i].show();
            }
            //p.show();
            Console.ReadLine();
        }
    }
}
