using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwBgtHrPlan
{
    public int HrpIdpk { get; set; }

    public int? HrpBudgetIdfk { get; set; }

    public int? HrpDeptIdfk { get; set; }

    public int? HrpSectionIdfk { get; set; }

    public int? HrpUnitIdfk { get; set; }

    public int? HrpJobTitleIdfk { get; set; }

    public int? HrpGradeIdfk { get; set; }

    public short HrpEstablishment { get; set; }

    public short HrpNoAtPost { get; set; }

    public short HrpVacancy { get; set; }

    public short HrpVacancyToBeFilledSubmitted { get; set; }

    public short HrpVacancyToBeFilledApproved { get; set; }

    public short HrpAdditionToEstablishment { get; set; }

    public string HrpJustification { get; set; } = null!;

    public short? HrpAgeProfile1830 { get; set; }

    public short? HrpAgeProfile3140 { get; set; }

    public short? HrpAgeProfile4150 { get; set; }

    public short? HrpAgeProfile5155 { get; set; }

    public short? HrpAgeProfile5160 { get; set; }

    public bool HrpApproved { get; set; }

    public DateTime? HrpFirstSubmissionDate { get; set; }

    public string? HrpLastSubmissionDate { get; set; }

    public DateTime? HrpApprovalDate { get; set; }

    public int? HrpApprovedBy { get; set; }

    public string? HrpApprovalRmks { get; set; }

    public string? HrpRmks { get; set; }

    public int BgtIdpk { get; set; }

    public string? BgtName { get; set; }

    public string? BgtShtName { get; set; }

    public DateTime? BgtStartDate { get; set; }

    public DateTime? BgtEndDate { get; set; }

    public bool? BgtActive { get; set; }

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int? SxnDeptIdfk { get; set; }

    public string? SxnCode { get; set; }

    public bool? SxnActive { get; set; }

    public int UntIdpk { get; set; }

    public string UntName { get; set; } = null!;

    public string UntShtName { get; set; } = null!;

    public string UntCode { get; set; } = null!;

    public bool? UntActive { get; set; }

    public int FjbtIdpk { get; set; }

    public string FjbtName { get; set; } = null!;

    public string FjbtShtName { get; set; } = null!;

    public bool FjbtActive { get; set; }

    public int FgrdIdpk { get; set; }

    public string FgrdName { get; set; } = null!;

    public string FgrdShtName { get; set; } = null!;

    public bool FgrdActive { get; set; }

    public string FgrdRmks { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public string? DptCode { get; set; }

    public bool? DptActive { get; set; }
}
