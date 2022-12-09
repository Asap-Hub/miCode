using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtActivityUnit
{
    public int AcuIdpk { get; set; }

    public string? AcuName { get; set; }

    public string? AcuShtName { get; set; }

    public bool? AcuActive { get; set; }

    public string? AcuRmks { get; set; }

    public int? AcuCreatedBy { get; set; }

    public int? AcuEditedBy { get; set; }

    public DateTime? AcuCreationDate { get; set; }

    public DateTime? AcuEditedDate { get; set; }
}
