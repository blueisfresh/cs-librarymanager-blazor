using LibraryManagementwithBlazor.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementwithBlazor.Services
{
    public class StudentService
    {
        private readonly LibraryManagementwithBlazorContext _context;

        public StudentService(LibraryManagementwithBlazorContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await _context.TblStudent
                                 .Where(s => s.LibraryCardNum != 0) // Exclude anonymized students
                                 .ToListAsync();
        }

        public async Task AddStudentAsync(Student student)
        {
            _context.TblStudent.Add(student);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStudentAsync(int libraryCardNum)
        {
            if (libraryCardNum == 0)
                throw new InvalidOperationException("Cannot delete the anonymized student.");

            var student = await _context.TblStudent.FindAsync(libraryCardNum);
            if (student == null)
                throw new InvalidOperationException("Student not found.");

            _context.TblStudent.Remove(student);
            await _context.SaveChangesAsync();
        }

        public async Task<Student?> GetStudentByLibraryCardNumAsync(int libraryCardNum)
        {
            return await _context.TblStudent.FirstOrDefaultAsync(s => s.LibraryCardNum == libraryCardNum);
        }

        public async Task UpdateStudentAsync(Student student)
        {
            var existingStudent = await _context.TblStudent
                                                .FirstOrDefaultAsync(s => s.LibraryCardNum == student.LibraryCardNum);
            if (existingStudent == null)
                throw new InvalidOperationException("Student not found.");

            existingStudent.FirstName = student.FirstName;
            existingStudent.LastName = student.LastName;

            await _context.SaveChangesAsync();
        }

        public async Task<bool> StudentExistsAsync(int libraryCardNum)
        {
            return await _context.TblStudent.AnyAsync(s => s.LibraryCardNum == libraryCardNum);
        }

        public async Task<List<Student>> GetSearchedStudentsAsync(string searchQuery)
        {
            return await _context.TblStudent
                                 .Where(student => student.FirstName.Contains(searchQuery) && student.LibraryCardNum != 0)
                                 .ToListAsync();
        }

        public async Task<List<Student>> GetFilteredStudentsAsync()
        {
            return await _context.TblStudent
                                 .Where(student => student.LibraryCardNum != 0)
                                 .ToListAsync();
        }


    }
}
