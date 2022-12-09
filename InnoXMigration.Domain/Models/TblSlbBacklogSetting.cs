using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbBacklogSetting
{
    public int SbsIdpk { get; set; }

    public DateTime? SbsStartDate { get; set; }

    public DateTime? SbsEndDate { get; set; }

    public DateTime? SbsExpiryDate { get; set; }

    public int? SbsStationIdfk { get; set; }

    public bool? SbsActive { get; set; }

    public string? SbsRmks { get; set; }

    public int? SbsCreatedBy { get; set; }

    public int? SbsEditedBy { get; set; }

    public DateTime? SbsCreationDate { get; set; }

    public DateTime? SbsEditedDate { get; set; }
}
