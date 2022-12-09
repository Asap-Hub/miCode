using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class SafteyMeetingDetail
{
    public double? MtdIdpk { get; set; }

    public string? MtdName { get; set; }

    public double? MtdGroupIdfk { get; set; }

    public double? MtdMeetingTypeIdfk { get; set; }

    public double? MtdResourcePersonIdfk { get; set; }

    public double? MtdTopicIdfk { get; set; }

    public string? MtdStartTime { get; set; }

    public string? MtdEndTime { get; set; }

    public string? MtdWhy { get; set; }

    public bool MtdScoring { get; set; }

    public double? MtdTotalNumberOfMembers { get; set; }

    public double? MtdTotalNumberOfAttendance { get; set; }

    public double? MtdTotalNumberOfAttendanceSubmitted { get; set; }

    public string? MtdNumberOfMembersSubmitted { get; set; }

    public string? MtdNumberOfMembersPresent { get; set; }

    public string? MtdNumberOfMembersAbsent { get; set; }

    public string? MtdPercentOfMembersOnOfficialDuties { get; set; }

    public bool MtdActive { get; set; }

    public string? MtdRmks { get; set; }

    public double? MtdCreatedBy { get; set; }

    public string? MtdEditedBy { get; set; }

    public string? MtdCreationDate { get; set; }

    public string? MtdEditedDate { get; set; }
}
