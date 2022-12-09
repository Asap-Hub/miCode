using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftMeetingAttendanceStatistic
{
    public int MasIdpk { get; set; }

    public int? MasGroupIdfk { get; set; }

    public int? MasMeetingDetailIdfk { get; set; }

    public decimal? MasTotalAttendance { get; set; }

    public decimal? MasTotalPresent { get; set; }

    public decimal? MasTotalVisitors { get; set; }

    public string? MasCoordinatorComments { get; set; }

    public string? MasSafetyAdminComments { get; set; }

    public bool? MasActive { get; set; }

    public string? MasRmks { get; set; }

    public int? MasCreatedBy { get; set; }

    public int? MasEditedBy { get; set; }

    public DateTime? MasCreationDate { get; set; }

    public DateTime? MasEditedDate { get; set; }
}
