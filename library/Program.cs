
using library;
class Program
{
    static void Main(string[] args)
    {
        //create lists
        List<Book> books = new List<Book>();
        List<Member> members = new List<Member>();

        //create new book objects for list
        books.Add(new Book("C# for beginners", "Bill Gates", 12345678));
        books.Add(new Book("C# Methods and classes", "Microsoft", 987654321));

        //create new member objects for list
        members.Add(new Member(1, "John Smith", "1 High Street", 0790090090));
        members.Add(new Member(2, "Mary Jones", "102 Garden Street", 0790345666));

        //display members in members list
        foreach (Member Member in members)
        {
            Member.displayInfo();
        }

        //display books in books list
        foreach (Book Book in books)
        {
            Book.displayInfo();
        }
    }
}