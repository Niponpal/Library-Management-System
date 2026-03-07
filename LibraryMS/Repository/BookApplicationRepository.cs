using LibraryMS.Data;
using LibraryMS.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryMS.Repository
{
    public class BookApplicationRepository: IBookApplicationRepository
    {
        private readonly ApplicationDbContext _context;

        public BookApplicationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<BookApplication> AddBookApplicationAsync(BookApplication bookApplication, CancellationToken cancellationToken)
        {
            await _context.BookApplications.AddAsync(bookApplication, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return bookApplication;
        }

        public async Task<BookApplication> DeleteBookApplicationAsync(int id, CancellationToken cancellationToken)
        {
            var data = await _context.BookApplications.FindAsync(id);
            if (data != null)
            {
                _context.BookApplications.Remove(data);
                await _context.SaveChangesAsync(cancellationToken);
                return data;
            }
            return null!;
        }


        public async Task<IEnumerable<BookApplication>> GetAllBookApplicationAsync(CancellationToken cancellationToken)
        {
            var data = await _context.BookApplications.ToListAsync(cancellationToken);
            if (data != null)
            {
                return data;
            }
            return null;
        }

        public async Task<BookApplication> GetBookApplicationByIdAsync(int id, CancellationToken cancellationToken)
        {
            var data = await _context.BookApplications.FindAsync(id);
            if (data != null)
            {
                return data;
            }
            return null!;
        }


        public async Task<BookApplication> UpdateBookApplicationAsync(BookApplication bookApplication, CancellationToken cancellationToken)
        {
            var data = await _context.BookApplications.FindAsync(bookApplication.Id);
            if (data != null)
            {
                data.StudentEmail = bookApplication.StudentEmail;
                data.StudentId = bookApplication.StudentId;
                data.StudentIdCardNo = bookApplication.StudentIdCardNo;
                data.Status = bookApplication.Status;
                data.FineAmount = bookApplication.FineAmount;
                data.IssueDate = bookApplication.IssueDate;
                data.ReturnDate = bookApplication.ReturnDate;
                //data.BookId = bookApplication.BookId;
                await _context.SaveChangesAsync(cancellationToken);
                return data;
            }
            return null!;
        }

    }
}
