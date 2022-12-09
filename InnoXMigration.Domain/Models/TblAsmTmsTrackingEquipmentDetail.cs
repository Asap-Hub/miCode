using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsTrackingEquipmentDetail
{
    public int TedIdpk { get; set; }

    public string? TedVendor { get; set; }

    public string? TedTrackerUrl { get; set; }

    public string? TedPlaybackUrl { get; set; }

    public string? TedGeofenceUrl { get; set; }

    public string? TedTargetInfoUrl { get; set; }

    public string? TedCheckCommandUrl { get; set; }

    public string? TedTrackingReportUrl { get; set; }

    public string? TedContactPersons { get; set; }

    public string? TedContact { get; set; }

    public bool? TedActive { get; set; }

    public string? TedRmks { get; set; }

    public string? TedCreatedBy { get; set; }

    public int? TedEditedBy { get; set; }

    public DateTime? TedCreationDate { get; set; }

    public DateTime? TedEditedDate { get; set; }
}
