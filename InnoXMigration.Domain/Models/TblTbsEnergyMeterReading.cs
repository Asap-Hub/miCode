using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsEnergyMeterReading
{
    public int EmrIdpk { get; set; }

    public int? EmrBillNameIdfk { get; set; }

    public DateTime? EmrBeginDate { get; set; }

    public DateTime? EmrEndDate { get; set; }

    public int? EmrFeederIdfk { get; set; }

    public int? EmrMeterIdfk { get; set; }

    public int? EmrSubStationIdfk { get; set; }

    public int? EmrLocationIdfk { get; set; }

    public int? EmrCustomerIdfk { get; set; }

    public int? EmrCustomerTypeIdfk { get; set; }

    public int? EmrRegulatoryOrganisationIdfk { get; set; }

    public int? EmrMultiplierIdfk { get; set; }

    public int? EmrTransmissionServiceRateIdfk { get; set; }

    public int? EmrRegulatoryLevyRateIdfk { get; set; }

    public int? EmrAncillaryRateIdfk { get; set; }

    public int? EmrPowerInfrastructureRateIdfk { get; set; }

    public int? EmrCustomerCurrencyIdfk { get; set; }

    public double? EmrMeterReading { get; set; }

    public double? EmrPreviousReading { get; set; }

    public decimal? EmrDifference { get; set; }

    public double? EmrDifferencex { get; set; }

    public double? EmrLossofRegistration { get; set; }

    public decimal? EmrDifferenceLoR { get; set; }

    public double? EmrDifferenceLoRx { get; set; }

    public decimal? EmrEnergyConsumed { get; set; }

    public double? EmrEnergyConsumedx { get; set; }

    public decimal? EmrTscLocal { get; set; }

    public double? EmrTscLocalx { get; set; }

    public decimal? EmrTscForex { get; set; }

    public double? EmrTscForexx { get; set; }

    public decimal? EmrRegulatoryLevy { get; set; }

    public double? EmrRegulatoryLevyx { get; set; }

    public decimal? EmrRegulatoryLevyRegulatoryOrganisation { get; set; }

    public double? EmrRegulatoryLevyRegulatoryOrganisationx { get; set; }

    public decimal? EmrAncillaryLevy { get; set; }

    public double? EmrAncillaryLevyx { get; set; }

    public decimal? EmrPowerInfrastructureLevy { get; set; }

    public double? EmrPowerInfrastructureLevyx { get; set; }

    public decimal? EmrPowerInfrastructureAncillaryLevy { get; set; }

    public double? EmrPowerInfrastructureAncillaryLevyx { get; set; }

    public double? EmrMaximumKwDemand { get; set; }

    public double? EmrMaximumKvaDemand { get; set; }

    public double? EmrPowerFactor { get; set; }

    public short? EmrSign { get; set; }

    public double? EmrStationServicePercent { get; set; }

    public int? EmrReviewedBy { get; set; }

    public int? EmrPreparedBy { get; set; }

    public int? EmrSignedBy { get; set; }

    public int? EmrCompanyIdfk { get; set; }

    public int? EmrCeoIdfk { get; set; }

    public bool? EmrForBilling { get; set; }

    public bool? EmrActive { get; set; }

    public string? EmrRmks { get; set; }

    public int? EmrCreatedBy { get; set; }

    public int? EmrEditedBy { get; set; }

    public DateTime? EmrCreationDate { get; set; }

    public DateTime? EmrEditedDate { get; set; }
}
