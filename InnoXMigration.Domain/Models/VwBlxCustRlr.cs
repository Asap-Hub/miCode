using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwBlxCustRlr
{
    public int FcrrIdpk { get; set; }

    public int? FcrrCustIdfk { get; set; }

    public double? FcrrTsrate { get; set; }

    public double? FcrrRegRate { get; set; }

    public DateTime? FcrrDate { get; set; }

    public string? FcrrRmks { get; set; }

    public int FcustIdpk { get; set; }

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

    public string? FcustName { get; set; }

    public string? CustName { get; set; }
}
