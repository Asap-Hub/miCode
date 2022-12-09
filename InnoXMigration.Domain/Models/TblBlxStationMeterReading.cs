using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxStationMeterReading
{
    public int SmrIdpk { get; set; }

    public DateTime? SmrDate { get; set; }

    public int? SmrMeterAssignmentIdfk { get; set; }

    public decimal? SmrCurrentActiveEnergy { get; set; }

    public decimal? SmrPreviousActiveEnergy { get; set; }

    public decimal? SmrActiveEnergyDifference { get; set; }

    public decimal? SmrActiveEnergyLossOfRegistration { get; set; }

    public decimal? SmrActiveEnergyConsumed { get; set; }

    public decimal? SmrCurrentReactiveEnergy { get; set; }

    public decimal? SmrPreviousReactiveEnergy { get; set; }

    public decimal? SmrReactiveEnergyDifference { get; set; }

    public decimal? SmrReactiveEnergyConsumed { get; set; }

    public decimal? SmrReactiveEnergyLossOfRegistration { get; set; }

    public decimal? SmrMaximumDemand { get; set; }

    public bool? SmrForBilling { get; set; }

    public bool? SmrActive { get; set; }

    public string? SmrRmks { get; set; }

    public int? SmrCreatedBy { get; set; }

    public int? SmrEditedBy { get; set; }

    public DateTime? SmrCreationDate { get; set; }

    public DateTime? SmrEditedDate { get; set; }
}
