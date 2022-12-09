using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftMeetingAttendanceGrade
{
    public int MagIdpk { get; set; }

    public int? MagNameIdfk { get; set; }

    public string? MagGrade { get; set; }

    public string? MagGradeShtName { get; set; }

    public decimal? MagStartValue { get; set; }

    public decimal? MagEndValue { get; set; }

    public string? MagColour { get; set; }

    public string? MagInterpretation { get; set; }

    public bool? MagActive { get; set; }

    public string? MagRmks { get; set; }

    public int MgnIdpk { get; set; }

    public string? MgnName { get; set; }

    public string? MgnShtName { get; set; }

    public bool? MgnActive { get; set; }

    public string? MgnRmks { get; set; }

    public string MagColourDisplayName { get; set; } = null!;
}
