using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsApprovalLimit
{
    public int AlmIdpk { get; set; }

    public DateTime? AlmDate { get; set; }

    public string? AlmApprovalCat { get; set; }

    public decimal? AlmLowerLimit { get; set; }

    public decimal? AlmUpperLimit { get; set; }

    public bool? AlmActive { get; set; }

    public string? AlmRmks { get; set; }

    public string? AlmCreatedBy { get; set; }

    public int? AlmEditedBy { get; set; }

    public DateTime? AlmCreationDate { get; set; }

    public DateTime? AlmEditedDate { get; set; }
}
