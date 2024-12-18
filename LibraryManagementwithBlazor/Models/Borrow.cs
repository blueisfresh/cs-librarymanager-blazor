using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Borrow
{
    [Key]
    public int BorrowID { get; set; } // Unique ID for each borrow transaction

    // Foreign Key referencing Student.LibraryCardNum
    [Required(ErrorMessage = "Student library card number is required.")]
    public int StudentLibraryCardNum { get; set; }

    [ForeignKey(nameof(StudentLibraryCardNum))]
    public virtual Student Student { get; set; } // Navigation Property

    // Foreign Key referencing Book.BookNum
    [Required(ErrorMessage = "Book number is required.")]
    [StringLength(10, ErrorMessage = "Book number must be exactly 10 characters.")]
    public string BookBookNum { get; set; }

    [ForeignKey(nameof(BookBookNum))]
    public virtual Book Book { get; set; } // Navigation Property

    [Required(ErrorMessage = "Borrow date is required.")]
    [DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
    public DateTime BorrowDate { get; set; } // Date the book was borrowed

    [DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
    public DateTime? ReturnDate { get; set; } // Date the book was returned

    [Required(ErrorMessage = "Due date is required.")]
    [DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
    public DateTime? DueDate { get; set; } // Due date for returning the book
}
