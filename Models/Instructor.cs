using System.ComponentModel.DataAnnotations;

namespace GranadaITELEC1C.Models;
public enum Rank
{
    Instructor, AssistantProfessor, AssociateProfessor, Professor
}
public class Instructor
{
    [Display(Name = "ID")]
    [Required(ErrorMessage = "Please enter your ID")]
    public int Id { get; set; }

    [Display(Name = "First name")]
    [Required(ErrorMessage = "Please enter your Firstname")]
    public string FirstName { get; set; }
    [Display(Name = "Last name")]
    [Required(ErrorMessage = "Please enter your Lastname")]
    public string LastName { get; set; }
    [Display(Name = "Is Tenured")]
    public bool IsTenured { get; set; }
    [Display(Name = "Academic Rank")]
    [Required(ErrorMessage = "Please enter your Rank")]
    public Rank rank { get; set; }

    [Display(Name = "Hiring date")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "Please enter your Hiring Date")]
    public DateTime HiringDate { get; set; }
}