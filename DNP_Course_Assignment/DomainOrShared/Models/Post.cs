namespace DomainOrShared.Models;

public class Post
{
    public int Id { get; set; }
    public User Author { get; private set; }
    public string Title { get; private set; }
    public string Body { get; set; }

    public Post(User author, string title, string body)
    {
        Author = author;
        Title = title;
        Body = body;
    }

    private Post(){}
}