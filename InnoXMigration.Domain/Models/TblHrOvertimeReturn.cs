using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrOvertimeReturn
{
    public int OtrIdpk { get; set; }

    public int? OtrEmpIdfk { get; set; }

    public DateTime? OtrStartDate { get; set; }

    public DateTime? OtrEndDate { get; set; }

    public TimeSpan? OtrDuration { get; set; }

    public int? OtrDurationSec { get; set; }

    public string? OtrActivity { get; set; }

    public string? OtrClass { get; set; }

    public string? OtrSubclass { get; set; }

    public int? OtrOvertimeTypeIdfk { get; set; }

    public string? OtrCategory { get; set; }

    public bool? OtrWeekday { get; set; }

    public bool? OtrHoliday { get; set; }

    public int? OtrJobTitleIdfk { get; set; }

    public int? OtrDeptIdfk { get; set; }

    public int? OtrSectionIdfk { get; set; }

    public int? OtrUnitIdfk { get; set; }

    public int? OtrLocationIdfk { get; set; }

    public DateTime? OtrSubmittedOn { get; set; }

    public DateTime? OtrReviewedOn { get; set; }

    public DateTime? OtrEndorsedOn { get; set; }

    public DateTime? OtrApprovedOn { get; set; }

    public DateTime? OtrAuthorisedOn { get; set; }

    public DateTime? OtrLockedOn { get; set; }

    public int? OtrAdminEmpIdfk { get; set; }

    public int? OtrMgrEmpIdfk { get; set; }

    public int? OtrDirEmpIdfk { get; set; }

    public int? OtrCeEmpIdfk { get; set; }

    public int? OtrAuditorEmpIdfk { get; set; }

    public int? OtrLockedByEmpIdfk { get; set; }

    public bool? OtrSubmitted { get; set; }

    public bool? OtrLocked { get; set; }

    public bool? OtrReviewed { get; set; }

    public bool? OtrEndorsed { get; set; }

    public bool? OtrApproved { get; set; }

    public bool? OtrAuthorised { get; set; }

    public bool? OtrAudited { get; set; }

    public bool? OtrActive { get; set; }

    public string? OtrRmks { get; set; }

    public int? OtrCreatedBy { get; set; }

    public int? OtrEditedBy { get; set; }

    public DateTime? OtrCreationDate { get; set; }

    public DateTime? OtrEditedDate { get; set; }
}
