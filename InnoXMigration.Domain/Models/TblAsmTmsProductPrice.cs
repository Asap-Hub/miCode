using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsProductPrice
{
    public int PprIdpk { get; set; }

    public DateTime? PprDate { get; set; }

    public int? PprServiceProviderIdfk { get; set; }

    public int? PprServiceStationIdfk { get; set; }

    public int? PprProductIdfk { get; set; }

    public int? PprFuelUnitIdfk { get; set; }

    public int? PprCurrencyIdfk { get; set; }

    public decimal? PprUnitPrice { get; set; }

    public bool? PprActive { get; set; }

    public string? PprRmks { get; set; }

    public string? PprCreatedBy { get; set; }

    public int? PprEditedBy { get; set; }

    public DateTime? PprCreationDate { get; set; }

    public DateTime? PprEditedDate { get; set; }
}
