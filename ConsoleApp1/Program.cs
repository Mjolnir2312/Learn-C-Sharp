using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrayld ar = new Arrayld();
            int n;
            Console.Write("Enter n: ");
            n = Int32.Parse(Console.ReadLine());

            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];

            Console.WriteLine("Enter elements of array a: ");
            ar.Input(a,n);
            Console.WriteLine("Enter elements of array b: ");
            ar.Input(b, n);

            ar.Sum(a, b, c, n);

            Console.WriteLine("\nAll of array !!!");
            Console.WriteLine("Array A : ");
            ar.Show(a, n);
            Console.WriteLine("\nArray B : ");
            ar.Show(b, n);
            Console.WriteLine("\nArray A + B = C : ");
            ar.Show(c, n);
            Console.ReadLine();
        }
    }

    
        
}
