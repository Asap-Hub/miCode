using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftSafetyGroup
{
    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public string? SgpCodeName { get; set; }

    public int? SgpLocationIdfk { get; set; }

    public DateTime? SgpDateFormed { get; set; }

    public DateTime? SgpEndDate { get; set; }

    public int? SgpGroupPropertiesIdfk { get; set; }

    public int? SgpGroupSafetyMeetingPropertiesIdfk { get; set; }

    public int? SgpGroupWasacoMeetingPropertiesIdfk { get; set; }

    public int? SgpGroupInspectionPropertiesIdfk { get; set; }

    public int? SgpDeptIdfk { get; set; }

    public int? SgpCoordinatorEmpIdfk { get; set; }

    public int? SgpDirectorEmpIdfk { get; set; }

    public int? SgpManagerEmpIdfk { get; set; }

    public int? SgpWasacoChairmanEmpIdfk { get; set; }

    public decimal? SgpNoOfAnnualSafetyMeetings { get; set; }

    public decimal? SgpNoOfFirstQuarterSafetyMeetings { get; set; }

    public decimal? SgpNoOfSecondQuarterSafetyMeetings { get; set; }

    public decimal? SgpNoOfThirdQuarterSafetyMeetings { get; set; }

    public decimal? SgpNoOfFourthQuarterSafetyMeetings { get; set; }

    public decimal? SgpMeetingAttendancePassmark { get; set; }

    public decimal? SgpNoOfPassedMeetingAttendance { get; set; }

    public decimal? SgpMinMeetingDuration { get; set; }

    public decimal? SgpMaxMeetingDuration { get; set; }

    public bool? SgpSafetyGroup { get; set; }

    public bool? SgpTechnicalGroup { get; set; }

    public bool? SgpMasterGroup { get; set; }

    public bool? SgpSubmitWasacoReturns { get; set; }

    public bool? SgpSendSmsAlertsToMembers { get; set; }

    public bool? SgpActive { get; set; }

    public string? SgpRmks { get; set; }

    public int? SgpCreatedBy { get; set; }

    public int? SgpEditedBy { get; set; }

    public DateTime? SgpCreationDate { get; set; }

    public DateTime? SgpEditedDate { get; set; }
}
