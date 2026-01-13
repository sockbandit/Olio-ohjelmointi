namespace BookEx.BookEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BookExercise");

            Book abcBook = new Book("Chemistry", "Mike Chemist", 10, "12313");
            abcBook.PrintBookInfo();

            Book mathBook = new Book();
            mathBook.title = "Math";
            mathBook.author = "Mikko Mallikas";
            mathBook.price = 15;
            mathBook.SetId("54321");
            mathBook.PrintBookInfo();
            abcBook.CompareBooks(mathBook);
            mathBook.CompareBooks(abcBook);
        }
    }
}
