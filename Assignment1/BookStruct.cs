using System;
public enum BookType
{
    Magazine,
    Novel,
    ReferenceBook,
    Miscellaneous
}
public struct Books
{
    private int _id;
    private string _title;
    private int _price;
    private BookType _bookType;

    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public int Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public BookType bookType
    {
        get { return _bookType; }
        set { _bookType = value; }
    }

    public static void display(Books book)
    {
        Console.WriteLine("Book id : {0}" , book._id);
        Console.WriteLine("Book tile : {0}" , book._title);
        Console.WriteLine("Book price : {0}" , book._price);
        string type = getType(book.bookType);
        Console.WriteLine("Book type : {0}", type);

    }

    public static string getType(BookType bt)
    {
        switch (bt)
        {
            case BookType.Magazine: return "Magazine";
            case BookType.Novel: return "Novel";
            case BookType.ReferenceBook: return "ReferenceBook";
            case BookType.Miscellaneous: return "Miscellaneous";
            default: return "Inalid Book Type";
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the book id: ");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the book title: ");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the book price: ");
        int price = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose the book type: Magazine, Novel, ReferenceBook, Miscellaneous");
        string type = Console.ReadLine();
        
        Books book = new Books();

        book.ID = id;
        book.Title = title;
        book.Price = price;
        book.bookType = (BookType)Enum.Parse(typeof(BookType), type);

        Books.display(book);
    }
}