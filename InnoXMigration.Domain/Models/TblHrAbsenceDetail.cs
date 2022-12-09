using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrAbsenceDetail
{
    public int SadIdpk { get; set; }

    public DateTime? SadStartDate { get; set; }

    public DateTime? SadEndDate { get; set; }

    public int? SadEmpIdfk { get; set; }

    public int? SadReporterEmpIdfk { get; set; }

    public int? SadAbsenceTypeIdfk { get; set; }

    public string? SadReason { get; set; }

    public string? SadCategory { get; set; }

    public string? SadStatus { get; set; }

    public int? SadDuration { get; set; }

    public bool? SadOmitWeekend { get; set; }

    public int? SadApproverEmpIdfk { get; set; }

    public int? SadAuthoriserEmpIdfk { get; set; }

    public int? SadAdminEmpIdfk { get; set; }

    public int? SadDeptIdfk { get; set; }

    public int? SadSectionIdfk { get; set; }

    public int? SadUnitIdfk { get; set; }

    public bool? SadApproved { get; set; }

    public bool? SadAuthorised { get; set; }

    public int? SadSubmitterEmpIdfk { get; set; }

    public bool? SadSubmitted { get; set; }

    public bool? SadActive { get; set; }

    public string? SadRmks { get; set; }

    public int? SadCreatedBy { get; set; }

    public int? SadEditedBy { get; set; }

    public DateTime? SadCreationDate { get; set; }

    public DateTime? SadEditedDate { get; set; }
}
