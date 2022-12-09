using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPfmStaffInitiativeAssignmentUpdate
{
    public int SiuIdpk { get; set; }

    public int? SiuUniqueIdfk { get; set; }

    public DateTime? SiuDate { get; set; }

    public int? SuiEmpIdfk { get; set; }

    public int? SiuAssignmentIdfk { get; set; }

    public string? SiuUpdate { get; set; }

    public decimal? SiuPercentComplete { get; set; }

    public DateTime? SiuCompletionDate { get; set; }

    public string? SiuDoneBy { get; set; }

    public int? SiuStatusIdfk { get; set; }

    public bool? SiuLocked { get; set; }

    public bool? SiuActive { get; set; }

    public string? SiuRmks { get; set; }

    public string? SiuCreatedBy { get; set; }

    public int? SiuEditedBy { get; set; }

    public DateTime? SiuCreationDate { get; set; }

    public DateTime? SiuEditedDate { get; set; }
}
