using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmsIssueRegisterUpdate
{
    public int IupIdpk { get; set; }

    public DateTime? IupDate { get; set; }

    public int? IupIssueRegisterIdfk { get; set; }

    public string? IupUpdate { get; set; }

    public decimal? IupPercentComplete { get; set; }

    public DateTime? IupCompletionDate { get; set; }

    public int? IupStatusIdfk { get; set; }

    public int? IupImpactIdfk { get; set; }

    public string? IupDoneBy { get; set; }

    public string? IupDoneByDept { get; set; }

    public string IupDoneBySection { get; set; } = null!;

    public string? IupDoneByLocation { get; set; }

    public string? IupTag { get; set; }

    public bool? IupLocked { get; set; }

    public bool? IupAcknowledged { get; set; }

    public bool? IupActive { get; set; }

    public string? IupRmks { get; set; }

    public string? IupCreatedBy { get; set; }

    public int? IupEditedBy { get; set; }

    public DateTime? IupCreationDate { get; set; }

    public DateTime? IupEditedDate { get; set; }
}
