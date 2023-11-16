using System.ComponentModel.DataAnnotations;

namespace Blogs.API.Models.Base;

public class BaseEntity
{
    public BaseEntity()
    {
        Id = new Guid();
    }

    [Key]
    public Guid Id { get; set; }
    // public DateTime Created_Date { get; set; }
    // public DateTime? Modified_Date { get; set; }
}