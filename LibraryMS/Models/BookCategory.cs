using LibraryMS.BaseEntities;

namespace LibraryMS.Models;

public class BookCategory: BaseEntity
{
    public Guid Id { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<Book>? Books { get; set; } 
}
