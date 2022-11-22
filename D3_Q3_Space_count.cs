
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class D3_Q3_Space_count
    {
        string str, str1;
        public void SpaceCount()
        {
            Console.Write("Please input a string : ");
            str = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                {
                    count++;
                }
            }
            Console.WriteLine("\n Total spaces:{0}\t", +count);
        }
        public static void Main(String[] args)
        {
            D3_Q3_Space_count n = new D3_Q3_Space_count();
            n.SpaceCount();
        }

    }
}
