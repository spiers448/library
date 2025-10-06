class Book
{
    string Title;
    string Author;
    int ISBN;

    void displayInfo()
    {
        //output book information
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}\n");
    }

    static void Main(string[] args)
    {
        //create new book object
        Book book = new Book();

        //book information
        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = 123456789;

        //create 2nd book
        Book book2 = new Book();

        //2nd book information
        book2.Title = "C# Methods and classes";
        book2.Author = "Microsoft";
        book2.ISBN = 987654321;
        
        //output book information
        book.displayInfo();
        book2.displayInfo();

    }
}