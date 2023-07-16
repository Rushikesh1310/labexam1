namespace labexam1
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Console.WriteLine("Information of book 1:");
            Console.Write("Input name of the book: ");
            book1.Title = Console.ReadLine();
            Console.Write("Input the author: ");
            book1.Author = Console.ReadLine();

            Book book2 = new Book();
            Console.WriteLine("\nInformation of book 2:");
            Console.Write("Input name of the book: ");
            book2.Title = Console.ReadLine();
            Console.Write("Input the author: ");
            book2.Author = Console.ReadLine();

            Console.WriteLine("\nExpected Output:");
            Console.WriteLine($"1: Title = {book1.Title}, Author = {book1.Author}");
            Console.WriteLine($"2: Title = {book2.Title}, Author = {book2.Author}");
        }
    }

}