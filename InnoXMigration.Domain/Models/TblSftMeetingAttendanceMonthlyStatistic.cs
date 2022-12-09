using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftMeetingAttendanceMonthlyStatistic
{
    public int MmsIdpk { get; set; }

    public int? MmsSafetyGroupIdfk { get; set; }

    public int? MmsZoneIdfk { get; set; }

    public int? MmsTeamIdfk { get; set; }

    public DateTime? MmsDate { get; set; }

    public int? MmsQuarter { get; set; }

    public string? MmsQuarterWords { get; set; }

    public int? MmsSafetyMeetingsExpectedNo { get; set; }

    public int? MmsSafetyMeetingsNoConducted { get; set; }

    public decimal? MmsSafetyMeetingsPercentageConducted { get; set; }

    public int? MmsSafetyMeetingsTotalMembers { get; set; }

    public int? MmsSafetyMeetingsTotalAttendance { get; set; }

    public int? MmsSafetyMeetingsTotalVisitors { get; set; }

    public int? MmsSafetyMeetingsTotalMembersPresentInternal { get; set; }

    public int? MmsSafetyMeetingsTotalMembersPresentExternal { get; set; }

    public int? MmsSafetyMeetingsTotalMembersAbsentInternal { get; set; }

    public int? MmsSafetyMeetingsTotalMembersAbsentExternal { get; set; }

    public decimal? MmsSafetyMeetingsPercentagePresentInternal { get; set; }

    public decimal? MmsSafetyMeetingsPercentagePresentExternal { get; set; }

    public decimal? MmsSafetyMeetingsPercentageAbsentInternal { get; set; }

    public decimal? MmsSafetyMeetingsPercentageAbsentExternal { get; set; }

    public string? MmsSafetyMeetingsGradeInternal { get; set; }

    public string? MmsSafetyMeetingsGradeInterpretationInternal { get; set; }

    public string? MmsSafetyMeetingsGradeColourInternal { get; set; }

    public string? MmsSafetyMeetingsGradeExternal { get; set; }

    public string? MmsSafetyMeetingsGradeInterpretationExternal { get; set; }

    public string? MmsSafetyMeetingsGradeColourExternal { get; set; }

    public int? MmsWasacoReportsExpectedNo { get; set; }

    public int? MmsWasacoReportsNoSubmitted { get; set; }

    public decimal? MmsWasacoReportsPercentageSubmitted { get; set; }

    public string? MmsWasacoReportsGrade { get; set; }

    public string? MmsWasacoReportsGradeInterpretation { get; set; }

    public string? MmsWasacoReportsGradeColour { get; set; }

    public int? MmsWasacoAuditChecklistExpecedNoOfAudits { get; set; }

    public int? MmsWasacoAuditChecklistNoOfAssignedStations { get; set; }

    public int? MmsWasacoAuditChecklistNoOfAssignedSections { get; set; }

    public int? MmsWasacoAuditChecklistNoOfAssignedItems { get; set; }

    public int? MmsWasacoAuditChecklistTotalNoOfAuditsAssigned { get; set; }

    public int? MmsWasacoAuditChecklistNoOfAuditsSubmitted { get; set; }

    public int? MmsWasacoAuditChecklistNoOfStationsSubmitted { get; set; }

    public int? MmsWasacoAuditChecklistNoOfSecionsSubmitted { get; set; }

    public int? MmsWasacoAuditChecklistNoOfItemsSubmitted { get; set; }

    public int? MmsWasacoAuditChecklistTotalNoOfAuditsSubmitted { get; set; }

    public decimal? MmsWasacoAuditChecklistPercentageSubmitted { get; set; }

    public string? MmsWasacoAuditChecklistGrade { get; set; }

    public string? MmsWasacoAuditChecklistGradeInterpretation { get; set; }

    public string? MmsWasacoAuditChecklistGradeColour { get; set; }

    public decimal? MmsOverallPercentageInternal { get; set; }

    public string? MmsOverallGradeInternal { get; set; }

    public string? MmsOverallGradeInerpretationInternal { get; set; }

    public string? MmsOverallGradeColourInternal { get; set; }

    public decimal? MmsOverallPercentageExternal { get; set; }

    public string? MmsOverallGradeExternal { get; set; }

    public string? MmsOverallGradeInterpretationExternal { get; set; }

    public string? MmsOverallGradeColourExternal { get; set; }

    public string? MmsSafetyManagersComments { get; set; }

    public string? MmsChairmansComments { get; set; }

    public string? MmsManagersComments { get; set; }

    public string? MmsCoordinatorsComments { get; set; }

    public int? MmsDepartmentIdfk { get; set; }

    public bool? MmsActive { get; set; }

    public string? MmsRmks { get; set; }

    public int? MmsCreatedBy { get; set; }

    public int? MmsEditedBy { get; set; }

    public DateTime? MmsCreationDate { get; set; }

    public DateTime? MmsEditedDate { get; set; }
}
