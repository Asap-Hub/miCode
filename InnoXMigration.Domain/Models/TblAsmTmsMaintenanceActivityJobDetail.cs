using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsMaintenanceActivityJobDetail
{
    public int MjdIdpk { get; set; }

    public int? MjdMaintActivityIdfk { get; set; }

    public string? MjdJob { get; set; }

    public string? MjdDescription { get; set; }

    public DateTime? MjdDate { get; set; }

    public decimal? MjdPercentComplete { get; set; }

    public DateTime? MjdUpdateDate { get; set; }

    public DateTime? MjdCompletionDate { get; set; }

    public bool? MjdActive { get; set; }

    public string? MjdRmks { get; set; }

    public string? MjdCreatedBy { get; set; }

    public int? MjdEditedBy { get; set; }

    public DateTime? MjdCreationDate { get; set; }

    public DateTime? MjdEditedDate { get; set; }
}
