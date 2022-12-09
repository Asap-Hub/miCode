using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class Sheet1
{
    public int? MtdIdpk { get; set; }

    public string? MtdName { get; set; }

    public int? MtdGroupIdfk { get; set; }

    public int? MtdMeetingTypeIdfk { get; set; }

    public int? MtdResourcePersonIdfk { get; set; }

    public int? MtdTopicIdfk { get; set; }

    public DateTime? MtdStartTime { get; set; }

    public DateTime? MtdEndTime { get; set; }

    public string? MtdWhy { get; set; }

    public bool MtdScoring { get; set; }

    public decimal? MtdTotalNumberOfMembers { get; set; }

    public decimal? MtdTotalNumberOfAttendance { get; set; }

    public decimal? MtdTotalNumberOfAttendanceSubmitted { get; set; }

    public decimal? MtdNumberOfMembersSubmitted { get; set; }

    public decimal? MtdNumberOfMembersPresent { get; set; }

    public decimal? MtdNumberOfMembersAbsent { get; set; }

    public decimal? MtdPercentOfMembersOnOfficialDuties { get; set; }

    public bool MtdActive { get; set; }

    public string? MtdRmks { get; set; }

    public int? MtdCreatedBy { get; set; }

    public int? MtdEditedBy { get; set; }

    public DateTime? MtdCreationDate { get; set; }

    public DateTime? MtdEditedDate { get; set; }
}
