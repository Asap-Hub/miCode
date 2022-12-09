using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenScheduleResource
{
    public int SrsIdpk { get; set; }

    public int? SrsScheduleIdfk { get; set; }

    public string? SrsName { get; set; }

    public string? SrsShtName { get; set; }

    public decimal? SrsCost { get; set; }

    public decimal? SrsQuantity { get; set; }

    public int? SrsCostCurrencyIdfk { get; set; }

    public string? SrsQuantityUnit { get; set; }

    public DateTime? SrsDateProvisioned { get; set; }

    public bool? SrsActive { get; set; }

    public string? SrsRmks { get; set; }

    public int CurIdpk { get; set; }

    public string? CurName { get; set; }

    public string? CurShtName { get; set; }

    public string? CurSymbol { get; set; }

    public bool? CurForeign { get; set; }

    public bool? CurActive { get; set; }

    public int ScdIdpk { get; set; }

    public string? ScdProjectIdfk { get; set; }

    public int ScpIdpk { get; set; }

    public string? ScpName { get; set; }

    public string? ScpShtName { get; set; }

    public string? ScdTask { get; set; }

    public string? ScdTaskDescription { get; set; }

    public DateTime? ScdStartDate { get; set; }

    public DateTime? ScdDueDate { get; set; }
}
