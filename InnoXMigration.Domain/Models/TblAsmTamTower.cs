using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamTower
{
    public int TwrIdpk { get; set; }

    public string? TwrName { get; set; }

    public string? TwrShtName { get; set; }

    public string? TwrCode { get; set; }

    public int? TwrTowerTypeIdfk { get; set; }

    public int? TwrInsulatorTypeIdfk { get; set; }

    public string? TwrCrossArms { get; set; }

    public int? TwrLocationIdfk { get; set; }

    public string? TwrCountryIdfk { get; set; }

    public int? TwrRegionIdfk { get; set; }

    public int? TwrDistrictIdfk { get; set; }

    public int? TwrTownIdfk { get; set; }

    public string? TwrFooting { get; set; }

    public decimal? TwrHeight { get; set; }

    public decimal? TwrLatitude { get; set; }

    public decimal? TwrLongitude { get; set; }

    public bool? TwrActive { get; set; }

    public string? TwrRmks { get; set; }

    public string? TwrCreatedBy { get; set; }

    public int? TwrEditedBy { get; set; }

    public DateTime? TwrCreationDate { get; set; }

    public DateTime? TwrEditedDate { get; set; }
}
