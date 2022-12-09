using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmgThemeLeader
{
    public int TldIdpk { get; set; }

    public int? TldThemeIdfk { get; set; }

    public int? TldEmpIdfk { get; set; }

    public DateTime? TldStartDate { get; set; }

    public DateTime? TldEndDate { get; set; }

    public bool? TldActive { get; set; }

    public string? TldRmks { get; set; }

    public string? TldCreatedBy { get; set; }

    public int? TldEditedBy { get; set; }

    public DateTime? TldCreationDate { get; set; }

    public DateTime? TldEditedDate { get; set; }
}
