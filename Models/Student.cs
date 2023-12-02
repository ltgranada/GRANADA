using System.ComponentModel.DataAnnotations;

namespace GranadaITELEC1C.Models;
public enum Course
{
    BSIT, BSCS, BSIS, OTHER
}

public class Student
{
    [Required]
    public int Id { get; set; }
    [Display(Name = "First name")]
    [Required(ErrorMessage = "Please enter your Firstname")]
    public string FirstName { get; set; }
    [Display(Name = "Last name")]
    [Required(ErrorMessage = "Please enter your Lastname")]
    public string LastName { get; set; }
    [Display(Name = "General Point Average")]
    [Required(ErrorMessage = "Please enter your GPA")]
    public double GPA { get; set; }
    [Display(Name = "Course")]
    [Required(ErrorMessage = "Please enter your Course")]
    public Course Course { get; set; }
    [Display(Name = "Admission date")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "Please enter your Admission Date")]

    public DateTime AdmissionDate { get; set; }
    [EmailAddress]
    [Display(Name = "Email address")]
    [Required(ErrorMessage = "Please enter your Email address")]

    public string Email { get; set; }

    public Byte[]? StudentProfilePhoto { get; set; }

}
