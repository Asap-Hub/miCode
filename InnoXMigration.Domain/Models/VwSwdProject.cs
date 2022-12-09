using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdProject
{
    public int PrjIdpk { get; set; }

    public string? PrjName { get; set; }

    public string? PrjShtName { get; set; }

    public DateTime? PrjStartDate { get; set; }

    public DateTime? PrjProposedEndDate { get; set; }

    public DateTime? PrjActualEndDate { get; set; }

    public int PrjCategoryIdfk { get; set; }

    public int PrjStatusIdfk { get; set; }

    public int PrjPriorityIdfk { get; set; }

    public bool PrjActive { get; set; }

    public string PrjRmks { get; set; } = null!;

    public int? PrpIdpk { get; set; }

    public string? PrpName { get; set; }

    public string? PrpShtName { get; set; }

    public decimal? PrpOrder { get; set; }

    public bool? PrpActive { get; set; }

    public string? PrpRmks { get; set; }

    public int? PrcIdpk { get; set; }

    public string? PrcName { get; set; }

    public string? PrcShtName { get; set; }

    public bool? PrcActive { get; set; }

    public string? PrcRmks { get; set; }

    public int? PstIdpk { get; set; }

    public string? PstName { get; set; }

    public string? PstShtName { get; set; }

    public bool? PstActive { get; set; }

    public string? PstRmks { get; set; }

    public decimal? PstOrder { get; set; }

    public decimal? PrjPercentComplete { get; set; }

    public string PrjDescription { get; set; } = null!;

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public bool? DptActive { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public string? SxnShtName { get; set; }

    public string? SxnCode { get; set; }

    public bool? SxnActive { get; set; }

    public string? PrjLastDoneBy { get; set; }

    public int? PrjLastUpdatedBy { get; set; }

    public string? PrjRequestedBy { get; set; }

    public string? PrjUpdates { get; set; }

    public DateTime? PrjLastUpdatedOn { get; set; }
}
