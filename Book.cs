public class Book
{
    public string Title { get; set; }
    public List<string> Authros { get; set; }
    public DateTime PublicationDate { get; set; }
}

// Adding Random Calculator Commit to test Visual Studio Multiple branch commit rather than expand Book
public int Add(int left, int right)
{
    return left + right;
}
public int Subtract(int left, int right)
{
    return left - right;
}