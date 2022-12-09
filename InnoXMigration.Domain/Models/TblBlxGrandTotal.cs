using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxGrandTotal
{
    public int FgrtIdpk { get; set; }

    public int? FgrtCustIdfk { get; set; }

    public decimal? FgrtTscGhc { get; set; }

    public double? FgrtTscGhcx { get; set; }

    public decimal? FgrtTscUsd { get; set; }

    public double? FgrtTscUsdx { get; set; }

    public decimal? FgrtRegLevy { get; set; }

    public double? FgrtRegLevyx { get; set; }

    public decimal? FgrtRegLevyRegOrg { get; set; }

    public double? FgrtRegLevyRegOrgx { get; set; }

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

    public decimal? FgrtPaymentGhc { get; set; }

    public decimal? FgrtPaymentUsd { get; set; }

    public decimal? FgrtRecBrFwdGhc { get; set; }

    public decimal? FgrtRecBrFwdUsd { get; set; }

    public decimal? FgrtAmtPayableGhc { get; set; }

    public decimal? FgrtAmtPayableUsd { get; set; }

    public decimal? FgrtEnergyConsumed { get; set; }

    public double? FgrtEnergyConsumedx { get; set; }

    public int? FgrtBillNameIdfk { get; set; }

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

    public decimal? FgrtRegRate { get; set; }

    public decimal? FgrtTsRate { get; set; }

    public int? FgrtCreatedBy { get; set; }

    public int? FgrtEditedBy { get; set; }

    public DateTime? FgrtCreationDate { get; set; }

    public DateTime? FgrtEditedDate { get; set; }
}
