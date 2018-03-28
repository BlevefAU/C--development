using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Book first_book = new Book();
            Book second_book = new Book();
            order first_order = new order();
            order second_order = new order();
            order third_order = new order();
            Program run_program = new Program();

            first_book.init_book("Deitel,P.J and Deitel,H.M.", "Visual C# 2012: How to Program", "Prentice-Hall", 2014);
            second_book.init_book("Schildt,H", "C# 4.0: The Complete Reference", "McGraw-Hill,", 2010);

            // use default set up customer name as unknow function and add function
            first_order.customer_create(null);
            first_order.Add(first_book);

            // use add function and create customer function
            second_order.customer_create("Bleve");
            second_order.Add(first_book);
            second_order.Add(second_book);

            // use copy function and create customer function
            third_order.customer_create("Bleve");
            third_order.copy_list(second_order);

            run_program.DisplayOrder(first_order);
            run_program.DisplayOrder(second_order);
            run_program.DisplayOrder(third_order);


        }

        public void DisplayOrder (order display_order)
        {
            Console.Write(display_order.ToString());
            foreach (var data in display_order.Books)
            {
                Console.Write("\n-- " + data.ToString() + "\n");
            }
        }
    }

    class Book
    {
        private string _Authors;
        public string Authors {
            get
            {
                return _Authors;
            }
        }
        private string _Title;
        public string Title
        {
            get
            {
                return _Title;
            }
        }
        private string _Publisher;
        public string Publisher
        {
            get
            {
                return _Publisher;
            }
        }
        private int _Year;
        public int Year
        {
            get
            {
                return _Year;
            }
        }

        // inti book
        public void init_book (string author, string title, string publisher, int year)
        {
            _Authors = author;
            _Title = title;
            _Publisher = publisher;
            _Year = year;
           // Console.Write("Please enter the Author of book:");
           // _Authors = Console.ReadLine();
           //Console.Write("Please enter the Title of book:");
           // _Title = Console.ReadLine();
           // Console.Write("Please enter the Publisher of book:");
           //  _Publisher = Console.ReadLine();

            // check year if it is integer
            //  Console.Write("Please enter the Year of book:");
            // _Year_Input = Console.ReadLine();
            //  while (!int.TryParse(_Year_Input, out _Year))
            //  {
            //     Console.Write("Please enter a integer for year.");
            //     Console.Write("Please enter the Year of book:");
            //   _Year_Input = Console.ReadLine();
            //}
        }

        public override string ToString()
        {
            return "Author: " + Authors + ",Title: " + Title + ",Publisher: " + Publisher + ",Year: " + Year;
        }

    }

    class order
    {
        private const string DEFAULT_CUSTOMER = "UNKNOWN";
        private string _Customer;
        public string Customer
        {
            get
            {
                return _Customer;
            }
        }

        private List<Book> _Books;

        public ReadOnlyCollection<Book> Books
        {
            get { return _Books.AsReadOnly(); }
        }

        // create customer
        public void customer_create(string customer)
        {
            if (customer != null)
            {
                _Customer = customer;
            }
            _Books = new List<Book>();
            
        }

        // define constructor
        public order ()
        {
            _Customer = DEFAULT_CUSTOMER;
        }

        public List<Book> copy_list(order new_obj)
        {
            _Books = new List<Book>(new_obj.Books);
            return _Books;
        }

        public void Add (Book new_book)
        {
            _Books.Add(new_book);
        }

        public override string ToString()
        {
            return "Order for " + Customer + " containing " + _Books.Count + " books";

        }



    }
}
