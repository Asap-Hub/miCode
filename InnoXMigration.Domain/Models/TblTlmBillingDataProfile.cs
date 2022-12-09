using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTlmBillingDataProfile
{
    public int BdpIdpk { get; set; }

    public int? BdpMeterAssignmentIdfk { get; set; }

    public DateTime? BdpDate { get; set; }

    public string? BdpCounter { get; set; }

    public decimal? BdpActiveEnergyExportkWh { get; set; }

    public decimal? BdpActiveEnergyImportkWh { get; set; }

    public decimal? BdpReactiveEnergyExportkvarh { get; set; }

    public decimal? BdpReactiveEnergyImportkvarh { get; set; }

    public decimal? BdpApparentEnergyExportkVah { get; set; }

    public decimal? BdpApparentEnergyImportkVah { get; set; }

    public decimal? BdpAverageDemandExporkW { get; set; }

    public decimal? BdpAverageDemandActivePowerExportkW { get; set; }

    public DateTime? BdpAverageDemandActivePowerExportkWtime { get; set; }

    public DateTime? BdpAverageDemandExportKwTime { get; set; }

    public decimal? BdpAverageDemandActivePowerImportkW { get; set; }

    public DateTime? BdpAverageDemandActivePowerImportkWtime { get; set; }

    public decimal? BdpAverageDemandReactivePowerExportkvar { get; set; }

    public DateTime? BdpAverageDemandReactivePowerExportkvarTime { get; set; }

    public decimal? BdpAverageDemandReactivePowerImportkvar { get; set; }

    public DateTime? BdpAverageDemandReactivePowerImportkvarTime { get; set; }

    public decimal? BdpAverageApparentPowerDemandExportkVa { get; set; }

    public DateTime? BdpAverageApparentPowerDemandExportkVatime { get; set; }

    public decimal? BdpAverageApparentPowerDemandImportkVa { get; set; }

    public DateTime? BdpAverageApparentPowerDemandImportkVatime { get; set; }

    public decimal? BdpPowerFactor { get; set; }

    public bool? BdpActive { get; set; }

    public string? BdpRmks { get; set; }

    public int? BdpCreatedBy { get; set; }

    public int? BdpEditedBy { get; set; }

    public DateTime? BdpCreationDate { get; set; }

    public DateTime? BdpEditedDate { get; set; }
}
