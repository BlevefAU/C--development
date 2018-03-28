using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
     
        static void Main(string[] args)
        {
            string input_data;
            int num;
            int num_sum;
            Console.Write("Please enter an integer value to sum up to:");
            input_data = Console.ReadLine();
            if (!int.TryParse(input_data, out num))
            {
                Console.WriteLine("Please input a integer");
            } else
            {
                Program obj = new Program();
                num_sum = obj.SumUpTo(num);
                Console.WriteLine("The sum of all numbers up to and including " + num + " is " + num_sum);
            }

        }
        public int SumUpTo(int num)
        {
            var sum = 0;
            for (var i = 0; i <= num; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
