using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgBrand
{
    public int FbrnIdpk { get; set; }

    public string? FbrnName { get; set; }

    public string? FbrnShtName { get; set; }

    public bool? FbrnActive { get; set; }

    public string? FbrnRmks { get; set; }

    public int? FbrnCreatedBy { get; set; }

    public int? FbrnEditedBy { get; set; }

    public DateTime? FbrnCreationDate { get; set; }

    public DateTime? FbrnEditedDate { get; set; }
}
