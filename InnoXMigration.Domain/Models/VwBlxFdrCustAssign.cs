using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwBlxFdrCustAssign
{
    public int FfcaIdpk { get; set; }

    public int? FfcaCustIdfk { get; set; }

    public DateTime? FfcaDate { get; set; }

    public bool? FfcaAssigned { get; set; }

    public int FfsaIdpk { get; set; }

    public int? FfsaSstIdfk { get; set; }

    public int? FfsaFdrIdfk { get; set; }

    public DateTime? FfsaDate { get; set; }

    public string? FfsaRmks { get; set; }

    public int FfdrIdpk { get; set; }

    public string? FfdrName { get; set; }

    public string? FfdrShtName { get; set; }

    public bool? FfdrActive { get; set; }

    public int StnIdpk { get; set; }

    public string StnName { get; set; } = null!;

    public string StnShtName { get; set; } = null!;

    public bool StnActive { get; set; }

    public string StnRmks { get; set; } = null!;

    public int AreIdpk { get; set; }

    public string AreName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;

    public bool AreActive { get; set; }

    public double? FfdrMultiplier { get; set; }

    public int FcustIdpk { get; set; }

    public string? FcustName { get; set; }

    public string? FcustShtName { get; set; }

    public string? FcustAddress { get; set; }

    public string? FcustSalutation { get; set; }

    public string? FcustContact { get; set; }

    public string? FcustEmail { get; set; }

    public string? FcustMobNo { get; set; }

    public string? FcustTelNo { get; set; }

    public double? FcustCurntRlr { get; set; }

    public double? FcustCurntTsr { get; set; }

    public bool? FcustActive { get; set; }

    public string? FcustRmks { get; set; }

    public int? CurntCtpIdpk { get; set; }

    public string? CurntCtpName { get; set; }

    public string? CurntCtpShtName { get; set; }

    public int? CurntCurrIdpk { get; set; }

    public string? CurntCurrName { get; set; }

    public string? CurntCurrShtName { get; set; }

    public string? CurntCurrSymbol { get; set; }

    public bool? CurntCurrForeign { get; set; }

    public bool? CurntCurrActive { get; set; }

    public bool? CurntCtpActive { get; set; }

    public string? CurntCtpRmks { get; set; }

    public bool? FfdrAssigned { get; set; }

    public string? FfcaRmks { get; set; }

    public string? FfdrRmks { get; set; }

    public DateTime? FfcaEndDate { get; set; }

    public bool? FfcaTeeingOffFeeder { get; set; }

    public DateTime? FfsaEndDate { get; set; }

    public bool FfsaActive { get; set; }
}
