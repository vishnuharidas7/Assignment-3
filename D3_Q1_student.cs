using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class D3_Q1_student
    {
        public int id;
        public String name;
        public void read()
        {
            Console.WriteLine("Enter the ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the name");
            name = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("\n\nID:\t" + id);
            Console.WriteLine("Name:\t" + name);
        }

        public static void Main(string[] args)
        {
            D3_Q1_student s1 = new D3_Q1_student();
            s1.read();
            s1.display();
        }

    }
}
