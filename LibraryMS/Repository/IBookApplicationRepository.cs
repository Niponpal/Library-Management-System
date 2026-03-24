using LibraryMS.Models;

namespace LibraryMS.Repository
{
    public interface IBookApplicationRepository 
    {
        Task<IEnumerable<BookApplication>> GetAllBookApplicationAsync(CancellationToken cancellationToken);
        Task<BookApplication> GetBookApplicationByIdAsync(long id, CancellationToken cancellationToken);
        Task<BookApplication> AddBookApplicationAsync(BookApplication bookApplication, CancellationToken cancellationToken);
        Task<BookApplication> UpdateBookApplicationAsync(BookApplication bookApplication, CancellationToken cancellationToken);
        Task<BookApplication> DeleteBookApplicationAsync(long id, CancellationToken cancellationToken);
    }
}
