using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmgThemeMember
{
    public int TmbIdpk { get; set; }

    public int? TmbThemeIdfk { get; set; }

    public int? TmbEmpIdfk { get; set; }

    public DateTime? TmbStartDate { get; set; }

    public DateTime? TmbEndDate { get; set; }

    public bool? TmbLeader { get; set; }

    public bool? TmbPrimaryLeader { get; set; }

    public bool? TmbActive { get; set; }

    public string? TmbRmks { get; set; }

    public string? TmbCreatedBy { get; set; }

    public int? TmbEditedBy { get; set; }

    public DateTime? TmbCreationDate { get; set; }

    public DateTime? TmbEditedDate { get; set; }
}
