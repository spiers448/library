
using library;

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