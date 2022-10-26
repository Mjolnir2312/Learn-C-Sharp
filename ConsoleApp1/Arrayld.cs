using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Arrayld
    {
        public void Input(int []a, int n )
        {
            for (int i = 0; i < n; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public void Sum(int []a, int []b, int []c, int n)
        {
            for (int i = 0; i < n; i++)
            {
                c[i] = a[i] + b[i];
            }
        }

        public void Show(int []a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + a[i]);
            }
        }
    }
}
