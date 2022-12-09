using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrJobDescription
{
    public int JbdIdpk { get; set; }

    public DateTime? JbdStartDate { get; set; }

    public int? JbdEmpIdfk { get; set; }

    public int? JbdJobTitleIdfk { get; set; }

    public int? JbdGradeIdfk { get; set; }

    public int? JbdStepIdfk { get; set; }

    public int? JbdDeptIdfk { get; set; }

    public int? JbdSectionIdfk { get; set; }

    public byte[]? JbdDoc { get; set; }

    public bool? JbdSubmitted { get; set; }

    public int? JbdSubmittedByEmpIdfk { get; set; }

    public DateTime? JbdDateSubmitted { get; set; }

    public bool? JbdApproved { get; set; }

    public int? JbdApprovedByEmpIdfk { get; set; }

    public DateTime? JbdDateApproved { get; set; }

    public bool? JbdActive { get; set; }

    public string? JbdRmks { get; set; }

    public string? JbdCreatedBy { get; set; }

    public int? JbdEditedBy { get; set; }

    public DateTime? JbdCreationDate { get; set; }

    public DateTime? JbdEditedDate { get; set; }
}
