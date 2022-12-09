using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwBlxBill
{
    public string? FbnmName { get; set; }

    public DateTime? FbnmStartDate { get; set; }

    public DateTime? FbnmEndDate { get; set; }

    public string? CustName { get; set; }

    public string? FcustShtName { get; set; }

    public string? FfdrName { get; set; }

    public short? FmrdSign { get; set; }

    public string? FbnmShtName { get; set; }

    public double? FmrdMeterReading { get; set; }

    public double? FmrdPreviousReading { get; set; }

    public decimal? FmrdDifference { get; set; }

    public double? FmrdDifferencex { get; set; }

    public decimal? FmrdDifferenceLoR { get; set; }

    public double? FmrdDifferenceLoRx { get; set; }

    public decimal? FmrdTscghc { get; set; }

    public double? FmrdTscghcx { get; set; }

    public decimal? FmrdTscusd { get; set; }

    public double? FmrdTscusdx { get; set; }

    public decimal? FmrdRegLevy { get; set; }

    public double? FmrdRegLevyx { get; set; }

    public decimal? FmrdEnergyConsumed { get; set; }

    public double? FmrdEnergyConsumedx { get; set; }

    public decimal? FmrdAncillaryLevy { get; set; }

    public double? FmrdAncillaryLevyx { get; set; }

    public decimal? FmrdPowInfrasLevy { get; set; }

    public double? FmrdPowInfrasLevyx { get; set; }

    public double? FmrdLossofReg { get; set; }

    public double? FmrdStatServPercent { get; set; }

    public double? FmrdMaxKwdemand { get; set; }

    public double? FmrdMaxKvademand { get; set; }

    public double? FmrdPowerFactor { get; set; }

    public double? FsbtRegLevyx { get; set; }

    public double? FsbtTscGhcx { get; set; }

    public double? FsbtTscUsdx { get; set; }

    public decimal? FsbtTscUsd { get; set; }

    public double? FsbtEnergyConsumedx { get; set; }

    public decimal? FsbtAncillaryLevy { get; set; }

    public double? FsbtAncillaryLevyx { get; set; }

    public decimal? FsbtPowInfrasLevy { get; set; }

    public double? FsbtPowInfrasLevyx { get; set; }

    public decimal? FsbtRegLevy { get; set; }

    public decimal? FsbtTscGhc { get; set; }

    public decimal? FsbtEnergyConsumed { get; set; }

    public decimal? FgrtRegLevy { get; set; }

    public decimal? FgrtTscGhc { get; set; }

    public decimal? FgrtTscUsd { get; set; }

    public decimal? FgrtPaymentGhc { get; set; }

    public decimal? FgrtPaymentUsd { get; set; }

    public decimal? FgrtRecBrFwdGhc { get; set; }

    public decimal? FgrtRecBrFwdUsd { get; set; }

    public decimal? FgrtAmtPayableGhc { get; set; }

    public decimal? FgrtAmtPayableUsd { get; set; }

    public double? FgrtRegLevyx { get; set; }

    public double? FgrtTscGhcx { get; set; }

    public double? FgrtTscUsdx { get; set; }

    public decimal? FgrtEnergyConsumed { get; set; }

    public double? FgrtEnergyConsumedx { get; set; }

    public decimal? FgrtRegRate { get; set; }

    public decimal? FgrtTsRate { get; set; }

    public decimal? FgrtAncillaryLevy { get; set; }

    public double? FgrtAncillaryLevyx { get; set; }

    public decimal? FgrtPowInfrasLevy { get; set; }

    public double? FgrtPowInfrasLevyx { get; set; }

    public double? FgrtPowInfrasNancillaryRate { get; set; }

    public double? FpirRate { get; set; }

    public double? FanrRate { get; set; }

    public double? FctrRate { get; set; }

    public double? FcrrTsrate { get; set; }

    public DateTime? FprbDate { get; set; }

    public int? FprbEmpIdfk { get; set; }

    public string? FprbBillName { get; set; }

    public string? FprbBillTitle { get; set; }

    public string? FprbRmks { get; set; }

    public string? PreparedByStaffNo { get; set; }

    public string? PreparedByName { get; set; }

    public string PreparedByDept { get; set; } = null!;

    public string PreparedByShtDept { get; set; } = null!;

    public string PreparedBySection { get; set; } = null!;

    public string PreparedByShtSection { get; set; } = null!;

    public string PreparedByJobTitle { get; set; } = null!;

    public int FsnbIdpk { get; set; }

    public int? FsnbEmpIdfk { get; set; }

    public string? FsnbBillName { get; set; }

    public string PreparedByShtJobTitle { get; set; } = null!;

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

    public string? FrvbBillName { get; set; }

    public int FgrtIdpk { get; set; }

    public int? FgrtCustIdfk { get; set; }

    public string? FcustAddress { get; set; }

    public string? FcustSalutation { get; set; }

    public string? FcustContact { get; set; }

    public string? FcustEmail { get; set; }

    public string? FcustMobNo { get; set; }

    public string? FcustTelNo { get; set; }

    public double? FcustCurntRlr { get; set; }

    public double? FcustCurntTsr { get; set; }

    public bool? FcustActive { get; set; }

    public double? FcrrRegRate { get; set; }

    public string? FcustName { get; set; }

    public DateTime? FfmtDate { get; set; }

    public double? FfmtMultiplier { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public int? FsbtCustTypeIdfk { get; set; }

    public int? FsbtTscRateIdfk { get; set; }

    public int? FsbtRegRateIdfk { get; set; }

    public int? FsbtAncillaryRateIdfk { get; set; }

    public int FsbtIdpk { get; set; }

    public int? FsbtCustIdfk { get; set; }

    public int? FsbtSubstationIdfk { get; set; }

    public int FmrdIdpk { get; set; }

    public int? FfdrIdpk { get; set; }

    public string? FfdrShtName { get; set; }

    public bool? FfdrActive { get; set; }

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

    public string? CurName { get; set; }

    public string? CurShtName { get; set; }

    public string? CurSymbol { get; set; }

    public bool? CurForeign { get; set; }

    public bool? CurActive { get; set; }

    public DateTime? FccyDate { get; set; }

    public int? FctpIdpk { get; set; }

    public string? FctpName { get; set; }

    public string? FctpShtName { get; set; }

    public bool? FctpActive { get; set; }

    public string? FctpRmks { get; set; }

    public int? FctpCreatedBy { get; set; }

    public DateTime? FctpCreationDate { get; set; }

    public string? FmrdRmks { get; set; }

    public int FrmkIdpk { get; set; }

    public int? FrmkCustIdfk { get; set; }

    public DateTime? FrmkDate { get; set; }

    public string? FrmkRemark { get; set; }

    public int FrvbIdpk { get; set; }

    public DateTime? FrvbDate { get; set; }

    public string? FrvbBillTitle { get; set; }

    public int? FrvbEmpIdfk { get; set; }

    public string? FrvbRmks { get; set; }

    public string? ReviewedByStaffNo { get; set; }

    public string ReviewedByDept { get; set; } = null!;

    public string ReviewedByShtDept { get; set; } = null!;

    public string ReviewedBySection { get; set; } = null!;

    public string ReviewedByShtSection { get; set; } = null!;

    public string? ReviewedByName { get; set; }

    public int FprbIdpk { get; set; }

    public string? FfmtRmks { get; set; }

    public bool? FbnmActive { get; set; }

    public string? FbnmRmks { get; set; }

    public int? FbnmEditedBy { get; set; }

    public int? FbnmCreatedBy { get; set; }

    public DateTime? FbnmCreationDate { get; set; }

    public DateTime? FbnmEditedDate { get; set; }

    public int? FmrdBillNameIdfk { get; set; }

    public int? FrmkBillNameIdfk { get; set; }

    public int? FgrtBillNameIdfk { get; set; }

    public int? FsbtBillNameIdfk { get; set; }

    public int? AreIdpk { get; set; }

    public int FbnmIdpk { get; set; }

    public int? FmrdCustIdfk { get; set; }

    public decimal? FsbtPowInfrasAncillaryLevy { get; set; }

    public double? FsbtPowInfrasAncillaryLevyx { get; set; }

    public decimal? FsbtTscRegPowInfrasAncillaryLevy { get; set; }

    public double? FsbtTscRegPowInfrasAncillaryLevyx { get; set; }

    public decimal? FsbtTscRegLevy { get; set; }

    public double? FsbtTscRegLevyx { get; set; }

    public decimal? FsbtTscRegPowInfrasLevy { get; set; }

    public double? FsbtTscRegPowInfrasLevyx { get; set; }

    public decimal? FsbtTscRegAncillaryLevy { get; set; }

    public double? FsbtTscRegAncillaryLevyx { get; set; }

    public string? FsbtPowInfrasAncillaryRate { get; set; }

    public double? FmrdPowInfrasAncillaryLevyx { get; set; }

    public decimal? FmrdPowInfrasAncillaryLevy { get; set; }

    public int? FmrdPowInfrasRateIdfk { get; set; }

    public int? FmrdCeoIdfk { get; set; }

    public int? FmrdCompIdfk { get; set; }

    public int? FmrdSignedBy { get; set; }

    public int? FmrdPreparedBy { get; set; }

    public int? FmrdReviewedBy { get; set; }

    public DateTime? FpirDate { get; set; }

    public int? FpirIdpk { get; set; }

    public DateTime? FanrDate { get; set; }

    public string? FrttShtName { get; set; }

    public string? FrttName { get; set; }

    public int? FanrIdpk { get; set; }

    public int? FmrdAncillaryRateIdfk { get; set; }

    public double? FgrtTscRegAncillaryLevyx { get; set; }

    public decimal? FgrtTscRegAncillaryLevy { get; set; }

    public double? FgrtTscRegPowInfrasLevyx { get; set; }

    public decimal? FgrtTscRegPowInfrasLevy { get; set; }

    public double? FgrtTscRegLevyx { get; set; }

    public decimal? FgrtTscRegLevy { get; set; }

    public double? FgrtTscRegPowInfrasAncillaryLevyx { get; set; }

    public decimal? FgrtTscRegPowInfrasAncillaryLevy { get; set; }

    public double? FgrtPowInfrasAncillaryLevyx { get; set; }

    public decimal? FgrtPowInfrasAncillaryLevy { get; set; }

    public int? FgrtTscRateIdfk { get; set; }

    public int? FgrtRegRateIdfk { get; set; }

    public int? FgrtAncillaryRateIdfk { get; set; }

    public int? FgrtPowInfrasRateIdfk { get; set; }

    public int? FgrtCustTypeIdfk { get; set; }

    public int? FgrtCurrencyIdfk { get; set; }

    public int? FgrtSignedByIdfk { get; set; }

    public int? FgrtReviewedByIdfk { get; set; }

    public int? FgrtPreparedByIdfk { get; set; }

    public int? FgrtRegCompIdfk { get; set; }

    public int? FgrtCompIdfk { get; set; }

    public decimal? FsbtRegLevyRegOrg { get; set; }

    public double? FsbtRegLevyRegOrgx { get; set; }

    public decimal? FgrtRegLevyRegOrg { get; set; }

    public double? FgrtRegLevyRegOrgx { get; set; }

    public int StnIdpk { get; set; }

    public string StnName { get; set; } = null!;

    public string StnShtName { get; set; } = null!;

    public bool StnActive { get; set; }

    public string StnRmks { get; set; } = null!;
}
