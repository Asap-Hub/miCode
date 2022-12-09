using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAmgMeetingAttendance
{
    public int MatIdpk { get; set; }

    public int? MatEmpIdfk { get; set; }

    public int? MatMeetingDetailIdfk { get; set; }

    public int? MatAttendanceCategoryIdfk { get; set; }

    public int? MatDeptIdfk { get; set; }

    public int? MatSectionIdfk { get; set; }

    public int? MatLocationIdfk { get; set; }

    public DateTime? MatStaffInTime { get; set; }

    public DateTime? MatStaffOutTime { get; set; }

    public bool? MatVisitor { get; set; }

    public bool? MatSubmitted { get; set; }

    public bool? MatAcknowledged { get; set; }

    public int? MatSubmittedByEmpIdfk { get; set; }

    public int? MatAcknowledgedByEmpIdfk { get; set; }

    public DateTime? MatSubmittedOn { get; set; }

    public DateTime? MatAcknowledgedOn { get; set; }

    public bool? MatDeleted { get; set; }

    public DateTime? MatDeletedOn { get; set; }

    public int? MatDeletedByEmpIdfk { get; set; }

    public string? MatDeletionReason { get; set; }

    public bool? MatActive { get; set; }

    public string? MatRmks { get; set; }

    public int? MatCreatedBy { get; set; }

    public int? MatEditedBy { get; set; }

    public DateTime? MatCreationDate { get; set; }

    public DateTime? MatEditedDate { get; set; }
}
