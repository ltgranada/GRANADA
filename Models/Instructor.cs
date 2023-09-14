namespace GranadaITELEC1C.Models;
public enum Rank
{
    Instructor, AssistantProfessor, AssociateProfessor, Professor
}
public class Instructor
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsTenured { get; set; }
    public Rank rank { get; set; }
    public DateTime HiringDate { get; set; }
}