using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdProjectUpdate
{
    public int PupIdpk { get; set; }

    public DateTime? PupDate { get; set; }

    public int? PupProjectIdfk { get; set; }

    public string? PupUpdate { get; set; }

    public decimal? PupPercentComplete { get; set; }

    public DateTime? PupCompletionDate { get; set; }

    public int? PupStatusIdfk { get; set; }

    public int? PupImpactIdfk { get; set; }

    public string? PupDoneBy { get; set; }

    public string? PupDoneByDept { get; set; }

    public string PupDoneBySection { get; set; } = null!;

    public string? PupDoneByLocation { get; set; }

    public bool? PupActive { get; set; }

    public string? PupRmks { get; set; }

    public string? PupCreatedBy { get; set; }

    public int? PupEditedBy { get; set; }

    public DateTime? PupCreationDate { get; set; }

    public DateTime? PupEditedDate { get; set; }
}
