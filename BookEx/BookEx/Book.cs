using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEx.BookEx
{
    internal class Book
    {
        public string title;
        public string author;
        public double price;
        public string id;


        public Book()
        {
            title = string.Empty;
            author = string.Empty;
            price = 0;
            id = string.Empty;
        }

        public Book(string title, string author, double price, string id)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            SetId(id);
        }

        public void PrintBookInfo()
        {
            Console.WriteLine($"{author} : {title} : {price} : {id}");
        }
        public void SetId(string idvalue)
        {
            if (idvalue.Length == 5)
            {
                id = idvalue;
            }
            else
            {
                id = " ";
            }
        }

        public void CompareBooks(Book book)
        {
            if (price > book.price)
            { Console.WriteLine(title + " is more expensive than " + book.title); }
            else if (price == book.price)
            { Console.WriteLine(title + " is equal priced to " + book.title); }
            else
            { Console.WriteLine(title + " is cheaper than " + book.title); }


        }
    }
}
