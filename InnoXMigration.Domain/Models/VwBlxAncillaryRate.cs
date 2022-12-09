using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwBlxAncillaryRate
{
    public int FanrIdpk { get; set; }

    public int? FanrCustIdfk { get; set; }

    public double? FanrRate { get; set; }

    public DateTime? FanrDate { get; set; }

    public string? FanrRateTypeIdfk { get; set; }

    public string? FanrRmks { get; set; }

    public int? FrttIdpk { get; set; }

    public string? FrttName { get; set; }

    public string? FrttShtName { get; set; }

    public bool? FrttActive { get; set; }

    public string? FrttRmks { get; set; }

    public int? FcustIdpk { get; set; }

    public string? FcustName { get; set; }

    public string? FcustShtName { get; set; }

    public string? CustName { get; set; }

    public string? FcustAddress { get; set; }

    public string? FcustSalutation { get; set; }

    public string? FcustContact { get; set; }

    public string? FcustEmail { get; set; }

    public string? FcustMobNo { get; set; }

    public string? FcustTelNo { get; set; }

    public string? CurntCurrName { get; set; }

    public string? CurntCtpShtName { get; set; }

    public string? CurntCurrShtName { get; set; }

    public string? CurntCurrSymbol { get; set; }

    public bool? CurntCurrForeign { get; set; }

    public string? FcustRefNo { get; set; }
}
