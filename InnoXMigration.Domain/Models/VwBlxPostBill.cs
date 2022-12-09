using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwBlxPostBill
{
    public int FpblIdpk { get; set; }

    public short? FpblCustIdfk { get; set; }

    public string? FpblCategory { get; set; }

    public string? FpblActivity { get; set; }

    public string? FpblRmks { get; set; }

    public int FcustIdpk { get; set; }

    public string? FcustShtName { get; set; }

    public string? CustName { get; set; }

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

    public DateTime? FcustSetupDate { get; set; }

    public DateTime? FcustEndDate { get; set; }

    public short? FpblCreatedBy { get; set; }

    public DateTime? FpblCreationDate { get; set; }

    public int? FpblBillNameIdfk { get; set; }

    public int FbnmIdpk { get; set; }

    public string? FbnmName { get; set; }

    public string? FbnmShtName { get; set; }

    public DateTime? FbnmStartDate { get; set; }

    public DateTime? FbnmEndDate { get; set; }

    public bool? FbnmActive { get; set; }

    public string? FbnmRmks { get; set; }
}
