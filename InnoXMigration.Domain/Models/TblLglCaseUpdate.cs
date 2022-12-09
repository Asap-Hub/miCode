using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblLglCaseUpdate
{
    public int CupIdpk { get; set; }

    public DateTime? CupDate { get; set; }

    public int? CupCaseIdfk { get; set; }

    public string? CupUpdate { get; set; }

    public string? CupTag { get; set; }

    public decimal? CupPercentComplete { get; set; }

    public DateTime? CupCompletionDate { get; set; }

    public int? CupStatusIdfk { get; set; }

    public int? CupImpactIdfk { get; set; }

    public string? CupDoneBy { get; set; }

    public string? CupDoneByDept { get; set; }

    public string CupDoneBySection { get; set; } = null!;

    public string? CupDoneByLocation { get; set; }

    public bool? CupRequestForInfo { get; set; }

    public bool? CupInfoRequestReceived { get; set; }

    public bool? CupActive { get; set; }

    public bool? CupLocked { get; set; }

    public string? CupRmks { get; set; }

    public string? CupCreatedBy { get; set; }

    public int? CupEditedBy { get; set; }

    public DateTime? CupCreationDate { get; set; }

    public DateTime? CupEditedDate { get; set; }
}
