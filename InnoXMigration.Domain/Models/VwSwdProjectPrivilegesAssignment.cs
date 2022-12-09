using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdProjectPrivilegesAssignment
{
    public int SpaIdpk { get; set; }

    public bool SpaView { get; set; }

    public bool SpaSendAlerts { get; set; }

    public bool SpaActive { get; set; }

    public int EmpIdpk { get; set; }

    public string EmpStaffNo { get; set; } = null!;

    public string EmpLastName { get; set; } = null!;

    public string EmpFirstName { get; set; } = null!;

    public string EmpOtherNames { get; set; } = null!;

    public string EmpName { get; set; } = null!;

    public string EmpName1 { get; set; } = null!;

    public string EmpName2 { get; set; } = null!;

    public string EmpName3 { get; set; } = null!;

    public string EmpName4 { get; set; } = null!;

    public string SpaRmks { get; set; } = null!;

    public int SpaEmpIdfk { get; set; }

    public int? SpaCreatedBy { get; set; }

    public int? SpaEditedBy { get; set; }

    public DateTime? SpaCreationDate { get; set; }

    public DateTime? SpaEditedDate { get; set; }

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public string EmpMobNox { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public bool SpaAlertFyi { get; set; }

    public bool? SpaProjectManager { get; set; }

    public bool? SpaSecretary { get; set; }

    public bool? SpaSponsor { get; set; }

    public int PsnIdpk { get; set; }

    public string? PsnName { get; set; }

    public string? PsnShtName { get; set; }

    public int PrjIdpk { get; set; }

    public string? PrjName { get; set; }

    public string? PrjShtName { get; set; }

    public bool? SpaTeamLead { get; set; }

    public bool? SpaDirector { get; set; }
}
