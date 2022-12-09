using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTamGenerationPlant
{
    public int GplIdpk { get; set; }

    public string? GplName { get; set; }

    public string? GplShtName { get; set; }

    public byte? GplDisplayOrder { get; set; }

    public bool? GplActive { get; set; }

    public string? GplRmks { get; set; }

    public int? GstIdpk { get; set; }

    public string? GstName { get; set; }

    public string? GstShtName { get; set; }

    public bool? GstActive { get; set; }

    public int? GcmIdpk { get; set; }

    public string? GcmName { get; set; }

    public string? GcmShtName { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public int GptIdpk { get; set; }

    public string? GptName { get; set; }

    public string? GptShtName { get; set; }
}
