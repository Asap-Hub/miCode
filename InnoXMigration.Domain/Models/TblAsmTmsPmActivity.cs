using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsPmActivity
{
    public int PmaIdpk { get; set; }

    public int? PmaVehicleDetailIdfk { get; set; }

    public int? PmaDriverEmpIdfk { get; set; }

    public int? PmaWorkshopIdfk { get; set; }

    public DateTime? PmaDateIn { get; set; }

    public DateTime? PmaDateOut { get; set; }

    public int? PmaMaintenanceTypeIdfk { get; set; }

    public int? PmaRequestIdfk { get; set; }

    public string? PmaArrivalCondition { get; set; }

    public string? PmaNotes { get; set; }

    public decimal? PmaOdometerIn { get; set; }

    public decimal? PmaOdometerOut { get; set; }

    public int? PmaFuelLevelInIdfk { get; set; }

    public int? PmaFuelLevelOutIdfk { get; set; }

    public int? PmaDeptIdfk { get; set; }

    public int? PmaSectionIdfk { get; set; }

    public int? PmaUnitIdfk { get; set; }

    public bool? PmaOpened { get; set; }

    public bool? PmaDone { get; set; }

    public string? PmaActivityUpdate { get; set; }

    public decimal? PmaPercentComplete { get; set; }

    public DateTime? PmaDateUpdated { get; set; }

    public DateTime? PmaCompletionDate { get; set; }

    public bool? PmaActive { get; set; }

    public string? PmaRmks { get; set; }

    public string? PmaCreatedBy { get; set; }

    public int? PmaEditedBy { get; set; }

    public DateTime? PmaCreationDate { get; set; }

    public DateTime? PmaEditedDate { get; set; }
}
