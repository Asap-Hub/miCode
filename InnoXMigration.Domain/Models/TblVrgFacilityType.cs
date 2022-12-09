using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgFacilityType
{
    public int FfctIdpk { get; set; }

    public string? FfctName { get; set; }

    public string? FfctShtName { get; set; }

    public bool? FfctActive { get; set; }

    public string? FfctRmks { get; set; }

    public int? FfctCreatedBy { get; set; }

    public int? FfctEditedBy { get; set; }

    public DateTime? FfctCreationDate { get; set; }

    public DateTime? FfctEditedDate { get; set; }
}
