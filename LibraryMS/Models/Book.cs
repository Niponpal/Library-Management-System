using LibraryMS.BaseEntities;

namespace LibraryMS.Models;

public class Book: BaseEntity
{
 
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int TotalCopies { get; set; }
    public int AvailableCopies { get; set; }

    public long CategoryId { get; set; }
    public BookCategory? bookCategory { get; set; }
    public ICollection<BookApplication> BookApplications { get; set; }
}
