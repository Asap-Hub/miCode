using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsTransportUnit
{
    public int TruIdpk { get; set; }

    public string? TruName { get; set; }

    public string? TruShtName { get; set; }

    public int? TruDeptIdfk { get; set; }

    public int? TruSectionIdfk { get; set; }

    public int TruUnitIdfk { get; set; }

    public bool? TruActive { get; set; }

    public string? TruRmks { get; set; }

    public int DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public string? DptCode { get; set; }

    public bool? DptActive { get; set; }

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int? SxnDeptIdfk { get; set; }

    public string? SxnCode { get; set; }

    public bool? SxnActive { get; set; }

    public int UntIdpk { get; set; }

    public string UntName { get; set; } = null!;

    public string UntShtName { get; set; } = null!;

    public string UntCode { get; set; } = null!;
}
