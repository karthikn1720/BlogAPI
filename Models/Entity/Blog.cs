using Blogs.API.Models.Base;

namespace Blogs.API.Models.Entity;

public class Blog : BaseEntity
{
    public required string Name { get; set; }
    public required string Title { get; set; }
    public string? Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid UserId { get; set; }
    public User? User { get; set; }
}