using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsProductPrice
{
    public int PprIdpk { get; set; }

    public DateTime? PprDate { get; set; }

    public int? PprCurrencyIdfk { get; set; }

    public int? PprFuelUnitIdfk { get; set; }

    public int? PprProductIdfk { get; set; }

    public decimal? PprUnitPrice { get; set; }

    public bool? PprActive { get; set; }

    public string? PprRmks { get; set; }

    public int? CurIdpk { get; set; }

    public string? CurName { get; set; }

    public DateTime? CurDate { get; set; }

    public string? CurShtName { get; set; }

    public string? CurSymbol { get; set; }

    public bool? CurForeign { get; set; }

    public byte? CurOrder { get; set; }

    public int? FunIdpk { get; set; }

    public string? FunName { get; set; }

    public string? FunShtName { get; set; }

    public bool? FunActive { get; set; }

    public string? FunRmks { get; set; }

    public int? PprServiceStationIdfk { get; set; }

    public int? PrdIdpk { get; set; }

    public string? PrdName { get; set; }

    public string? PrdShtName { get; set; }

    public bool? PrdActive { get; set; }

    public int? SstIdpk { get; set; }

    public string? SstName { get; set; }

    public string? SstShtName { get; set; }

    public string? SstStationNo { get; set; }

    public int? TwnIdpk { get; set; }

    public string? TwnName { get; set; }

    public string? TwnShtName { get; set; }

    public int? DstIdpk { get; set; }

    public string? DstName { get; set; }

    public string? DstShtName { get; set; }

    public int? RgnIdpk { get; set; }

    public string? RgnName { get; set; }

    public string? RgnShtName { get; set; }

    public int? SpdIdpk { get; set; }

    public string? SpdName { get; set; }

    public string? SpdShtName { get; set; }

    public string? SpdMainContact { get; set; }

    public string? SpdMobNos { get; set; }

    public string? SpdEmail { get; set; }

    public string? SpdTelNos { get; set; }

    public string? SpdPostalAddress { get; set; }

    public string? SpdResidentialAddress { get; set; }

    public bool? SpdActive { get; set; }
}
