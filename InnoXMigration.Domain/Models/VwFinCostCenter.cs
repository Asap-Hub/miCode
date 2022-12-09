using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwFinCostCenter
{
    public int CctIdpk { get; set; }

    public string? CctName { get; set; }

    public string? CctShtName { get; set; }

    public int? CctGroupIdfk { get; set; }

    public string? CctCode { get; set; }

    public bool? CctActive { get; set; }

    public string? CctRmks { get; set; }

    public string? CctCreatedBy { get; set; }

    public int? CctEditedBy { get; set; }

    public DateTime? CctCreationDate { get; set; }

    public DateTime? CctEditedDate { get; set; }

    public int? CctDeptIdfk { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public string? SxnShtName { get; set; }

    public string? SxnCode { get; set; }

    public string? DptCode { get; set; }

    public int? UntIdpk { get; set; }

    public string? UntName { get; set; }

    public string? UntShtName { get; set; }

    public string? UntCode { get; set; }

    public int? CcgIdpk { get; set; }

    public string? CcgName { get; set; }

    public string? CcgShtName { get; set; }

    public bool? CcgActive { get; set; }
}
