using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtHrPlan
{
    public int HrpIdpk { get; set; }

    public int? HrpBudgetIdfk { get; set; }

    public int? HrpDeptIdfk { get; set; }

    public int? HrpSectionIdfk { get; set; }

    public int? HrpUnitIdfk { get; set; }

    public int? HrpJobTitleIdfk { get; set; }

    public int? HrpGradeIdfk { get; set; }

    public short? HrpEstablishment { get; set; }

    public short? HrpNoAtPost { get; set; }

    public short? HrpVacancy { get; set; }

    public short? HrpVacancyToBeFilledSubmitted { get; set; }

    public short? HrpVacancyToBeFilledApproved { get; set; }

    public short? HrpAdditionToEstablishment { get; set; }

    public string? HrpJustification { get; set; }

    public short? HrpAgeProfile1830 { get; set; }

    public short? HrpAgeProfile3140 { get; set; }

    public short? HrpAgeProfile4150 { get; set; }

    public short? HrpAgeProfile5155 { get; set; }

    public short? HrpAgeProfile5160 { get; set; }

    public bool? HrpApproved { get; set; }

    public DateTime? HrpFirstSubmissionDate { get; set; }

    public string? HrpLastSubmissionDate { get; set; }

    public DateTime? HrpApprovalDate { get; set; }

    public int? HrpApprovedBy { get; set; }

    public string? HrpApprovalRmks { get; set; }

    public string? HrpRmks { get; set; }

    public int? HrpCreatedBy { get; set; }

    public int? HrpEditedBy { get; set; }

    public DateTime? HrpCreationDate { get; set; }

    public DateTime? HrpEditedDate { get; set; }
}
