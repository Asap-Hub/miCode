using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsMeterReading
{
    public int MrdIdpk { get; set; }

    public int? MrdBillNameIdfk { get; set; }

    public DateTime? MrdBeginDate { get; set; }

    public DateTime? MrdEndDate { get; set; }

    public int? MrdFeederIdfk { get; set; }

    public int? MrdSubStationIdfk { get; set; }

    public int? MrdAreaIdfk { get; set; }

    public int? MrdCustIdfk { get; set; }

    public int? MrdCustTypeIdfk { get; set; }

    public int? MrdRegOrgIdfk { get; set; }

    public int? MrdMultiplierIdfk { get; set; }

    public int? MrdTransServRateIdfk { get; set; }

    public int? MrdRegLevyRateIdfk { get; set; }

    public int? MrdAncillaryRateIdfk { get; set; }

    public int? MrdPowInfrasRateIdfk { get; set; }

    public int? MrdCustCurrIdfk { get; set; }

    public double? MrdMeterReading { get; set; }

    public double? MrdPreviousReading { get; set; }

    public decimal? MrdDifference { get; set; }

    public double? MrdDifferencex { get; set; }

    public double? MrdLossofReg { get; set; }

    public decimal? MrdDifferenceLoR { get; set; }

    public double? MrdDifferenceLoRx { get; set; }

    public decimal? MrdEnergyConsumed { get; set; }

    public double? MrdEnergyConsumedx { get; set; }

    public decimal? MrdTscghc { get; set; }

    public double? MrdTscghcx { get; set; }

    public decimal? MrdTscusd { get; set; }

    public double? MrdTscusdx { get; set; }

    public decimal? MrdRegLevy { get; set; }

    public double? MrdRegLevyx { get; set; }

    public decimal? MrdRegLevyRegOrg { get; set; }

    public double? MrdRegLevyRegOrgx { get; set; }

    public decimal? MrdAncillaryLevy { get; set; }

    public double? MrdAncillaryLevyx { get; set; }

    public decimal? MrdPowInfrasLevy { get; set; }

    public double? MrdPowInfrasLevyx { get; set; }

    public decimal? MrdPowInfrasAncillaryLevy { get; set; }

    public double? MrdPowInfrasAncillaryLevyx { get; set; }

    public double? MrdMaxKwdemand { get; set; }

    public double? MrdMaxKvademand { get; set; }

    public double? MrdPowerFactor { get; set; }

    public short? MrdSign { get; set; }

    public double? MrdStatServPercent { get; set; }

    public int? MrdReviewedBy { get; set; }

    public int? MrdPreparedBy { get; set; }

    public int? MrdSignedBy { get; set; }

    public int? MrdCompIdfk { get; set; }

    public int? MrdCeoIdfk { get; set; }

    public string? MrdRmks { get; set; }

    public int? MrdCreatedBy { get; set; }

    public int? MrdEditedBy { get; set; }

    public DateTime? MrdCreationDate { get; set; }

    public DateTime? MrdEditedDate { get; set; }
}
