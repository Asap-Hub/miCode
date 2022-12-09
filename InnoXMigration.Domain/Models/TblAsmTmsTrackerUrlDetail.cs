using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsTrackerUrlDetail
{
    public int TudIdpk { get; set; }

    public string? TudVendor { get; set; }

    public string? TudTrackerUrl { get; set; }

    public string? TudPlaybackUrl { get; set; }

    public string? TudGeofenceUrl { get; set; }

    public string? TudTargetInfoUrl { get; set; }

    public string? TudCheckCommandUrl { get; set; }

    public string? TudTrackingReportUrl { get; set; }

    public bool? TudActive { get; set; }

    public string? TudRmks { get; set; }

    public string? TudCreatedBy { get; set; }

    public int? TudEditedBy { get; set; }

    public DateTime? TudCreationDate { get; set; }

    public DateTime? TudEditedDate { get; set; }
}
