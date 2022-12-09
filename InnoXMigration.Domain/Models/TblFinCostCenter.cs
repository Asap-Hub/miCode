using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblFinCostCenter
{
    public int CctIdpk { get; set; }

    public string? CctName { get; set; }

    public string? CctShtName { get; set; }

    public int? CctDeptIdfk { get; set; }

    public int? CctSectionIdfk { get; set; }

    public int? CctUnitIdfk { get; set; }

    public int? CctGroupIdfk { get; set; }

    public string? CctCode { get; set; }

    public bool? CctActive { get; set; }

    public string? CctRmks { get; set; }

    public string? CctCreatedBy { get; set; }

    public int? CctEditedBy { get; set; }

    public DateTime? CctCreationDate { get; set; }

    public DateTime? CctEditedDate { get; set; }
}
