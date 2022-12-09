using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftSafetyGroupProperty
{
    public int SgtIdpk { get; set; }

    public int? SgtGroupIdfk { get; set; }

    public DateTime? SgtStartDate { get; set; }

    public DateTime? SgtEndDate { get; set; }

    public int? SgtZoneIdfk { get; set; }

    public int? SgtTeamIdfk { get; set; }

    public int? SgtDeptIdfk { get; set; }

    public int? SgtLocationIdfk { get; set; }

    public int? SgtCoordinatorEmpIdfk { get; set; }

    public int? SgtAssistantCoordinatorEmpIdfk { get; set; }

    public int? SgtDirectorEmpIdfk { get; set; }

    public int? SgtManagerEmpIdfk { get; set; }

    public int? SgtChairmanEmpIdfk { get; set; }

    public int? SgtNoOfAnnualSafetyMeetings { get; set; }

    public int? SgtNoOfAnnualCompulsaryMeetingAttendance { get; set; }

    public int? SgtNoOfFirstQuarterSafetyMeetings { get; set; }

    public int? SgtNoOfSecondQuarterSafetyMeetings { get; set; }

    public int? SgtNoOfThirdQuarterSafetyMeetings { get; set; }

    public int? SgtNoOfFourthQuarterSafetyMeetings { get; set; }

    public byte? SgtNoOfJanuaryMeetings { get; set; }

    public byte? SgtNoOfFebruaryMeetings { get; set; }

    public byte? SgtNoOfMarchMeetings { get; set; }

    public byte? SgtNoOfAprilMeetings { get; set; }

    public byte? SgtNoOfMayMeetings { get; set; }

    public byte? SgtNoOfJuneMeetings { get; set; }

    public byte? SgtNoOfJulyMeetings { get; set; }

    public byte? SgtNoOfAugustMeetings { get; set; }

    public byte? SgtNoOfSeptemberMeetings { get; set; }

    public byte? SgtNoOfOctoberMeetings { get; set; }

    public byte? SgtNoOfNovemberMeetings { get; set; }

    public byte? SgtNoOfDecemberMeetings { get; set; }

    public int? SgtMinMeetingDuration { get; set; }

    public int? SgtMaxMeetingDuration { get; set; }

    public bool? SgtActive { get; set; }

    public string? SgtRmks { get; set; }

    public int? SgtCreatedBy { get; set; }

    public int? SgtEditedBy { get; set; }

    public DateTime? SgtCreationDate { get; set; }

    public DateTime? SgtEditedDate { get; set; }
}
