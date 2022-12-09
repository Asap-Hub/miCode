using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdUatPrivilegesAssignment
{
    public int UpaIdpk { get; set; }

    public bool UpaTeamLead { get; set; }

    public bool UpaProcessOwner { get; set; }

    public bool UpaView { get; set; }

    public bool UpaAdmin { get; set; }

    public bool UpaSendAlerts { get; set; }

    public bool UpaSupervisor { get; set; }

    public bool UpaManager { get; set; }

    public bool UpaDirector { get; set; }

    public bool UpaActive { get; set; }

    public int EmpIdpk { get; set; }

    public string EmpStaffNo { get; set; } = null!;

    public string EmpLastName { get; set; } = null!;

    public string EmpFirstName { get; set; } = null!;

    public string EmpOtherNames { get; set; } = null!;

    public string EmpName16 { get; set; } = null!;

    public string EmpName { get; set; } = null!;

    public string EmpName1 { get; set; } = null!;

    public string EmpName2 { get; set; } = null!;

    public string EmpName3 { get; set; } = null!;

    public string EmpName4 { get; set; } = null!;

    public string UpaRmks { get; set; } = null!;

    public int UpaEmpIdfk { get; set; }

    public int? UpaCreatedBy { get; set; }

    public int? UpaEditedBy { get; set; }

    public DateTime? UpaCreationDate { get; set; }

    public DateTime? UpaEditedDate { get; set; }

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

    public bool UpaAlertFyi { get; set; }

    public int UtsIdpk { get; set; }

    public string UtsName { get; set; } = null!;

    public string UtsShtName { get; set; } = null!;

    public decimal UtsPassMark { get; set; }

    public int FmdlIdpk { get; set; }

    public string FmdlName { get; set; } = null!;

    public string FmdlShtName { get; set; } = null!;

    public int PrjIdpk { get; set; }

    public string PrjName { get; set; } = null!;

    public string PrjShtName { get; set; } = null!;

    public bool UpaTester { get; set; }

    public bool UpaResolver { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public decimal Expr1 { get; set; }

    public decimal UtsPercentagePassed { get; set; }

    public decimal UtsPercentageFailed { get; set; }

    public decimal UtsPercentageOnRetest { get; set; }

    public decimal UtsPercentageNotRun { get; set; }

    public int UtsNoOfTestCases { get; set; }

    public bool? Expr2 { get; set; }

    public int SmdIdpk { get; set; }

    public string SmdName { get; set; } = null!;

    public string SmdShtName { get; set; } = null!;

    public bool SmdActive { get; set; }
}
