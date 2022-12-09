using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamEnergyMeterAssignment
{
    public int EmaIdpk { get; set; }

    public DateTime? EmaStartDate { get; set; }

    public DateTime? EmaEndDate { get; set; }

    public int? EmaStationIdfk { get; set; }

    public int? EmaLocationIdfk { get; set; }

    public int? EmaCustomerIdfk { get; set; }

    public int? EmaFeederIdfk { get; set; }

    public int? EmaMeterIdfk { get; set; }

    public int? EmaReportTypeIdfk { get; set; }

    public int? EmaCustomerTypeIdfk { get; set; }

    public int? EmaTscCurrencyIdfk { get; set; }

    public int? EmaRegLevyCurrencyIdfk { get; set; }

    public decimal? EmaKwhMultiplier { get; set; }

    public decimal? EmaKwMultiplier { get; set; }

    public decimal? EmaPowerFactor { get; set; }

    public decimal? EmaRegLevyRate { get; set; }

    public decimal? EmaTransServLevyRate { get; set; }

    public decimal? EmaPowInfrasLevyRate { get; set; }

    public decimal? EmaAncillaryLevyRate { get; set; }

    public decimal? EmaBillPercent { get; set; }

    public decimal? EmaCtRatio { get; set; }

    public decimal? EmaPtRatio { get; set; }

    public int? EmaGenerationPlantIdfk { get; set; }

    public int? EmaPlantLineNoIdfk { get; set; }

    public bool? EmaAssigned { get; set; }

    public bool? EmaTeeingOffMeter { get; set; }

    public bool? EmaStationService { get; set; }

    public bool? EmaCheckMeter { get; set; }

    public bool? EmaBulkSupplyPoint { get; set; }

    public bool? EmaActive { get; set; }

    public string? EmaRmks { get; set; }

    public int? EmaCreatedBy { get; set; }

    public int? EmaEditedBy { get; set; }

    public DateTime? EmaCreationDate { get; set; }

    public DateTime? EmaEditedDate { get; set; }
}
