using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwBlxFdrSstAssign
{
    public int FfsaIdpk { get; set; }

    public int? FfsaSstIdfk { get; set; }

    public int? FfsaFdrIdfk { get; set; }

    public DateTime? FfsaDate { get; set; }

    public DateTime? FfsaEndDate { get; set; }

    public string? FfsaRmks { get; set; }

    public int FfdrIdpk { get; set; }

    public string? FfdrName { get; set; }

    public string? FfdrShtName { get; set; }

    public bool? FfdrActive { get; set; }

    public int? FfdrCustIdfk { get; set; }

    public int? FfdrSstIdfk { get; set; }

    public double? FfdrMultiplier { get; set; }

    public bool? FfdrAssigned { get; set; }

    public int? FfdrParentFdrIdfk { get; set; }

    public string? FfdrRmks { get; set; }

    public int StnIdpk { get; set; }

    public string StnName { get; set; } = null!;

    public string StnShtName { get; set; } = null!;

    public bool StnActive { get; set; }

    public string StnRmks { get; set; } = null!;

    public int AreIdpk { get; set; }

    public string AreName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;

    public bool AreActive { get; set; }

    public bool FfsaActive { get; set; }
}
