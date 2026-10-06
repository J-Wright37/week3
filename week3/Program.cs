using week3;


class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("C# for Beginners", "Bill Gates", "1234567");
        
        Console.WriteLine("Current library books:");
        book.DisplayInfo();



        Member member = new Member(1, "John Smith", "1 High St", "0790090090");
        Member member1 = new Member(2, "Jane Doe", "2 Low St", "0790090091"); 
        Member invalidmember = new Member(-5, "3 mice in a trenchcoat", "my house", "5"); // This will throw an exception

        Console.WriteLine("Current library members:");
        member.DisplayInfo();
        member1.DisplayInfo();
        invalidmember.DisplayInfo();
    }
}

