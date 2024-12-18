using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Student
{
    [Key]
    public int LibraryCardNum { get; set; }    // Unique 6-digit library card number
    public string FirstName { get; set; }      // First name of the student
    public string LastName { get; set; }       // Last name of the student
}