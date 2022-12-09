using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrUnit
{
    public int UntIdpk { get; set; }

    public string? UntName { get; set; }

    public string? UntShtName { get; set; }

    public int? UntSectionIdfk { get; set; }

    public bool? UntActive { get; set; }

    public string UntRmks { get; set; } = null!;

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public string? SxnShtName { get; set; }

    public int? SxnDeptIdfk { get; set; }

    public bool? SxnActive { get; set; }

    public string? SxnRmks { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public bool? DptActive { get; set; }

    public string? DptRmks { get; set; }

    public string? DptCode { get; set; }

    public string? SxnCode { get; set; }

    public string UntCode { get; set; } = null!;

    public int? UntHeadEmpIdfk { get; set; }

    public DateTime? UntStartDate { get; set; }

    public DateTime? UntEndDate { get; set; }

    public int? ObrIdpk { get; set; }

    public string? ObrName { get; set; }

    public string? ObrShtName { get; set; }
}
