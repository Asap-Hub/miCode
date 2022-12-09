using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftMeetingAttendance
{
    public int MatIdpk { get; set; }

    public int? MatEmpIdfk { get; set; }

    public int? MatAttendanceCategoryIdfk { get; set; }

    public DateTime? MatStaffInTime { get; set; }

    public DateTime? MatStaffOutTime { get; set; }

    public bool? MatVisitor { get; set; }

    public bool MatSubmitted { get; set; }

    public bool MatAcknowledged { get; set; }

    public int MatSubmittedByEmpIdfk { get; set; }

    public int MatAcknowledgedByEmpIdfk { get; set; }

    public DateTime MatSubmittedOn { get; set; }

    public DateTime MatAcknowledgedOn { get; set; }

    public bool? MatActive { get; set; }

    public string MatRmks { get; set; } = null!;

    public int? AtcIdpk { get; set; }

    public string? AtcName { get; set; }

    public string? AtcShtName { get; set; }

    public bool? AtcPresent { get; set; }

    public decimal? AtcOrder { get; set; }

    public int? EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstname { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName16 { get; set; }

    public string? StpName { get; set; }

    public string? StpShtName { get; set; }

    public int? EmpDptId { get; set; }

    public string? EmpDptName { get; set; }

    public string? EmpDptShtName { get; set; }

    public int? EmpSxnId { get; set; }

    public string? EmpSxnName { get; set; }

    public string? EmpSxnShtName { get; set; }

    public int? EmpLocId { get; set; }

    public string? EmpLocName { get; set; }

    public string? EmpLocShtName { get; set; }

    public string? EmpMobNo { get; set; }

    public string? EmpIntercom { get; set; }

    public int? AscIdpk { get; set; }

    public string? AscName { get; set; }

    public string? AscShtName { get; set; }

    public int? JbtIdpk { get; set; }

    public string? JbtName { get; set; }

    public string? JbtShtName { get; set; }

    public string? EmpMobNox { get; set; }

    public int? MatCreatedBy { get; set; }

    public int? MatEditedBy { get; set; }

    public DateTime? MatCreationDate { get; set; }

    public DateTime? MatEditedDate { get; set; }

    public int? MtdIdpk { get; set; }

    public string? MtdName { get; set; }

    public DateTime? MtdStartTime { get; set; }

    public DateTime? MtdEndTime { get; set; }

    public string? MtdWhy { get; set; }

    public int? StpIdpk { get; set; }

    public string? StpTitle { get; set; }

    public string? StpDescription { get; set; }

    public int? SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public DateTime? SgpDateFormed { get; set; }

    public int? MatMeetingDetailIdfk { get; set; }

    public bool MatDeleted { get; set; }

    public DateTime? MatDeletedOn { get; set; }

    public int MatDeletedByEmpIdfk { get; set; }

    public string MatDeletionReason { get; set; } = null!;

    public int? MatDeptIdfk { get; set; }

    public int? MatSectionIdfk { get; set; }

    public int? MatLocationIdfk { get; set; }

    public int? RepSxnId { get; set; }

    public string? RepSxnName { get; set; }

    public string? RepSxnShtName { get; set; }

    public int? RepDptId { get; set; }

    public string? RepDptName { get; set; }

    public string? RepDptShtName { get; set; }

    public int? RepLocId { get; set; }

    public string? RepLocName { get; set; }

    public string? RepLocShtName { get; set; }

    public int? RepAreId { get; set; }

    public string? RepAreName { get; set; }

    public string? RepAreShtName { get; set; }

    public int FuntIdpk { get; set; }

    public string FuntName { get; set; } = null!;

    public string FuntShtName { get; set; } = null!;

    public int? MatUnitIdfk { get; set; }

    public int RepUntId { get; set; }

    public string RepUntName { get; set; } = null!;

    public string RepUntShtName { get; set; } = null!;

    public decimal AtcWeight { get; set; }

    public bool? MtdActive { get; set; }

    public bool? MtdScoring { get; set; }

    public int? MtpIdpk { get; set; }

    public string? MtpName { get; set; }

    public string? MtpShtName { get; set; }

    public bool? MtpSafetyMeeting { get; set; }

    public bool? MtpWasacoMeeting { get; set; }

    public bool? MtpOtherMeeting { get; set; }

    public bool? AtcPresentExternal { get; set; }

    public bool? SgpActive { get; set; }

    public bool? StpActive { get; set; }
}
