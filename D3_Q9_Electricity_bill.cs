using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class D3_Q9_Electricity_bill
    {
        class consumer
        {
            private string name;
            private int id;
            public void read()
            {
                Console.WriteLine("Enter Consumer ID:");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Consumer Name:");
                name = Console.ReadLine();
            }
            public void display()
            {
                Console.WriteLine("\n\n\t<---Consumer Details--->");
                Console.WriteLine("\n\tConsumer ID:\t" + id);
                Console.WriteLine("\tConsumer Name:\t" + name);
            }
        }

        class consumption : consumer
        {
            private int unit_prev, unit_curr;
            protected int unit_consumed;

            public void con_read()
            {
                Console.WriteLine("Enter previous unit:");
                unit_prev = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter current unit:");
                unit_curr = Convert.ToInt32(Console.ReadLine());
            }
            public void calculate()
            {
                unit_consumed = unit_curr - unit_prev;
            }
            public void con_display()
            {
                Console.WriteLine("\n\n\t<---Bill Details--->");
                Console.WriteLine("\n\tPrevious Unit:\t" + unit_prev);
                Console.WriteLine("\tCurrent Unit:\t" + unit_curr);
                Console.WriteLine("\tConsumed Unit:\t" + unit_consumed);
            }
        }

        class Bill : consumption
        {
            private double amount;
            public void total()
            {
                amount = unit_consumed * .5;
                Console.WriteLine("\tTotal Amount:\t" + amount);
            }
        }
        public static void Main(string[] args)
        {
            Bill bill = new Bill();
            bill.read();
            bill.con_read();
            bill.calculate();
            bill.display();
            bill.con_display();
            bill.total();
        }

    }
}
