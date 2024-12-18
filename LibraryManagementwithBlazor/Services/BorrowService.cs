using LibraryManagementwithBlazor.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementwithBlazor.Services
{
    public class BorrowService
    {
        private readonly LibraryManagementwithBlazorContext _context;

        public BorrowService(LibraryManagementwithBlazorContext context)
        {
            _context = context;
        }

        // Add a new borrow record with validations
        public async Task AddBorrowAsync(Borrow borrow)
        {
            var studentExists = await _context.TblStudent.AnyAsync(s => s.LibraryCardNum == borrow.StudentLibraryCardNum);
            if (!studentExists)
                throw new InvalidOperationException("Student does not exist.");

            var bookExists = await _context.TblBook.AnyAsync(b => b.BookNum == borrow.BookBookNum);
            if (!bookExists)
                throw new InvalidOperationException("Book does not exist.");

            var isBookBorrowed = await _context.TblBorrow
                .AnyAsync(b => b.BookBookNum == borrow.BookBookNum && b.ReturnDate == null);
            if (isBookBorrowed)
                throw new InvalidOperationException("Book is already borrowed.");

            borrow.BorrowDate = DateTime.Now;
            _context.TblBorrow.Add(borrow);
            await _context.SaveChangesAsync();
        }

        // Return a book
        public async Task ReturnBookAsync(int borrowId)
        {
            var borrow = await _context.TblBorrow.FindAsync(borrowId);
            if (borrow == null)
                throw new InvalidOperationException("Borrow record not found.");

            borrow.ReturnDate = DateTime.Now;
            borrow.StudentLibraryCardNum = 0; // Set to "Anonym" student ID
            await _context.SaveChangesAsync();
        }

        // Get all borrowed books
        public async Task<List<Borrow>> GetAllBorrowedBooksAsync()
        {
            return await _context.TblBorrow
                .Where(b => b.ReturnDate == null)
                .ToListAsync();
        }

        // Get borrowed books by student
        public async Task<List<Borrow>> GetBorrowedBooksByStudentAsync(int libraryCardNum)
        {
            return await _context.TblBorrow
                .Where(b => b.StudentLibraryCardNum == libraryCardNum && b.ReturnDate == null)
                .ToListAsync();
        }

        // Get overdue books
        public async Task<List<Borrow>> GetOverdueBooksAsync()
        {
            return await _context.TblBorrow
                .Where(b => b.DueDate < DateTime.Now && b.ReturnDate == null)
                .ToListAsync();
        }

        // Check if a book is available
        public async Task<bool> IsBookAvailableAsync(string bookNum)
        {
            return !await _context.TblBorrow
                .AnyAsync(b => b.BookBookNum == bookNum && b.ReturnDate == null);
        }

        // Extend a borrow's due date
        public async Task ExtendDueDateAsync(int borrowId, DateTime newDueDate)
        {
            var borrow = await _context.TblBorrow.FindAsync(borrowId);
            if (borrow == null)
                throw new InvalidOperationException("Borrow record not found.");

            borrow.DueDate = newDueDate;
            await _context.SaveChangesAsync();
        }
    }
}
