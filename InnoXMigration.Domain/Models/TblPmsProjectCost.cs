using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmsProjectCost
{
    public int PjcIdpk { get; set; }

    public DateTime? PjcDate { get; set; }

    public int? PjcProjectIdfk { get; set; }

    public decimal? PjcAmount { get; set; }

    public int? PjcCurrencyIdfk { get; set; }

    public string? PjcCostType { get; set; }

    public bool? PjcActive { get; set; }

    public string? PjcRmks { get; set; }

    public int? PjcCreatedBy { get; set; }

    public int? PjcEditedBy { get; set; }

    public DateTime? PjcCreationDate { get; set; }

    public DateTime? PjcEditedDate { get; set; }
}
