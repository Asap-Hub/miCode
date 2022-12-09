using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsMaintenanceActivity
{
    public int MtaIdpk { get; set; }

    public int? MtaServiceRequestIdfk { get; set; }

    public int? MtaVehicleAssignmentIdfk { get; set; }

    public int? MtaRequisitionIdfk { get; set; }

    public DateTime? MtaDateIn { get; set; }

    public DateTime? MtaDateOut { get; set; }

    public string? MtaJobNo { get; set; }

    public int? MtaMaintenanceTypeIdfk { get; set; }

    public string? MtaArrivalCondition { get; set; }

    public string? MtaJobSummary { get; set; }

    public decimal? MtaSpeedoIn { get; set; }

    public decimal? MtaSpeedoOut { get; set; }

    public int? MtaFuelLevelInIdfk { get; set; }

    public int? MtaFuelLevelOutIdfk { get; set; }

    public string? MtaDebitCriteria { get; set; }

    public int? MtaDeptIdfk { get; set; }

    public int? MtaSectionIdfk { get; set; }

    public int? MtaUnitIdfk { get; set; }

    public bool? MtaOpened { get; set; }

    public bool? MtaDone { get; set; }

    public string? MtaActivityUpdate { get; set; }

    public decimal? MtaPercentComplete { get; set; }

    public DateTime? MtaDateUpdated { get; set; }

    public DateTime? MtaCompletionDate { get; set; }

    public bool? MtaActive { get; set; }

    public string? MtaRmks { get; set; }

    public string? MtaCreatedBy { get; set; }

    public int? MtaEditedBy { get; set; }

    public DateTime? MtaCreationDate { get; set; }

    public DateTime? MtaEditedDate { get; set; }
}
