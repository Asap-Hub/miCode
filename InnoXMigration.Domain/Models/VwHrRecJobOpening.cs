using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrRecJobOpening
{
    public int? ReqDeptIdpk { get; set; }

    public string? ReqDeptName { get; set; }

    public string? ReqDeptShtName { get; set; }

    public int? ReqSxnIdpk { get; set; }

    public string? ReqSxnName { get; set; }

    public string? ReqSxnShtName { get; set; }

    public int? ReqLocIdpk { get; set; }

    public string? ReqLocName { get; set; }

    public string? ReqLocShtName { get; set; }

    public int? ReqJbtIdpk { get; set; }

    public string? ReqJbtName { get; set; }

    public string? ReqJbtShtName { get; set; }

    public bool? ReqIsCeo { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public string? SxnShtName { get; set; }

    public int? JobIdpk { get; set; }

    public string? JobName { get; set; }

    public string? JobShtName { get; set; }

    public int? JlvIdpk { get; set; }

    public string? JlvName { get; set; }

    public string? JlvShtName { get; set; }

    public int? GrdIdpk { get; set; }

    public string? GrdName { get; set; }

    public string? GrdShtName { get; set; }

    public int? StpIdpk { get; set; }

    public string? StpName { get; set; }

    public string? StpShtName { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public int? RjoDeptIdfk { get; set; }

    public int? RjoSectionIdfk { get; set; }

    public int? RjoJobIdfk { get; set; }

    public int? RjoJobLevelIdfk { get; set; }

    public int? RjoGradeIdfk { get; set; }

    public int? RjoStepIdfk { get; set; }

    public int RjoIdpk { get; set; }

    public int? RjoProjectIdfk { get; set; }

    public int? RjoRequesterEmpIdfk { get; set; }

    public DateTime? RjoStartDate { get; set; }

    public DateTime? RjoEndDate { get; set; }

    public int? ReqEmpIdpk { get; set; }

    public string? ReqStaffNo { get; set; }

    public string? ReqLastName { get; set; }

    public string? ReqFirstName { get; set; }

    public string? ReqOtherNames { get; set; }

    public string? ReqName { get; set; }

    public int? RjoLocationIdfk { get; set; }

    public bool? RjoInternalOpening { get; set; }

    public bool? RjoExternalOpening { get; set; }

    public bool? RjoInterviewRequired { get; set; }

    public bool? RjoSubmitted { get; set; }

    public bool? RjoHrPersonnelAlerted { get; set; }

    public int? RjoSubmittedByEmpIdfk { get; set; }

    public DateTime? RjoSubmittedOn { get; set; }

    public bool? RjoActive { get; set; }

    public string? RjoRmks { get; set; }

    public int? RjoCreatedBy { get; set; }

    public DateTime? RjoCreationDate { get; set; }

    public short? RjoNoRequired { get; set; }

    public short? RjoNoOfApplicants { get; set; }

    public short? RjoNoInterviewed { get; set; }

    public short? RjoNoEmployed { get; set; }

    public bool? RjoPublished { get; set; }

    public int? RjoPublishedByEmpIdfk { get; set; }

    public bool? RjoAcknowledged { get; set; }

    public bool? RjoApproved { get; set; }
}
