using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblFinCostCenterGroup
{
    public int CcgIdpk { get; set; }

    public string? CcgName { get; set; }

    public string? CcgShtName { get; set; }

    public bool? CcgActive { get; set; }

    public string? CcgRmks { get; set; }

    public string? CcgCreatedBy { get; set; }

    public int? CcgEditedBy { get; set; }

    public DateTime? CcgCreationDate { get; set; }

    public DateTime? CcgEditedDate { get; set; }
}
