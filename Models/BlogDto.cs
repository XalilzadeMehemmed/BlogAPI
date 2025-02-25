namespace BlogApi.Models;
public class BlogDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public string UserName { get; set; }
    public string PictureUrl { get; set; } 
    public DateTime CreationDate { get; set; }
    public int LikesCount { get; set; }
    public Guid UserId { get; set; }
}
