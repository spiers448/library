
using library;
class Program
{
    static void Main(string[] args)
    {
        //create new book object
        Book book = new Book("C# for beginners", "Bill Gates", 12345678);

        //create 2nd book
        Book book2 = new Book("C# Methods and classes", "Microsoft", 987654321);

        //output book information
        book.displayInfo();
        book2.displayInfo();

        //create members
        Member member = new Member(1, "John Smith", "1 High Street", 0790090090);
        Member member2 = new Member(2, "Mary Jones", "102 Garden Street", 0790345666);

        //output member information 
        member.displayInfo();
        member2.displayInfo();
    }
}