using Blogs.API.Models.Base;

namespace Blogs.API.Models.Entity;
public class User : BaseEntity
{
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required string Name { get; set; }
    public ICollection<Blog> Blog { get; } = new List<Blog>();
}