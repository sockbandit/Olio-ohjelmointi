namespace BookAndAuthorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Mike",
                                  "SchoolBooks", 
                                  "Chemistry", 
                                  19.90, 
                                  "978-456-97845"); //Book details and ISBN
            
            Book book2 = new Book("Matt", 
                                  "SchoolBooks",
                                  "Physics",
                                  15.50, 
                                  "978-456-23456");

            Console.WriteLine(book1.GetBookDetails("978-456-97845"));
            Console.WriteLine(book2.GetBookDetails("978-456-23456"));
            Console.WriteLine();

            /*Book.ChangeTheme(); //Testing changing the theme
            Console.WriteLine(book1.GetBookDetails("978-456-97845"));
            */

            Book book3 = new Book("J. Sparrow", "SchoolBooks", "Pirates of the Caribbean", 35.90, "978-456-34567");
            Book book4 = new Book("T. Shakur", "SchoolBooks", "Rapping", 55.55, "978-456-45678");
            Author author1 = new Author("J. Sparrow", "09.06.1690", book3);
            Author author2 = new Author("M. Jackson", "01.01.1990");
            Author author3 = new Author("T. Shakur", "01.02.1979", book4);
           
            Console.WriteLine();    //Printing the books and author. author2 does not have a book, program prints No information.
            author1.PrintInformation();
            Console.WriteLine();
            author2.PrintInformation();
            Console.WriteLine();
            author3.PrintInformation();
        }
    }
}
