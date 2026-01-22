using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAndAuthorExercise
{
    internal class Author
    {
        public string name;
        public string birthday;
        private Book book;

        public Author(string name, string birthday, Book book)
        {
            this.name = name;
            this.birthday = birthday;
            this.Book = book;
        }

        public Author(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
            this.book = null;
        }

        internal Book Book
        {
            get
            {
                return book;
            }

            set
            {
                book = value;
            }

        }

        public void PrintInformation()
        {
            Console.WriteLine($"Author : {name}");
            Console.WriteLine($"Birthday : {birthday}");

            if (book != null)
            {
                Console.WriteLine(book.ToString());
            }
            else
            {
                Console.WriteLine("No information available.");
            }
        }

        
    }
}
