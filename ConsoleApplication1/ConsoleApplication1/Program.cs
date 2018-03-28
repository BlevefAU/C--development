using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input the income (must be integer):");
            String input_data = Console.ReadLine();
            int tax = 0;
            if (!int.TryParse(input_data, out tax))
            {
                Console.WriteLine("Please input a number");
            } else
            {
                if (0 <= tax && tax <= 6000)
                {
                    Console.WriteLine("Nil");
                } else if (0 < tax && tax <= 37000)
                {
                    Console.WriteLine("15c for each $1 over $6,000");
                } else if (0 < tax && tax <= 80000)
                {
                    Console.WriteLine("$4,650 plus 30c for each $1 over $37,000");
                } else if (0 < tax && tax <= 180000)
                {
                    Console.WriteLine("$17,550 plus 37c for each $1 over $80,000");
                } else if (0 < tax && tax > 180000)
                {
                    Console.WriteLine("$54,550 plus 45c for each $1 over $180,000");
                } else
                {
                    Console.WriteLine("You input a wrong integer");

                }
            }
          // end
        }
    }
}
