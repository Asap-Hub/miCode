using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrAbsenceDetail
{
    public int SadIdpk { get; set; }

    public DateTime? SadStartDate { get; set; }

    public DateTime? SadEndDate { get; set; }

    public int? SadEmpIdfk { get; set; }

    public int? SadReporterEmpIdfk { get; set; }

    public int? SadAbsenceTypeIdfk { get; set; }

    public string SadReason { get; set; } = null!;

    public int SadApproverEmpIdfk { get; set; }

    public int SadAuthoriserEmpIdfk { get; set; }

    public int SadAdminEmpIdfk { get; set; }

    public int SadDeptIdfk { get; set; }

    public int SadSectionIdfk { get; set; }

    public int SadUnitIdfk { get; set; }

    public bool SadActive { get; set; }

    public string SadRmks { get; set; } = null!;

    public int? SadCreatedBy { get; set; }

    public int AtpIdpk { get; set; }

    public string? AtpName { get; set; }

    public string? AtpShtName { get; set; }

    public bool? AtpActive { get; set; }

    public int AbsenteeEmpId { get; set; }

    public string AbsenteeStaffNo { get; set; } = null!;

    public string AbsenteeLname { get; set; } = null!;

    public string AbsenteeFname { get; set; } = null!;

    public string AbsenteeOnames { get; set; } = null!;

    public string AbsenteeEmpName { get; set; } = null!;

    public string AbsenteeEmpName1 { get; set; } = null!;

    public string AbsenteeEmpName2 { get; set; } = null!;

    public string AbsenteeEmpName3 { get; set; } = null!;

    public string AbsenteeEmpName4 { get; set; } = null!;

    public string AbsenteeEmpName5 { get; set; } = null!;

    public string AbsenteeEmpName12 { get; set; } = null!;

    public bool AbsenteeVisible { get; set; }

    public int AbsenteeDptId { get; set; }

    public string AbsenteeDptName { get; set; } = null!;

    public string AbsenteeDptShtName { get; set; } = null!;

    public bool AbsenteeActive { get; set; }

    public int AbsenteeSxnId { get; set; }

    public string AbsenteeSxnName { get; set; } = null!;

    public string AbsenteeSxnShtName { get; set; } = null!;

    public int AbsenteeJbtId { get; set; }

    public string AbsenteeJbtName { get; set; } = null!;

    public string AbsenteeJbtShtName { get; set; } = null!;

    public string AbsenteeMobNox { get; set; } = null!;

    public string AbsenteeMobNo { get; set; } = null!;

    public string AbsenteePlc { get; set; } = null!;

    public int AbsenteeLocId { get; set; }

    public string AbsenteeLocName { get; set; } = null!;

    public string AbsenteeLocShtName { get; set; } = null!;

    public int ReporterEmpId { get; set; }

    public string ReporterStaffNo { get; set; } = null!;

    public string ReporterLname { get; set; } = null!;

    public string ReporterFname { get; set; } = null!;

    public string ReporterOnames { get; set; } = null!;

    public string ReporterEmpName { get; set; } = null!;

    public string ReporterEmpName1 { get; set; } = null!;

    public string ReporterEmpName2 { get; set; } = null!;

    public string ReporterEmpName3 { get; set; } = null!;

    public string ReporterEmpName4 { get; set; } = null!;

    public string ReporterEmpName5 { get; set; } = null!;

    public bool ReporterVisible { get; set; }

    public int ReporterDptId { get; set; }

    public string ReporterDptName { get; set; } = null!;

    public string ReporterDptShtName { get; set; } = null!;

    public bool ReporterActive { get; set; }

    public int ReporterSxnId { get; set; }

    public string ReporterSxnName { get; set; } = null!;

    public string ReporterSxnShtName { get; set; } = null!;

    public int ReporterJbtId { get; set; }

    public string ReporterJbtName { get; set; } = null!;

    public string ReporterJbtShtName { get; set; } = null!;

    public string ReporterMobNox { get; set; } = null!;

    public string ReporterMobNo { get; set; } = null!;

    public string ReporterPlc { get; set; } = null!;

    public int ReporterLocId { get; set; }

    public string ReporterLocName { get; set; } = null!;

    public string ReporterLocShtName { get; set; } = null!;

    public int ApproverEmpId { get; set; }

    public string ApproverStaffNo { get; set; } = null!;

    public string ApproverLname { get; set; } = null!;

    public string ApproverFname { get; set; } = null!;

    public string ApproverOnames { get; set; } = null!;

    public string ApproverEmpName { get; set; } = null!;

    public string ApproverEmpName1 { get; set; } = null!;

    public string ApproverEmpName2 { get; set; } = null!;

    public string ApproverEmpName3 { get; set; } = null!;

    public string ApproverEmpName4 { get; set; } = null!;

    public string ApproverEmpName5 { get; set; } = null!;

    public bool ApproverVisible { get; set; }

    public int ApproverDptId { get; set; }

    public string ApproverDptName { get; set; } = null!;

    public string ApproverDptShtName { get; set; } = null!;

    public bool ApproverActive { get; set; }

    public int ApproverSxnId { get; set; }

    public string ApproverSxnName { get; set; } = null!;

    public string ApproverSxnShtName { get; set; } = null!;

    public int ApproverJbtId { get; set; }

    public string ApproverJbtName { get; set; } = null!;

    public string ApproverJbtShtName { get; set; } = null!;

    public string ApproverMobNox { get; set; } = null!;

    public string ApproverMobNo { get; set; } = null!;

    public string ApproverPlc { get; set; } = null!;

    public int ApproverLocId { get; set; }

    public string ApproverLocName { get; set; } = null!;

    public string ApproverLocShtName { get; set; } = null!;

    public string SadStatus { get; set; } = null!;

    public string SadCategory { get; set; } = null!;

    public bool SadApproved { get; set; }

    public bool SadAuthorised { get; set; }

    public int SadDuration { get; set; }

    public bool SadOmitWeekend { get; set; }

    public int DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public bool SadSubmitted { get; set; }
}
