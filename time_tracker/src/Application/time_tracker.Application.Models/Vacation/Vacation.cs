namespace Application.Models.Vacation;

public class Vacation
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public VacationType Type { get; set; }
    public Date StartDate { get; set; }
    public Date EndDate { get; set; }
}