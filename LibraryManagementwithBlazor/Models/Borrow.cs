using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Borrow
{
    [Key]
    public int BorrowID { get; set; } // Unique ID for each borrow transaction

    [Required]
    public int StudentLibraryCardNum { get; set; } // Foreign key referencing Student.LibraryCardNum

    [ForeignKey(nameof(StudentLibraryCardNum))]
    public virtual Student Student { get; set; } // Navigation Property

    [Required]
    [StringLength(10)]
    public string BookBookNum { get; set; } // Foreign key referencing Book.BookNum

    [ForeignKey(nameof(BookBookNum))]
    public virtual Book Book { get; set; } // Navigation Property

    [Required]
    [DataType(DataType.Date)]
    public DateTime BorrowDate { get; set; } // Date the book was borrowed

    [DataType(DataType.Date)]
    public DateTime? ReturnDate { get; set; } // Date the book was returned

    [Required]
    [DataType(DataType.Date)]
    public DateTime? DueDate { get; set; } // Due date for returning the book
}
