using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftSafetyGroupWasacoMeetingPropertiesx
{
    public int SwpIdpk { get; set; }

    public int? SwpGroupIdfk { get; set; }

    public DateTime? SwpStartDate { get; set; }

    public DateTime? SwpEndDate { get; set; }

    public int? SwpNoOfAnnualSafetyMeetings { get; set; }

    public int? SwpNoOfAnnualCompulsaryMeetingAttendance { get; set; }

    public int? SwpNoOfFirstQuarterSafetyMeetings { get; set; }

    public int? SwpNoOfSecondQuarterSafetyMeetings { get; set; }

    public int? SwpNoOfThirdQuarterSafetyMeetings { get; set; }

    public int? SwpNoOfFourthQuarterSafetyMeetings { get; set; }

    public byte? SwpNoOfJanuaryMeetings { get; set; }

    public byte? SwpNoOfFebruaryMeetings { get; set; }

    public byte? SwpNoOfMarchMeetings { get; set; }

    public byte? SwpNoOfAprilMeetings { get; set; }

    public byte? SwpNoOfMayMeetings { get; set; }

    public byte? SwpNoOfJuneMeetings { get; set; }

    public byte? SwpNoOfJulyMeetings { get; set; }

    public byte? SwpNoOfAugustMeetings { get; set; }

    public byte? SwpNoOfSeptemberMeetings { get; set; }

    public byte? SwpNoOfOctoberMeetings { get; set; }

    public byte? SwpNoOfNovemberMeetings { get; set; }

    public byte? SwpNoOfDecemberMeetings { get; set; }

    public int? SwpMinMeetingDuration { get; set; }

    public int? SwpMaxMeetingDuration { get; set; }

    public bool? SwpActive { get; set; }

    public string? SwpRmks { get; set; }

    public int? SwpCreatedBy { get; set; }

    public int? SwpEditedBy { get; set; }

    public DateTime? SwpCreationDate { get; set; }

    public DateTime? SwpEditedDate { get; set; }
}
