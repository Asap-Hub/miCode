using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsUserPrivilege
{
    public int? EmpIdpk { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpName { get; set; }

    public string? EmpMobNox { get; set; }

    public string? EmpName12 { get; set; }

    public string? EmpStaffNo { get; set; }

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

    public string? DptShtName { get; set; }

    public string? SxnShtName { get; set; }

    public string? LocShtName { get; set; }
}
