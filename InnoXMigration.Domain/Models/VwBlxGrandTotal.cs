using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwBlxGrandTotal
{
    public int FgrtIdpk { get; set; }

    public int? FgrtCustIdfk { get; set; }

    public decimal? FgrtTscGhc { get; set; }

    public decimal? FgrtEnergyConsumed { get; set; }

    public int FcustIdpk { get; set; }

    public string? FcustName { get; set; }

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

    public int? CurntCtpIdpk { get; set; }

    public string? CurntCtpName { get; set; }

    public string? CurntCtpShtName { get; set; }

    public string? CurntCurrName { get; set; }

    public string? CurntCurrShtName { get; set; }

    public string? CurntCurrSymbol { get; set; }

    public bool? CurntCurrForeign { get; set; }

    public bool? CurntCurrActive { get; set; }

    public string? FcustRefNo { get; set; }

    public bool? CurntCtpActive { get; set; }

    public DateTime? FcustSetupDate { get; set; }

    public int FprbIdpk { get; set; }

    public DateTime? FprbDate { get; set; }

    public int? FprbEmpIdfk { get; set; }

    public string? FprbBillName { get; set; }

    public string? FprbBillTitle { get; set; }

    public string? PreparedByStaffNo { get; set; }

    public string? PreparedByName { get; set; }

    public string PreparedByDept { get; set; } = null!;

    public string PreparedByShtDept { get; set; } = null!;

    public string PreparedBySection { get; set; } = null!;

    public string PreparedByShtSection { get; set; } = null!;

    public string PreparedByJobTitle { get; set; } = null!;

    public string PreparedByShtJobTitle { get; set; } = null!;

    public int CurIdpk { get; set; }

    public string? CurName { get; set; }

    public DateTime? CurDate { get; set; }

    public string? CurShtName { get; set; }

    public string? CurSymbol { get; set; }

    public bool? CurForeign { get; set; }

    public bool? CurActive { get; set; }

    public int FrvbIdpk { get; set; }

    public DateTime? FrvbDate { get; set; }

    public string? FrvbBillName { get; set; }

    public string? FrvbBillTitle { get; set; }

    public int? FrvbEmpIdfk { get; set; }

    public string? FrvbRmks { get; set; }

    public string? ReviewedByStaffNo { get; set; }

    public string ReviewedByDept { get; set; } = null!;

    public string ReviewedByShtDept { get; set; } = null!;

    public string ReviewedBySection { get; set; } = null!;

    public string ReviewedByShtSection { get; set; } = null!;

    public string? ReviewedByName { get; set; }

    public string ReviewedByJobTitle { get; set; } = null!;

    public string? ReviewedByShtJobTitle { get; set; }

    public int FsnbIdpk { get; set; }

    public int? FsnbEmpIdfk { get; set; }

    public string? FsnbBillName { get; set; }

    public string? FsnbBillTitle { get; set; }

    public DateTime? FsnbDate { get; set; }

    public string? FsnbRmks { get; set; }

    public string? SignedByStaffNo { get; set; }

    public string? SignedByName { get; set; }

    public string SignedByDept { get; set; } = null!;

    public string SignedByShtDept { get; set; } = null!;

    public string SignedBySection { get; set; } = null!;

    public string SignedByShtSection { get; set; } = null!;

    public string SignedByJobTitle { get; set; } = null!;

    public string SignedByShtJobTitle { get; set; } = null!;

    public int FctpIdpk { get; set; }

    public string? FctpName { get; set; }

    public string? FctpShtName { get; set; }

    public bool? FctpActive { get; set; }

    public string? FctpRmks { get; set; }

    public short CdtIdpk { get; set; }

    public DateTime? CdtDate { get; set; }

    public string? CdtShtName { get; set; }

    public string? CdtAddress1 { get; set; }

    public string? CdtAddress2 { get; set; }

    public string? CdtLocation { get; set; }

    public string? CdtTel1 { get; set; }

    public string? CdtTel2 { get; set; }

    public string? CdtTel3 { get; set; }

    public string? CdtFax1 { get; set; }

    public string? CdtFax2 { get; set; }

    public string? CdtEmail1 { get; set; }

    public string? CdtEmail2 { get; set; }

    public string? CdtWebsite { get; set; }

    public string? CdtFooter { get; set; }

    public string? CdtMissionStatement { get; set; }

    public string? CdtVisionStatement { get; set; }

    public int? FgrtRegCompIdfk { get; set; }

    public int FrorIdpk { get; set; }

    public int? FgrtCompIdfk { get; set; }

    public DateTime? FrorDate { get; set; }

    public string? FrorName { get; set; }

    public string? FrorShtName { get; set; }

    public string? FrorAddress { get; set; }

    public string? FrorCeoSalutation { get; set; }

    public string? FrorCeoShtSalutation { get; set; }

    public string? FrorTelNo { get; set; }

    public string? FrorEmail { get; set; }

    public string? FrorFax { get; set; }

    public string? FrorRmks { get; set; }

    public decimal? FgrtRegRate { get; set; }

    public decimal? FgrtTsRate { get; set; }

    public int FbnmIdpk { get; set; }

    public string? FbnmName { get; set; }

    public string? FbnmShtName { get; set; }

    public DateTime? FbnmStartDate { get; set; }

    public DateTime? FbnmEndDate { get; set; }

    public bool? FbnmActive { get; set; }

    public string? FbnmRmks { get; set; }

    public int? FgrtBillNameIdfk { get; set; }

    public decimal? FgrtRegLevy { get; set; }

    public double? FgrtRegLevyx { get; set; }

    public double? FgrtTscGhcx { get; set; }

    public decimal? FgrtTscUsd { get; set; }

    public double? FgrtTscUsdx { get; set; }

    public decimal? FgrtPaymentGhc { get; set; }

    public decimal? FgrtPaymentUsd { get; set; }

    public decimal? FgrtRecBrFwdGhc { get; set; }

    public decimal? FgrtRecBrFwdUsd { get; set; }

    public decimal? FgrtAmtPayableGhc { get; set; }

    public decimal? FgrtAmtPayableUsd { get; set; }

    public double? FgrtEnergyConsumedx { get; set; }

    public decimal? FgrtAncillaryLevy { get; set; }

    public double? FgrtAncillaryLevyx { get; set; }

    public decimal? FgrtPowInfrasLevy { get; set; }

    public double? FgrtPowInfrasLevyx { get; set; }

    public decimal? FgrtPowInfrasAncillaryLevy { get; set; }

    public double? FgrtPowInfrasAncillaryLevyx { get; set; }

    public decimal? FgrtTscRegPowInfrasAncillaryLevy { get; set; }

    public double? FgrtTscRegPowInfrasAncillaryLevyx { get; set; }

    public decimal? FgrtTscRegLevy { get; set; }

    public double? FgrtTscRegLevyx { get; set; }

    public decimal? FgrtTscRegPowInfrasLevy { get; set; }

    public double? FgrtTscRegPowInfrasLevyx { get; set; }

    public decimal? FgrtTscRegAncillaryLevy { get; set; }

    public double? FgrtTscRegAncillaryLevyx { get; set; }

    public double? FgrtPowInfrasNancillaryRate { get; set; }

    public int? FgrtTscRateIdfk { get; set; }

    public int? FgrtRegRateIdfk { get; set; }

    public int? FgrtAncillaryRateIdfk { get; set; }

    public int? FgrtPowInfrasRateIdfk { get; set; }

    public int? FgrtCustTypeIdfk { get; set; }

    public int? FgrtCurrencyIdfk { get; set; }

    public int? FgrtSignedByIdfk { get; set; }

    public int? FgrtReviewedByIdfk { get; set; }

    public int? FgrtPreparedByIdfk { get; set; }

    public decimal? FgrtRegLevyRegOrg { get; set; }

    public double? FgrtRegLevyRegOrgx { get; set; }
}
