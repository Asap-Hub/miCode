using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsMaintenanceLocation
{
    public int MlcIdpk { get; set; }

    public string? MlcName { get; set; }

    public string? MlcShtName { get; set; }

    public string? MlcLocationIdfk { get; set; }

    public int? MlcTownIdfk { get; set; }

    public string? MlcMainContacts { get; set; }

    public string? MlcTelNos { get; set; }

    public string? MlcEmails { get; set; }

    public bool? MlcActive { get; set; }

    public string MlcRmks { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public bool? LocActive { get; set; }

    public string LocRmks { get; set; } = null!;

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public bool? AreActive { get; set; }

    public string AreRmks { get; set; } = null!;

    public int TwnIdpk { get; set; }

    public string? TwnName { get; set; }

    public string? TwnShtName { get; set; }

    public int DstIdpk { get; set; }

    public string DstName { get; set; } = null!;

    public string DstShtName { get; set; } = null!;

    public bool DstActive { get; set; }

    public string DstRemarks { get; set; } = null!;

    public int? RgnIdpk { get; set; }

    public string? RgnName { get; set; }

    public string? RgnShtName { get; set; }

    public int? CtyIdpk { get; set; }

    public string? CtyName { get; set; }

    public string? CtyShtName { get; set; }

    public string? CtyNationality { get; set; }

    public string DstCapial { get; set; } = null!;

    public string? RgnCapital { get; set; }

    public string? CtyCapital { get; set; }
}
