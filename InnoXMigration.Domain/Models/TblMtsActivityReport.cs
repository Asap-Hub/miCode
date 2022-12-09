using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsActivityReport
{
    public int ArpIdpk { get; set; }

    public DateTime? ArpStartDate { get; set; }

    public DateTime? ArpEndDate { get; set; }

    public string? ArpTitle { get; set; }

    public int? ArpReportTypeIdfk { get; set; }

    public string? ArpRmks { get; set; }

    public int? ArpCreatedBy { get; set; }

    public int? ArpEditedBy { get; set; }

    public DateTime? ArpCreationDate { get; set; }

    public DateTime? ArpEditedDate { get; set; }
}
