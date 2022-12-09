using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAcsApplType
{
    public int FatpIdpk { get; set; }

    public string? FatpName { get; set; }

    public string? FatpShtName { get; set; }

    public bool? FatpHasPlant { get; set; }

    public bool? FatpActive { get; set; }

    public string? FatpRmks { get; set; }

    public int? FatpCreatedBy { get; set; }

    public int? FatpEditedBy { get; set; }

    public DateTime? FatpCreationDate { get; set; }

    public DateTime? FatpEditedDate { get; set; }
}
