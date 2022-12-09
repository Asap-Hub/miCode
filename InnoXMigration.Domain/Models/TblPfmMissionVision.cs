using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPfmMissionVision
{
    public int MvsIdpk { get; set; }

    public string? MvsName { get; set; }

    public string? MvsShtName { get; set; }

    public DateTime? MvsStartDate { get; set; }

    public DateTime? MvsEndDate { get; set; }

    public string? MvsMission { get; set; }

    public string? MvsMissionSht { get; set; }

    public string? MvsVision { get; set; }

    public string? MvsVisionSht { get; set; }

    public bool? MvsActive { get; set; }

    public string? MvsRmks { get; set; }

    public string? MvsCreatedBy { get; set; }

    public int? MvsEditedBy { get; set; }

    public DateTime? MvsCreationDate { get; set; }

    public DateTime? MvsEditedDate { get; set; }
}
