using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryBook lb = new LibraryBook();
            lb.createobject();
            Console.WriteLine("Create success!");
        }
    }

    class LibraryBook
    {
        string author = "No Name";
        string title = "Null";
        string call_number = "Null";

        public void createobject ()
        {
            Console.WriteLine("Create A New Object for LibraryBook");
            Console.Write("Author:");
            author = Console.ReadLine();
            Console.Write("Title:");
            title = Console.ReadLine();
            Console.Write("Call Number:");
            call_number = Console.ReadLine();

        }
    }
}
