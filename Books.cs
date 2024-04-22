public class Books{
    // attribut
    protected string name;
    protected string description;
    protected int bookID;
    protected string author;
    
    // konstruktor
    public Books(string name, string description, int bookID, string author)
    {
        this.name = name;
        this.description = description;
        this.bookID = bookID;
        this.author = author;
    }
}