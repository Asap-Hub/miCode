using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrOvertimeAppeal
{
    public int OapIdpk { get; set; }

    public int? OapEmpIdfk { get; set; }

    public DateTime? OapStartDate { get; set; }

    public DateTime? OapEndDate { get; set; }

    public short? OapHoursRequested { get; set; }

    public short? OapHoursApproved { get; set; }

    public string? OapActivityDetails { get; set; }

    public int? OapDeptIdfk { get; set; }

    public int? OapSectionIdfk { get; set; }

    public int? OapUnitIdfk { get; set; }

    public int? OapLocationIdfk { get; set; }

    public bool? OapSubmitted { get; set; }

    public bool? OapLocked { get; set; }

    public bool? OapReviewed { get; set; }

    public bool? OapEndorsed { get; set; }

    public bool? OapApproved { get; set; }

    public bool? OapAuthorised { get; set; }

    public bool? OapAudited { get; set; }

    public DateTime? OapSubmittedOn { get; set; }

    public DateTime? OapReviewedOn { get; set; }

    public DateTime? OapEndorsedOn { get; set; }

    public DateTime? OapApprovedOn { get; set; }

    public DateTime? OapAuthorisedOn { get; set; }

    public DateTime? OapLockedOn { get; set; }

    public int? OapAdminEmpIdfk { get; set; }

    public int? OapMgrEmpIdfk { get; set; }

    public int? OapDirEmpIdfk { get; set; }

    public int? OapCeEmpIdfk { get; set; }

    public int? OapAuditorEmpIdfk { get; set; }

    public int? OapLockedByEmpIdfk { get; set; }

    public bool? OapActive { get; set; }

    public string? OapRmks { get; set; }

    public int? OapCreatedBy { get; set; }

    public int? OapEditedBy { get; set; }

    public DateTime? OapCreationDate { get; set; }

    public DateTime? OapEditedDate { get; set; }
}
