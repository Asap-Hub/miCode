using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmTheme
{
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

    public string? ThmCreatedBy { get; set; }

    public int? ThmEditedBy { get; set; }

    public DateTime? ThmCreationDate { get; set; }

    public DateTime? ThmEditedDate { get; set; }
}
