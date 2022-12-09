using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdProjectPriority
{
    public int PrpIdpk { get; set; }

    public string? PrpName { get; set; }

    public string? PrpShtName { get; set; }

    public decimal? PrpOrder { get; set; }

    public bool? PrpActive { get; set; }

    public string? PrpRmks { get; set; }

    public int? PrpCreatedBy { get; set; }

    public int? PrpEditedBy { get; set; }

    public DateTime? PrpCreationDate { get; set; }

    public DateTime? PrpEditedDate { get; set; }
}
