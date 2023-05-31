using UntisAbsence.Domain.Enums;

namespace UntisAbsence.Domain.Models;

public sealed record Absence
{
    public int AbsenceId { get; init; }
    
    public required DateOnly AbsenceDate { get; set; }
    
    public required WeekDay Day { get; set; }
    
    public required TimeOnly Time { get; set; }
    
    public int AbsenceHours { get; set; }
    
    public bool Late { get; set; }
}
