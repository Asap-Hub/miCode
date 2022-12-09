using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHdsIssueCategory
{
    public int IctIdpk { get; set; }

    public string? IctName { get; set; }

    public string? IctShtName { get; set; }

    public decimal? IctOrder { get; set; }

    public bool? IctActive { get; set; }

    public string? IctRmks { get; set; }

    public int? IctCreatedBy { get; set; }

    public int? IctEditedBy { get; set; }

    public DateTime? IctCreationDate { get; set; }

    public DateTime? IctEditedDate { get; set; }
}
