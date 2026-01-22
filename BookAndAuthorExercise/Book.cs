using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Literature //BookAndAuthorExercise
{
    internal class Book
    {
        private string name;
        private string author;
        public string publisher;
        private double price;
        public static string theme = "default";
        private string? isbn;        
        private const double discount = 0.9;
        
        //length of isbn and 978 prefix
        private const int MaxLength = 13;
        private const string Prefix = "978";


        public Book()
        {
            this.name = String.Empty;
            this.author = String.Empty;
            this.publisher = String.Empty;
            this.price = 0;
            this.isbn = String.Empty;
        }

        public Book(string author, string publisher, string name, double price, string isbn)
        {
            this.author = author;
            this.publisher = publisher;
            Name = name;
            Price = price;
            Isbn = isbn;
        }

        
        public string? Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value?.Length >= 1)
                {
                    name = value;
                }
            }
        }

        /*public string Author 
        { 
            get => author; set => author = value;  this also works, easier to change the previous one 
        }
        */

        public string? Isbn  //Isbn method, didnt work without it for some reason
        {
            get => isbn;
            set
            {
                if (value != null &&
                    value.Length == MaxLength &&
                    value.StartsWith(Prefix))
                {
                    isbn = value;
                }
            }
        }
        public double Price
        {
            get => price;
            set
            {
                if (value > 30)
                {
                    price = value * discount;
                }
                else
                {
                    price = value;
                }

            }
        }

        public string Author //readonly property
        {
            get => author;
        }

        public override string ToString()
        {
            return $"Author: {this.author}, Name: {this.name}, Publisher: {this.publisher}, Price: {this.price:F2}, ISBN: {this.isbn}, Theme: {theme}";
        }

        public string GetBookDetails(string isbnNumber)
        {
            if (this.isbn == isbnNumber)
            {
                return ToString();
            }
            else
            {
                return "Book information can't be printed.";
            }
        }

        /*public static void ChangeTheme()  //Changing the theme
        {
            Console.WriteLine("Give a theme: ");
            string? input = Console.ReadLine();
            if (input !=  null)
            {
                theme = input;
            }
        }
        */
    }



}
