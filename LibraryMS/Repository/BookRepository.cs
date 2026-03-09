using LibraryMS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibraryMS.Repository;

public class BookRepository : IBookRepository
{
    public Task<Book> AddBookAsync(Book book, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Book> DeleteBooktAsync(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<SelectListItem> Dropdown()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Book>> GetAllBookAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Book> GetBookByIdAsync(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Book> UpdateBookAsync(Book book, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
