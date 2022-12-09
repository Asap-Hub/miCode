using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxMeterReading
{
    public int FmrdIdpk { get; set; }

    public int? FmrdBillNameIdfk { get; set; }

    public DateTime? FmrdBeginDate { get; set; }

    public DateTime? FmrdEndDate { get; set; }

    public int? FmrdFeederIdfk { get; set; }

    public int? FmrdSubStationIdfk { get; set; }

    public int? FmrdAreaIdfk { get; set; }

    public int? FmrdCustIdfk { get; set; }

    public int? FmrdCustTypeIdfk { get; set; }

    public int? FmrdRegOrgIdfk { get; set; }

    public int? FmrdMultiplierIdfk { get; set; }

    public int? FmrdTransServRateIdfk { get; set; }

    public int? FmrdRegLevyRateIdfk { get; set; }

    public int? FmrdAncillaryRateIdfk { get; set; }

    public int? FmrdPowInfrasRateIdfk { get; set; }

    public int? FmrdCustCurrIdfk { get; set; }

    public double? FmrdMeterReading { get; set; }

    public double? FmrdPreviousReading { get; set; }

    public decimal? FmrdDifference { get; set; }

    public double? FmrdDifferencex { get; set; }

    public double? FmrdLossofReg { get; set; }

    public decimal? FmrdDifferenceLoR { get; set; }

    public double? FmrdDifferenceLoRx { get; set; }

    public decimal? FmrdEnergyConsumed { get; set; }

    public double? FmrdEnergyConsumedx { get; set; }

    public decimal? FmrdTscghc { get; set; }

    public double? FmrdTscghcx { get; set; }

    public decimal? FmrdTscusd { get; set; }

    public double? FmrdTscusdx { get; set; }

    public decimal? FmrdRegLevy { get; set; }

    public double? FmrdRegLevyx { get; set; }

    public decimal? FmrdRegLevyRegOrg { get; set; }

    public double? FmrdRegLevyRegOrgx { get; set; }

    public decimal? FmrdAncillaryLevy { get; set; }

    public double? FmrdAncillaryLevyx { get; set; }

    public decimal? FmrdPowInfrasLevy { get; set; }

    public double? FmrdPowInfrasLevyx { get; set; }

    public decimal? FmrdPowInfrasAncillaryLevy { get; set; }

    public double? FmrdPowInfrasAncillaryLevyx { get; set; }

    public double? FmrdMaxKwdemand { get; set; }

    public double? FmrdMaxKvademand { get; set; }

    public double? FmrdPowerFactor { get; set; }

    public short? FmrdSign { get; set; }

    public double? FmrdStatServPercent { get; set; }

    public int? FmrdReviewedBy { get; set; }

    public int? FmrdPreparedBy { get; set; }

    public int? FmrdSignedBy { get; set; }

    public int? FmrdCompIdfk { get; set; }

    public int? FmrdCeoIdfk { get; set; }

    public string? FmrdRmks { get; set; }

    public int? FmrdCreatedBy { get; set; }

    public int? FmrdEditedBy { get; set; }

    public DateTime? FmrdCreationDate { get; set; }

    public DateTime? FmrdEditedDate { get; set; }
}
