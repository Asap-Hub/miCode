using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHdsIssueImpact
{
    public int IimIdpk { get; set; }

    public string? IimName { get; set; }

    public string? IimShtName { get; set; }

    public int? IimIssueTypeIdfk { get; set; }

    public int? IimIssueClassIdfk { get; set; }

    public decimal? IimOrder { get; set; }

    public bool? IimActive { get; set; }

    public string? IimRmks { get; set; }

    public int? IimCreatedBy { get; set; }

    public int? IimEditedBy { get; set; }

    public DateTime? IimCreationDate { get; set; }

    public DateTime? IimEditedDate { get; set; }
}
