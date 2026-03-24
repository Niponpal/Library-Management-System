using LibraryMS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibraryMS.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBookAsync(CancellationToken cancellationToken);
        Task<Book> GetBookByIdAsync(long id, CancellationToken cancellationToken);
        Task<Book> AddBookAsync(Book book, CancellationToken cancellationToken);
        Task<Book> UpdateBookAsync(Book book, CancellationToken cancellationToken);
        Task<Book> DeleteBooktAsync(long id, CancellationToken cancellationToken);
        IEnumerable<SelectListItem> Dropdown();
    }
}
