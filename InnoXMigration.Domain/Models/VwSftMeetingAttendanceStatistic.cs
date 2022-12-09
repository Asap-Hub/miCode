using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftMeetingAttendanceStatistic
{
    public int MasIdpk { get; set; }

    public int? MasGroupIdfk { get; set; }

    public int? MasMeetingDetailIdfk { get; set; }

    public decimal? MasTotalAttendance { get; set; }

    public decimal? MasTotalPresent { get; set; }

    public decimal? MasTotalVisitors { get; set; }

    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public int MtdIdpk { get; set; }

    public string? MtdName { get; set; }

    public DateTime? MtdStartTime { get; set; }
}
