namespace Application.Models.Vacation;

public class Vacation
{
    public Guid Id { get; set; }
    public Employee Employee { get; set; }
    public VacationType Type { get; set; }
    public Date StartDate { get; set; }
    public Date EndDate { get; set; }
}