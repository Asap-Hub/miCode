using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxSubTotal
{
    public int FsbtIdpk { get; set; }

    public int? FsbtSubstationIdfk { get; set; }

    public int? FsbtBillNameIdfk { get; set; }

    public decimal? FsbtTscGhc { get; set; }

    public double? FsbtTscGhcx { get; set; }

    public decimal? FsbtTscUsd { get; set; }

    public double? FsbtTscUsdx { get; set; }

    public decimal? FsbtRegLevy { get; set; }

    public double? FsbtRegLevyx { get; set; }

    public decimal? FsbtRegLevyRegOrg { get; set; }

    public double? FsbtRegLevyRegOrgx { get; set; }

    public decimal? FsbtAncillaryLevy { get; set; }

    public double? FsbtAncillaryLevyx { get; set; }

    public decimal? FsbtPowInfrasLevy { get; set; }

    public double? FsbtPowInfrasLevyx { get; set; }

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

    public decimal? FsbtEnergyConsumed { get; set; }

    public double? FsbtEnergyConsumedx { get; set; }

    public string? FsbtPowInfrasAncillaryRate { get; set; }

    public int? FsbtCustIdfk { get; set; }

    public int? FsbtCustTypeIdfk { get; set; }

    public int? FsbtTscRateIdfk { get; set; }

    public int? FsbtRegRateIdfk { get; set; }

    public int? FsbtAncillaryRateIdfk { get; set; }

    public int? FsbtPowInfrasRateIdfk { get; set; }

    public int? FsbtRegCompIdfk { get; set; }

    public int? FsbtCurrencyIdfk { get; set; }

    public int? FsbtPreparedByIdfk { get; set; }

    public int? FsbtReviewedByIdfk { get; set; }

    public int? FsbtSignedByIdfk { get; set; }

    public int? FsbtCompIdfk { get; set; }

    public decimal? FsbtRegRate { get; set; }

    public decimal? FsbtTsRate { get; set; }

    public int? FsbtCreatedBy { get; set; }

    public int? FsbtEditedBy { get; set; }

    public DateTime? FsbtCreationDate { get; set; }

    public DateTime? FsbtEditedDate { get; set; }
}
