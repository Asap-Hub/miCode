using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTamTowerDetail
{
    public int TwdIdpk { get; set; }

    public string? TwdName { get; set; }

    public string? TwdShtName { get; set; }

    public string? TwdCode { get; set; }

    public int? TwdTowerTypeIdfk { get; set; }

    public int? TwdInsulatorTypeIdfk { get; set; }

    public int? TwdCrossArms { get; set; }

    public int? TwdLocationIdfk { get; set; }

    public int? TwdRegionIdfk { get; set; }

    public int? TwdTownIdfk { get; set; }

    public string? TwdFooting { get; set; }

    public decimal? TwdHeight { get; set; }

    public decimal? TwdLatitude { get; set; }

    public decimal? TwdLongitude { get; set; }

    public bool? TwdActive { get; set; }

    public string? TwdRmks { get; set; }

    public int? TwdCreatedBy { get; set; }

    public int? TwdEditedBy { get; set; }

    public DateTime? TwdCreationDate { get; set; }

    public DateTime? TwdEditedDate { get; set; }

    public int? TwdLineIdfk { get; set; }

    public int? LdtIdpk { get; set; }

    public string? LdtName { get; set; }

    public string? LdtNomenclature { get; set; }

    public decimal? LdtLength { get; set; }

    public DateTime? LdtConstructionDate { get; set; }

    public DateTime? LdtCommissionDate { get; set; }

    public DateTime? LdtDecommissionDate { get; set; }

    public int? SourceStationId { get; set; }

    public string? SourceStationName { get; set; }

    public string? SourceStationShtName { get; set; }

    public string? SourceStationCode { get; set; }

    public int? DestStationId { get; set; }

    public string? DestStationName { get; set; }

    public string? DestStationShtName { get; set; }

    public string? DestStationCode { get; set; }

    public int TalIdpk { get; set; }

    public string TalName { get; set; } = null!;

    public string TalShtName { get; set; } = null!;

    public bool TalActive { get; set; }

    public int? IntIdpk { get; set; }

    public string? IntName { get; set; }

    public string? IntShtName { get; set; }

    public int? CraIdpk { get; set; }

    public string? CraName { get; set; }

    public string? CraShtName { get; set; }

    public int? TwtIdpk { get; set; }

    public string? TwtName { get; set; }

    public string? TwtShtName { get; set; }

    public int CtyIdpk { get; set; }

    public string? CtyName { get; set; }

    public string? CtyShtName { get; set; }

    public string? CtyNationality { get; set; }

    public int? RgnIdpk { get; set; }

    public string? RgnName { get; set; }

    public string? RgnShtName { get; set; }

    public int? DstIdpk { get; set; }

    public string? DstName { get; set; }

    public string? DstShtName { get; set; }

    public int FtwnIdpk { get; set; }

    public string FtwnName { get; set; } = null!;

    public bool? TwnDistrictCapital { get; set; }

    public bool? TwnRegionalCapital { get; set; }

    public bool? TwnNationalCapital { get; set; }

    public int? TwdTowerDesignTypeIdfk { get; set; }

    public int TdtIdpk { get; set; }

    public string TdtName { get; set; } = null!;

    public string TdtShtName { get; set; } = null!;

    public int CntIdpk { get; set; }

    public string CntName { get; set; } = null!;

    public string CntShtName { get; set; } = null!;

    public int TwdChainageTypeIdfk { get; set; }

    public int TwdFootingTypeIdfk { get; set; }

    public int FttIdpk { get; set; }

    public string FttName { get; set; } = null!;

    public string FttShtName { get; set; } = null!;

    public int TwdEquipmentLocationIdfk { get; set; }

    public int ElcIdpk { get; set; }

    public string ElcName { get; set; } = null!;

    public string ElcShtName { get; set; } = null!;
}
