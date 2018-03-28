using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input an number here:");
            string input_data;
            int num;
            int num_another;
            input_data = Console.ReadLine();
            if (!int.TryParse(input_data, out num))
            {
                Console.WriteLine("Please input an integer");

            } else
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        num_another = num / i;
                      Console.WriteLine(i + "*" + num_another + "=" + num );
                    }
                    continue;
              
                }
            }
            
        }
    }
}
