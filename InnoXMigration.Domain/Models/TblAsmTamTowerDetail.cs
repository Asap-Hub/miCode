using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamTowerDetail
{
    public int TwdIdpk { get; set; }

    public string? TwdName { get; set; }

    public string? TwdShtName { get; set; }

    public string? TwdCode { get; set; }

    public int? TwdLineIdfk { get; set; }

    public int? TwdTowerTypeIdfk { get; set; }

    public int? TwdTowerDesignTypeIdfk { get; set; }

    public int? TwdInsulatorTypeIdfk { get; set; }

    public int? TwdChainageTypeIdfk { get; set; }

    public int? TwdFootingTypeIdfk { get; set; }

    public string? TwdFooting { get; set; }

    public int? TwdEquipmentLocationIdfk { get; set; }

    public int? TwdCrossArms { get; set; }

    public int? TwdLocationIdfk { get; set; }

    public int? TwdRegionIdfk { get; set; }

    public int? TwdDistrictIdfk { get; set; }

    public int? TwdTownIdfk { get; set; }

    public decimal? TwdHeight { get; set; }

    public decimal? TwdLatitude { get; set; }

    public decimal? TwdLongitude { get; set; }

    public bool? TwdActive { get; set; }

    public string? TwdRmks { get; set; }

    public int? TwdCreatedBy { get; set; }

    public int? TwdEditedBy { get; set; }

    public DateTime? TwdCreationDate { get; set; }

    public DateTime? TwdEditedDate { get; set; }
}
