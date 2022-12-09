using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsSubTotal
{
    public int SbtIdpk { get; set; }

    public int? SbtSubstationIdfk { get; set; }

    public int? SbtBillNameIdfk { get; set; }

    public decimal? SbtTscGhc { get; set; }

    public double? SbtTscGhcx { get; set; }

    public decimal? SbtTscUsd { get; set; }

    public double? SbtTscUsdx { get; set; }

    public decimal? SbtRegLevy { get; set; }

    public double? SbtRegLevyx { get; set; }

    public decimal? SbtRegLevyRegOrg { get; set; }

    public double? SbtRegLevyRegOrgx { get; set; }

    public decimal? SbtAncillaryLevy { get; set; }

    public double? SbtAncillaryLevyx { get; set; }

    public decimal? SbtPowInfrasLevy { get; set; }

    public double? SbtPowInfrasLevyx { get; set; }

    public decimal? SbtPowInfrasAncillaryLevy { get; set; }

    public double? SbtPowInfrasAncillaryLevyx { get; set; }

    public decimal? SbtTscRegPowInfrasAncillaryLevy { get; set; }

    public double? SbtTscRegPowInfrasAncillaryLevyx { get; set; }

    public decimal? SbtTscRegLevy { get; set; }

    public double? SbtTscRegLevyx { get; set; }

    public decimal? SbtTscRegPowInfrasLevy { get; set; }

    public double? SbtTscRegPowInfrasLevyx { get; set; }

    public decimal? SbtTscRegAncillaryLevy { get; set; }

    public double? SbtTscRegAncillaryLevyx { get; set; }

    public decimal? SbtEnergyConsumed { get; set; }

    public double? SbtEnergyConsumedx { get; set; }

    public string? SbtPowInfrasAncillaryRate { get; set; }

    public int? SbtCustIdfk { get; set; }

    public int? SbtCustTypeIdfk { get; set; }

    public int? SbtTscRateIdfk { get; set; }

    public int? SbtRegRateIdfk { get; set; }

    public int? SbtAncillaryRateIdfk { get; set; }

    public int? SbtPowInfrasRateIdfk { get; set; }

    public int? SbtRegCompIdfk { get; set; }

    public int? SbtCurrencyIdfk { get; set; }

    public int? SbtPreparedByIdfk { get; set; }

    public int? SbtReviewedByIdfk { get; set; }

    public int? SbtSignedByIdfk { get; set; }

    public int? SbtCompIdfk { get; set; }

    public decimal? SbtRegRate { get; set; }

    public decimal? SbtTsRate { get; set; }

    public int? SbtCreatedBy { get; set; }

    public int? SbtEditedBy { get; set; }

    public DateTime? SbtCreationDate { get; set; }

    public DateTime? SbtEditedDate { get; set; }
}
