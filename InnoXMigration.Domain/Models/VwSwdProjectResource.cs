using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdProjectResource
{
    public int PrsIdpk { get; set; }

    public int? PrsProjectIdfk { get; set; }

    public string? PrsName { get; set; }

    public string? PrsShtName { get; set; }

    public decimal? PrsAmount { get; set; }

    public decimal? PrsQuantity { get; set; }

    public int? PrsCurrencyIdfk { get; set; }

    public string? PrsQuantityUnit { get; set; }

    public bool? PrsActive { get; set; }

    public string? PrsRmks { get; set; }

    public int CurIdpk { get; set; }

    public string? CurName { get; set; }

    public string? CurShtName { get; set; }

    public string? CurSymbol { get; set; }

    public bool? CurForeign { get; set; }

    public bool? CurActive { get; set; }

    public int PrjIdpk { get; set; }

    public string? PrjName { get; set; }

    public string? PrjShtName { get; set; }

    public string PrjDescription { get; set; } = null!;

    public DateTime? PrjStartDate { get; set; }

    public DateTime? PrjProposedEndDate { get; set; }

    public DateTime? PrjActualEndDate { get; set; }

    public DateTime? PrsDate { get; set; }
}
