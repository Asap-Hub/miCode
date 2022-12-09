using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsUserPrivilege
{
    public int TupIdpk { get; set; }

    public int? TupEmpIdfk { get; set; }

    public bool? TupSysAdmin { get; set; }

    public bool? TupManager { get; set; }

    public bool? TupDirector { get; set; }

    public bool? TupCeo { get; set; }

    public bool? TupSeeDriversCodes { get; set; }

    public bool? TupOrgAdmin { get; set; }

    public bool? TupDeptAdmin { get; set; }

    public bool? TupSectionAdmin { get; set; }

    public bool? TupUnitAdmin { get; set; }

    public bool? TupFuelAnalyst { get; set; }

    public bool? TupRecommendAllVehicleRequests { get; set; }

    public bool? TupSaveConditionReturns { get; set; }

    public bool? TupSubmitConditionReturns { get; set; }

    public bool? TupApproveFuelRequests { get; set; }

    public bool? TupTransportSupervisor { get; set; }

    public string? TupRmks { get; set; }

    public int? TupCreatedBy { get; set; }

    public int? TupEditedBy { get; set; }

    public DateTime? TupCreationDate { get; set; }

    public DateTime? TupEditedDate { get; set; }
}
