using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPjmImpact
{
    public int ImpIdpk { get; set; }

    public string? ImpName { get; set; }

    public string? ImpShtName { get; set; }

    public int? ImpProjectCategoryIdfk { get; set; }

    public decimal? ImpOrder { get; set; }

    public bool? ImpActive { get; set; }

    public string? ImpRmks { get; set; }

    public int? ImpCreatedBy { get; set; }

    public int? ImpEditedBy { get; set; }

    public DateTime? ImpCreationDate { get; set; }

    public DateTime? ImpEditedDate { get; set; }
}
