using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPjmResource
{
    public int PrsIdpk { get; set; }

    public int? PrsProjectIdfk { get; set; }

    public string? RscName { get; set; }

    public string? RscShtName { get; set; }

    public decimal? RscAmount { get; set; }

    public decimal? RscQuantity { get; set; }

    public int? RscCurrencyIdfk { get; set; }

    public string? RscQuantityUnit { get; set; }

    public DateTime? RscDate { get; set; }

    public bool? RscActive { get; set; }

    public string? RscRmks { get; set; }

    public string? RscCreatedBy { get; set; }

    public int? RscEditedBy { get; set; }

    public DateTime? RscCreationDate { get; set; }

    public DateTime? RscEditedDate { get; set; }
}
