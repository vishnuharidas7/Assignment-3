using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_Assignments
{
    internal class D3_Q5_Book
    {
        public int bookNo;
        public string bookTitle;
        public float price;

        public void Input()
        {
            Console.Write("Enter Book No: ");
            bookNo = int.Parse(Console.ReadLine());
            Console.Write("Enter Book Title: ");
            bookTitle = Console.ReadLine();
            Console.Write("Enter Price: ");
            price = int.Parse(Console.ReadLine());
        }

        public float TotalCost(int n)
        {
            return price * n;
        }

        public void Purchase()
        {
            Console.Write("Enter the number of copies to be purchased: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Total cost to be paid: {0}", TotalCost(n));
        }

        public void Display()
        {
            Console.WriteLine("Book No: {0}", bookNo);
            Console.WriteLine("Book Title: {0}", bookTitle);
            Console.WriteLine("Price: {0}", price);
        }

        static void Main(string[] args)
        {
            D3_Q5_Book b = new D3_Q5_Book();
            b.Input();
            b.Purchase();
            b.Display();
        }


    }
}
