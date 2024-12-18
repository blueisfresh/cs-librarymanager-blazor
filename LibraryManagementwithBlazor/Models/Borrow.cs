using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Borrow
{
    [Key]
    public int BorrowID { get; set; }               // Unique ID for each borrow transaction
    public int StudentLibraryCardNum { get; set; }  // Foreign key referencing Student.LibraryCardNum
    public string BookBookNum { get; set; }         // Foreign key referencing Book.BookNum
    public DateTime BorrowDate { get; set; }        // Date the book was borrowed
    public DateTime? ReturnDate { get; set; }        // Date the book was returned
    public DateTime? DueDate { get; set; }           // Due date for returning the book
}