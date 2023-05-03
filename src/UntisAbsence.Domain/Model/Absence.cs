namespace UntisAbsence.Domain.Model;

public sealed record Absence
{
    public int AbsenceId { get; set; }
    public DateOnly AnbsenceDate { get; set; }
}
