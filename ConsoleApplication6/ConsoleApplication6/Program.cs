using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_data;
            // double[] num_ar = new double[10];
            List<double> num_ar = new List<double>();
            double num;
            double num_average;
            double result = 0;

            // get input_data 
            Console.Write("Please enter a numeric value or END to finish:");
            input_data = Console.ReadLine();

            // check if input is "END"
            if (input_data == "END")
            {
                Console.WriteLine("You have not input any data.");
            } else
            {
                // check if first time iput is double or not
                if (!double.TryParse(input_data, out num) && input_data != "END")
                {
                    Console.WriteLine("Please input a double");
                } else
                {
                    num_ar.Add(num);
                }
                while (input_data != "END")
                {
                    Console.Write("Please enter a numeric value or END to finish:");
                    input_data = Console.ReadLine();
                    if (!double.TryParse(input_data, out num) && input_data != "END")
                    {
                        Console.WriteLine("Please input a double");
                    }
                    else if (input_data == "END")
                    {
                    }
                    else
                    {
                        num_ar.Add(num);
                    }
         
                }
                num_average = num_ar.Sum() / num_ar.Count;
                // Console.WriteLine(num_average);

   
                for (var i = 0; i < num_ar.Count; i ++)
                {
                    result += Math.Pow(num_ar[i] - num_average, 2);
                }

                result = result / (num_ar.Count - 1);
                result = Math.Sqrt(result);
                Console.WriteLine("The standard deviation of the entered numbers is " + result);
            }
       

        }
    }

}
