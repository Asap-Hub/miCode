using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftGroupGradesAssignment
{
    public int GgaIdpk { get; set; }

    public int? GgaGroupIdfk { get; set; }

    public int? GgaGradeNameIdfk { get; set; }

    public DateTime? GgaStartDate { get; set; }

    public DateTime? GgaEndDate { get; set; }

    public int MagIdpk { get; set; }

    public string? MagGrade { get; set; }

    public string? MagGradeShtName { get; set; }

    public decimal? MagStartValue { get; set; }

    public decimal? MagEndValue { get; set; }

    public string? MagColour { get; set; }

    public string? MagInterpretation { get; set; }

    public int MgnIdpk { get; set; }

    public string? MgnName { get; set; }

    public string? MgnShtName { get; set; }

    public bool? MgnActive { get; set; }

    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public bool? GgaActive { get; set; }

    public string? GgaRmks { get; set; }

    public string MagColourDisplayName { get; set; } = null!;
}
