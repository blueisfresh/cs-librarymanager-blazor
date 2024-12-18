using LibraryManagementwithBlazor.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementwithBlazor.Services
{
    public class BookService
    {
        private readonly LibraryManagementwithBlazorContext _context;

        public BookService(LibraryManagementwithBlazorContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _context.TblBook.ToListAsync();
        }

        public async Task AddBookAsync(Book book)
        {
            _context.TblBook.Add(book);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBookAsync(string bookNum)
        {
            var book = await _context.TblBook.FindAsync(bookNum);
            if (book == null)
                throw new InvalidOperationException("Book not found.");

            _context.TblBook.Remove(book);
            await _context.SaveChangesAsync();
        }

        public async Task<Book?> GetBookByIdAsync(string bookNum)
        {
            return await _context.TblBook.FirstOrDefaultAsync(b => b.BookNum == bookNum);
        }

        public async Task UpdateBookAsync(Book book)
        {
            var existingBook = await _context.TblBook.FindAsync(book.BookNum);
            if (existingBook == null)
                throw new InvalidOperationException("Book not found.");

            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.Publisher = book.Publisher;
            existingBook.ISBN = book.ISBN;
            existingBook.PublicationPlace = book.PublicationPlace;
            existingBook.PublicationDate = book.PublicationDate;

            await _context.SaveChangesAsync();
        }
    }
}
