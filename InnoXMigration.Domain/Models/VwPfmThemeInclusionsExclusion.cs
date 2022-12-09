using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmThemeInclusionsExclusion
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

    public int ThmIdpk { get; set; }

    public int? ThmMissionIdfk { get; set; }

    public string? ThmName { get; set; }

    public bool? ThmActive { get; set; }

    public string? ThmRmks { get; set; }

    public int MvsIdpk { get; set; }

    public string? MvsName { get; set; }

    public DateTime? MvsStartDate { get; set; }

    public DateTime? MvsEndDate { get; set; }

    public string? MvsMission { get; set; }

    public string? MvsMissionSht { get; set; }

    public string? MvsVision { get; set; }

    public string? MvsVisionSht { get; set; }

    public bool? MvsActive { get; set; }

    public byte? ThmOrder { get; set; }

    public string? ThmShtName { get; set; }

    public string? ThmCommentary { get; set; }
}
