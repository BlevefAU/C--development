using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_data;
            int sid;
            int b_y;
            int b_m;
            int b_d;
            string birth;



            Console.Write("Please enter the student ID:");
            input_data = Console.ReadLine();

            while (!int.TryParse(input_data, out sid) || 8 > input_data.Length || input_data.Length > 9)
            {
                if (!int.TryParse(input_data, out sid))
                {
                    Console.WriteLine("Please enter the interge");
                }
                else if (8 > input_data.Length || input_data.Length > 9)
                {
                    Console.WriteLine("Please enter the interge between 8 - 9 length");
                }
                else
                {
                    sid = Int32.Parse(input_data);
                }
                Console.Write("Please enter the student ID:");
                input_data = Console.ReadLine();
            }



            Console.Write("Please enter the year of birth:");
            input_data = Console.ReadLine();

            while (!int.TryParse(input_data, out b_y) || (DateTime.Now.Year - 100) > Int32.Parse(input_data) || (DateTime.Now.Year - 17) < Int32.Parse(input_data)) {
                if (!int.TryParse(input_data, out b_y))
                {
                    Console.WriteLine("Please enter the interge");
                }
                else if ((DateTime.Now.Year - 100) > Int32.Parse(input_data) || (DateTime.Now.Year - 17) < Int32.Parse(input_data))
                {
                    Console.WriteLine("Please enter right year of birth");
                }
                else
                {
                    b_y = Int32.Parse(input_data);
                }
                Console.Write("Please enter the year of birth:");
                input_data = Console.ReadLine();
            }


            Console.Write("Please enter the month of birth:");
            input_data = Console.ReadLine();

            while (!int.TryParse(input_data, out b_m) || 0 > Int32.Parse(input_data) || 12 < Int32.Parse(input_data))
            {
                if (!int.TryParse(input_data, out b_m))
                {
                    Console.WriteLine("Please enter the interge");
                }
                else if (0 > Int32.Parse(input_data) || 12 < Int32.Parse(input_data))
                {
                    Console.WriteLine("Please enter right month of birth");
                }
                else
                {
                    b_m = Int32.Parse(input_data);
                }
                Console.Write("Please enter the month of birth:");
                input_data = Console.ReadLine();
            }


            Console.Write("Please enter the day of birth:");
            input_data = Console.ReadLine();
            if (b_m != 2)
            {
                while (!int.TryParse(input_data, out b_d) || 0 > Int32.Parse(input_data) || 31 < Int32.Parse(input_data))
                {
                    if (!int.TryParse(input_data, out b_d))
                    {
                        Console.WriteLine("Please enter the interge");
                    }
                    else if (0 > Int32.Parse(input_data) || 31 < Int32.Parse(input_data))
                    {
                        Console.WriteLine("Please enter right day of birth");
                    }
                    else
                    {
                        b_d = Int32.Parse(input_data);
                    }
                    Console.Write("Please enter the day of birth:");
                    input_data = Console.ReadLine();
                }
            } else
            {
                while (!int.TryParse(input_data, out b_d) || 0 > Int32.Parse(input_data) || 29 < Int32.Parse(input_data))
                {
                    if (!int.TryParse(input_data, out b_d))
                    {
                        Console.WriteLine("Please enter the interge");
                    }
                    else if (0 > Int32.Parse(input_data) || 29 < Int32.Parse(input_data))
                    {
                        Console.WriteLine("Please enter right day of birth");
                    }
                    else
                    {
                        b_d = Int32.Parse(input_data);
                    }
                    Console.Write("Please enter the day of birth:");
                    input_data = Console.ReadLine();
                }
            }

            Console.WriteLine("Validated data:");
            Console.WriteLine("Student ID:" + sid);
            Console.WriteLine("Birth Date:" + b_d + "/" + b_m + "/" + b_y);
        }

    }
}
