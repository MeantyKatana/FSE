namespace DefaultNamespace;

public interface IBookBuilder
{
    void BuildTitle();
    void BuildAuthor();
    void BuildGenre();
    void BuildYear();
    Book GetBook();
}

public class ConcreteBookBuilder : IBookBuilder
{
    private Book book = new Book();

    public void BuildTitle()
    {
        book.Title = "Fierdur";
    }

    public void BuildAuthor()
    {
        book.Author = "Nestor Litopysec";
    }

    public void BuildGenre()
    {
        book.Genre = "Roman";
    }

    public void BuildYear()
    {
        book.Year = 1254;
    }

    public Book GetBook()
    {
        return book;
    }
}

public class BookDirector
{
    private IBookBuilder bookBuilder;
    public BookDirector(IBookBuilder builder)
    {
        bookBuilder = builder;
    }

    public void Construct()
    {
        bookBuilder.BuildTitle();
        bookBuilder.BuildAuthor();
        bookBuilder.BuildGenre();
        bookBuilder.BuildYear();
    }
}

class Program
{
    static void Main()
    {
        IBookBuilder builder = new ConcreteBookBuilder();
        BookDirector director = new BookDirector(builder);
        director.Construct();
        Book book = builder.GetBook();
        Console.WriteLine(book);
    }
}