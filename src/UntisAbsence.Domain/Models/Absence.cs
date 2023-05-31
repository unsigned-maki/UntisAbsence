using UntisAbsence.Domain.Enums;

namespace UntisAbsence.Domain.Models;

public sealed record Absence    
{
    public int AbsenceId { get; init; }
    
    public required DateOnly AbsenceDate { get; set; }
    
    public required WeekDay Day { get; set; }
    
    public required TimeOnly TimeFrom { get; set; }
    
    public required TimeOnly TimeTo { get; set; }
    
    public int AbsenceHours { get; set; }
    
    public bool Late { get; set; }
}
