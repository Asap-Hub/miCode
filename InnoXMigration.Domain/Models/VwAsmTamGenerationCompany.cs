using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTamGenerationCompany
{
    public int GcmIdpk { get; set; }

    public string? GcmName { get; set; }

    public string? GcmShtName { get; set; }

    public int? GcmLocationIdfk { get; set; }

    public bool? GcmActive { get; set; }

    public string? GcmRmks { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public bool? LocActive { get; set; }

    public string? LocRmks { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public bool? AreActive { get; set; }

    public string? GcmContacts { get; set; }

    public string? GcmMobNos { get; set; }

    public string? GcmTelNos { get; set; }

    public string? GcmEmail { get; set; }

    public string? GcmAddress { get; set; }
}
