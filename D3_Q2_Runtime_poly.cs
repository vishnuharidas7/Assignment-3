using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class D3_Q2_Runtime_poly
    {

        public void Add(int a, int b)
        {
            Console.WriteLine("a + b = {0}", a + b);
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine("a + b + c = {0}", a + b + c);
        }
        public static void Main(string[] args)
        {
            D3_Q2_Runtime_poly c = new D3_Q2_Runtime_poly();
            c.Add(1, 2);
            c.Add(1, 2, 3);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
