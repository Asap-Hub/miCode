using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftMeetingDetail
{
    public int MtdIdpk { get; set; }

    public string? MtdName { get; set; }

    public int? MtdGroupIdfk { get; set; }

    public int? MtdTopicIdfk { get; set; }

    public DateTime? MtdStartTime { get; set; }

    public DateTime? MtdEndTime { get; set; }

    public string MtdWhy { get; set; } = null!;

    public bool? MtdActive { get; set; }

    public string MtdRmks { get; set; } = null!;

    public int StpIdpk { get; set; }

    public string? StpTitle { get; set; }

    public string? StpDescription { get; set; }

    public bool? StpActive { get; set; }

    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public DateTime? SgpDateFormed { get; set; }

    public bool? SgpActive { get; set; }

    public int RspIdpk { get; set; }

    public string RspResourcePerson { get; set; } = null!;

    public string RspCompany { get; set; } = null!;

    public string RspMobNo { get; set; } = null!;

    public string RspAddress { get; set; } = null!;

    public bool RspActive { get; set; }

    public int MtdResourcePersonIdfk { get; set; }

    public int RspEmpIdfk { get; set; }

    public bool MtdScoring { get; set; }

    public int? MtpIdpk { get; set; }

    public string? MtpName { get; set; }

    public string? MtpShtName { get; set; }

    public bool? MtpSafetyMeeting { get; set; }

    public bool? MtpWasacoMeeting { get; set; }

    public bool? MtpOtherMeeting { get; set; }

    public int? MtdMeetingTypeIdfk { get; set; }
}
