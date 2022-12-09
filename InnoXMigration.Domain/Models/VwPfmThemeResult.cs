using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmThemeResult
{
    public int TrsIdpk { get; set; }

    public int? TrsThemeIdfk { get; set; }

    public string? TrsResult { get; set; }

    public string? TrsShtResult { get; set; }

    public string? TrsCommentary { get; set; }

    public int? TrsOrder { get; set; }

    public bool? TrsActive { get; set; }

    public string? TrsRmks { get; set; }

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

    public string? ThmCommentary { get; set; }

    public string? ThmShtName { get; set; }

    public byte? ThmOrder { get; set; }

    public bool? MvsActive { get; set; }
}
