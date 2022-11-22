using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_Assignments
{
    internal class D3_Q7_FunByRef
    {
        public int id;
        public string name;
        public int mark;
        public void read()
        {
            Console.WriteLine("Enter the id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the mark");
            mark = int.Parse(Console.ReadLine());
        }
        public void swap(D3_Q7_FunByRef val, D3_Q7_FunByRef val2)
        {
            D3_Q7_FunByRef temp = new D3_Q7_FunByRef();
            temp = val;
            val = val2;
            val2 = temp;
            Console.WriteLine("After Swapping");
            val.display();
            val2.display();
        }
        public void display()
        {
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Mark: {0}", mark);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            D3_Q7_FunByRef s1 = new D3_Q7_FunByRef();
            D3_Q7_FunByRef s2 = new D3_Q7_FunByRef();
            s1.read();
            s2.read();
            Console.WriteLine("Before Swapping");
            s1.display();
            s2.display();
            s1.swap(s1, s2);

            Console.ReadLine();
        }

    }
}
