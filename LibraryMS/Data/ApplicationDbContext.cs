using Microsoft.EntityFrameworkCore;

namespace LibraryMS.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Models.Book> Books { get; set; }
        public DbSet<Models.BookCategory> BookCategories { get; set; }
        public DbSet<Models.BookApplication> BookApplications { get; set; }
    }
}
