using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmgThemeInclusionsExclusion
{
    public int TieIdpk { get; set; }

    public string? TieCriteria { get; set; }

    public int? TieThemeIdfk { get; set; }

    public string? TieStartDate { get; set; }

    public string? TieEndDate { get; set; }

    public string? TieItem { get; set; }

    public int? TieOrder { get; set; }

    public bool? TieActive { get; set; }

    public string? TieRmks { get; set; }

    public string? TieCreatedBy { get; set; }

    public int? TieEditedBy { get; set; }

    public DateTime? TieCreationDate { get; set; }

    public DateTime? TieEditedDate { get; set; }
}
