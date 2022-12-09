using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsGrandTotal
{
    public int GttIdpk { get; set; }

    public int? GttCustIdfk { get; set; }

    public decimal? GttTscGhc { get; set; }

    public double? GttTscGhcx { get; set; }

    public decimal? GttTscUsd { get; set; }

    public double? GttTscUsdx { get; set; }

    public decimal? GttRegLevy { get; set; }

    public double? GttRegLevyx { get; set; }

    public decimal? GttRegLevyRegOrg { get; set; }

    public double? GttRegLevyRegOrgx { get; set; }

    public decimal? GttAncillaryLevy { get; set; }

    public double? GttAncillaryLevyx { get; set; }

    public decimal? GttPowInfrasLevy { get; set; }

    public double? GttPowInfrasLevyx { get; set; }

    public decimal? GttPowInfrasAncillaryLevy { get; set; }

    public double? GttPowInfrasAncillaryLevyx { get; set; }

    public decimal? GttTscRegPowInfrasAncillaryLevy { get; set; }

    public double? GttTscRegPowInfrasAncillaryLevyx { get; set; }

    public decimal? GttTscRegLevy { get; set; }

    public double? GttTscRegLevyx { get; set; }

    public decimal? GttTscRegPowInfrasLevy { get; set; }

    public double? GttTscRegPowInfrasLevyx { get; set; }

    public decimal? GttTscRegAncillaryLevy { get; set; }

    public double? GttTscRegAncillaryLevyx { get; set; }

    public double? GttPowInfrasNancillaryRate { get; set; }

    public decimal? GttPaymentGhc { get; set; }

    public decimal? GttPaymentUsd { get; set; }

    public decimal? GttRecBrFwdGhc { get; set; }

    public decimal? GttRecBrFwdUsd { get; set; }

    public decimal? GttAmtPayableGhc { get; set; }

    public decimal? GttAmtPayableUsd { get; set; }

    public decimal? GttEnergyConsumed { get; set; }

    public double? GttEnergyConsumedx { get; set; }

    public int? GttBillNameIdfk { get; set; }

    public int? GttTscRateIdfk { get; set; }

    public int? GttRegRateIdfk { get; set; }

    public int? GttAncillaryRateIdfk { get; set; }

    public int? GttPowInfrasRateIdfk { get; set; }

    public int? GttCustTypeIdfk { get; set; }

    public int? GttCurrencyIdfk { get; set; }

    public int? GttSignedByIdfk { get; set; }

    public int? GttReviewedByIdfk { get; set; }

    public int? GttPreparedByIdfk { get; set; }

    public int? GttRegCompIdfk { get; set; }

    public int? GttCompIdfk { get; set; }

    public decimal? GttRegRate { get; set; }

    public decimal? GttTsRate { get; set; }

    public int? GttCreatedBy { get; set; }

    public int? GttEditedBy { get; set; }

    public DateTime? GttCreationDate { get; set; }

    public DateTime? GttEditedDate { get; set; }
}
