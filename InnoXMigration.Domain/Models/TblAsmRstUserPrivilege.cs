using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmRstUserPrivilege
{
    public int RupIdpk { get; set; }

    public int? RupEmpIdfk { get; set; }

    public bool? RupAdmin { get; set; }

    public bool? RupManager { get; set; }

    public bool? RupDirector { get; set; }

    public bool? RupCeo { get; set; }

    public bool? RupSeeDriversCodes { get; set; }

    public bool? RupOrgAdmin { get; set; }

    public bool? RupDeptAdmin { get; set; }

    public bool? RupSectionAdmin { get; set; }

    public bool? RupUnitAdmin { get; set; }

    public bool? RupFuelAnalyst { get; set; }

    public bool? RupRecommendAllVehicleRequests { get; set; }

    public bool? RupSaveConditionReturns { get; set; }

    public bool? RupSubmitConditionReturns { get; set; }

    public bool? RupApproveFuelRequests { get; set; }

    public string? RupRmks { get; set; }

    public int? RupCreatedBy { get; set; }

    public int? RupEditedBy { get; set; }

    public DateTime? RupCreationDate { get; set; }

    public DateTime? RupEditedDate { get; set; }
}
