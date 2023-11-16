
using Microsoft.EntityFrameworkCore;

namespace Blogs.API.Models.Entity;

public class BlogAppContext : DbContext
{
    public BlogAppContext(DbContextOptions<BlogAppContext> options) : base(options)
    {
    }

    public DbSet<Blog> Blogs { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
}