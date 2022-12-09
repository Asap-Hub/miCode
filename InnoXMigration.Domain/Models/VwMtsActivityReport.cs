using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwMtsActivityReport
{
    public int ArpIdpk { get; set; }

    public DateTime? ArpStartDate { get; set; }

    public DateTime? ArpEndDate { get; set; }

    public string? ArpTitle { get; set; }

    public int? ArpReportTypeIdfk { get; set; }

    public string ArpRmks { get; set; } = null!;

    public int RtpIdpk { get; set; }

    public string? RtpName { get; set; }

    public string? RtpShtName { get; set; }

    public bool? RtpActive { get; set; }

    public string RtpRmks { get; set; } = null!;

    public int? ArpCreatedBy { get; set; }

    public int? ArpEditedBy { get; set; }

    public DateTime? ArpCreationDate { get; set; }

    public DateTime? ArpEditedDate { get; set; }
}
