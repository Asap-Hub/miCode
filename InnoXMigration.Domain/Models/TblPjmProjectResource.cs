using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPjmProjectResource
{
    public int PrsIdpk { get; set; }

    public int? PrsProjectIdfk { get; set; }

    public string? PrsName { get; set; }

    public string? PrsShtName { get; set; }

    public decimal? PrsAmount { get; set; }

    public decimal? PrsQuantity { get; set; }

    public int? PrsCurrencyIdfk { get; set; }

    public string? PrsQuantityUnit { get; set; }

    public DateTime? PrsDate { get; set; }

    public bool? PrsActive { get; set; }

    public string? PrsRmks { get; set; }

    public string? PrsCreatedBy { get; set; }

    public int? PrsEditedBy { get; set; }

    public DateTime? PrsCreationDate { get; set; }

    public DateTime? PrsEditedDate { get; set; }
}
