using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Book
{
    [Key]
    [Required(ErrorMessage = "Book number is required.")]
    [StringLength(10, ErrorMessage = "Book number must be exactly 10 characters.")]
    public string BookNum { get; set; }           // e.g., "00001-2023"

    [Required(ErrorMessage = "Title is required.")]
    [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
    public string Title { get; set; }              // Title of the book

    [Required(ErrorMessage = "Author is required.")]
    [StringLength(50, ErrorMessage = "Author name cannot exceed 50 characters.")]
    public string Author { get; set; }             // Author's name

    [Required(ErrorMessage = "Publisher is required.")]
    [StringLength(50, ErrorMessage = "Publisher name cannot exceed 50 characters.")]
    public string Publisher { get; set; }          // Publisher's name

    [Required(ErrorMessage = "ISBN is required.")]
    [RegularExpression(@"\d{13}", ErrorMessage = "ISBN must be exactly 13 digits.")]
    public string ISBN { get; set; }               // ISBN, fixed-length 13

    [Required(ErrorMessage = "Place of publication is required.")]
    [StringLength(50, ErrorMessage = "Place of publication cannot exceed 50 characters.")]
    public string PublicationPlace { get; set; }   // Place of publication

    [Required(ErrorMessage = "Publication date is required.")]
    [DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
    public DateTime PublicationDate { get; set; }  // Date the book was published

}

