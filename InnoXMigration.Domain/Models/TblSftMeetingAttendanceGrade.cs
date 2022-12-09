using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftMeetingAttendanceGrade
{
    public int MagIdpk { get; set; }

    public int? MagNameIdfk { get; set; }

    public string? MagGrade { get; set; }

    public string? MagGradeShtName { get; set; }

    public decimal? MagStartValue { get; set; }

    public decimal? MagEndValue { get; set; }

    public string? MagColour { get; set; }

    public string? MagColourDisplayName { get; set; }

    public string? MagInterpretation { get; set; }

    public bool? MagActive { get; set; }

    public string? MagRmks { get; set; }

    public int? MagCreatedBy { get; set; }

    public int? MagEditedBy { get; set; }

    public DateTime? MagCreationDate { get; set; }

    public DateTime? MagEditedDate { get; set; }
}
