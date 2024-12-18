using System;
using System.ComponentModel.DataAnnotations;

public class Student
{
    [Key]
    [Required(ErrorMessage = "Library card number is required.")]
    [Range(100000, 999999, ErrorMessage = "Library card number must be a 6-digit number.")]
    public int LibraryCardNum { get; set; } // Unique 6-digit library card number

    [Required(ErrorMessage = "First name is required.")]
    [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
    public string FirstName { get; set; } // First name of the student

    [Required(ErrorMessage = "Last name is required.")]
    [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
    public string LastName { get; set; } // Last name of the student
}
