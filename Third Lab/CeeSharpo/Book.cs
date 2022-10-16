internal class Book
{
    public string BookName { get; set; }
    public string BookAuthor { get; set; }
    public string BookID { get; set; }
    public string BookType { get; set; }
    public int BookCopy { get; set; }
    static int bookCounter;
    public Book()
    {
        Console.WriteLine("Def Book Cons");
    }
    public Book(string a, string b, string c, string d, int e)
    {
        this.BookName = a;
        this.BookAuthor = b;
        this.BookID = c;
        this.BookType = d;
        this.BookCopy = e;
        Console.WriteLine("Param Book Cons");
    }
    public void showInfo()
    {
        Console.WriteLine("Book Name: {0}", BookName);
        Console.WriteLine("Book Author: {0}", BookAuthor);
        Console.WriteLine("Book ID: {0}", BookID);
        Console.WriteLine("Book Type: {0}", BookType);
        Console.WriteLine("Book Copy: {0}", BookCopy);
    }
    public void addBookCopy(int x)
    {
        BookCopy += x;
    }
}