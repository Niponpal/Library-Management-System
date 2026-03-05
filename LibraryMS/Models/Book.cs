namespace LibraryMS.Models
{
    public class Book
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }

        public int CategoryId { get; set; }
        public BookCategory? bookCategory { get; set; }
        public ICollection<BookApplication> BookApplications { get; set; }
    }
}
