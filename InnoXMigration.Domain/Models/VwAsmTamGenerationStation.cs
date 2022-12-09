using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTamGenerationStation
{
    public int GstIdpk { get; set; }

    public string? GstName { get; set; }

    public string? GstShtName { get; set; }

    public bool? GstActive { get; set; }

    public int GcmIdpk { get; set; }

    public string? GcmName { get; set; }

    public string? GcmShtName { get; set; }

    public bool? GcmActive { get; set; }

    public string? GcmRmks { get; set; }

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public bool? LocActive { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public bool? AreActive { get; set; }
}
