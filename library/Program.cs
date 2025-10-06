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

    public Book(string bookTitle, string bookAuthor, int bookISBN)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
    }

    static void Main(string[] args)
    {
        //create new book object
        Book book = new Book("C# for beginners", "Bill Gates", 12345678);

        //create 2nd book
        Book book2 = new Book("C# Methods and classes", "Microsoft", 987654321);

        //output book information
        book.displayInfo();
        book2.displayInfo();

    }
}