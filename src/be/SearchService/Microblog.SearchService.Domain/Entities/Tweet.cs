namespace Microblog.SearchService.Domain.Entities;

public sealed class Tweet
{
    public Tweet(
        Guid id,
        Guid userId,
        DateTime postDate,
        string message)
    {
        Id = id;
        UserId = userId;
        PostDate = postDate;
        Message = message;
    }

    public Guid Id { get; set; }
    
    public Guid UserId { get; set; }
    
    public DateTime PostDate { get; set; }
    
    public string Message { get; set; }
}
