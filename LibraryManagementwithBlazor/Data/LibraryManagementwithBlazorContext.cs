using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementwithBlazor.Data
{
    public class LibraryManagementwithBlazorContext : DbContext
    {
        public LibraryManagementwithBlazorContext (DbContextOptions<LibraryManagementwithBlazorContext> options)
            : base(options)
        {
        }

        public DbSet<Book> TblBook { get; set; } = default!;
        public DbSet<Student> TblStudent { get; set; } = default!;
        public DbSet<Borrow> TblBorrow { get; set; } = default!;
    }
}
