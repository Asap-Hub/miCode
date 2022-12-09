using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsWorkshopDetail
{
    public int WsdIdpk { get; set; }

    public string? WsdName { get; set; }

    public string? WsdShtName { get; set; }

    public string? WsdCode { get; set; }

    public string? WsdContact { get; set; }

    public string? WsdTelNo { get; set; }

    public int? WsdLocIdfk { get; set; }

    public bool? WsdActive { get; set; }

    public string? WsdRmks { get; set; }

    public int? WsdCreatedBy { get; set; }

    public int? WsdEditedBy { get; set; }

    public DateTime? WsdCreationDate { get; set; }

    public DateTime? WsdEditedDate { get; set; }

    public int? TwnIdpk { get; set; }

    public string? TwnName { get; set; }

    public string? TwnShtName { get; set; }

    public bool? TwnActive { get; set; }

    public string? TwnRmks { get; set; }

    public int? DstIdpk { get; set; }

    public string? DstName { get; set; }

    public string? DstShtName { get; set; }

    public bool? DstActive { get; set; }

    public int? RgnIdpk { get; set; }

    public string? RgnName { get; set; }

    public string? RgnShtName { get; set; }

    public bool? RgnActive { get; set; }

    public int? CtyIdpk { get; set; }

    public string? CtyName { get; set; }

    public string? CtyShtName { get; set; }

    public string? CtyNationality { get; set; }

    public bool? CtyActive { get; set; }

    public string? RgnCapital { get; set; }

    public string? CtyCapital { get; set; }

    public bool? TwnRegionalCapital { get; set; }

    public bool? TwnDistrictCapital { get; set; }

    public bool? TwnNationalCapital { get; set; }

    public int? WsdTownIdfk { get; set; }

    public bool WsdExternal { get; set; }

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public bool? LocActive { get; set; }

    public string? LocRmks { get; set; }

    public int? AreIdpk { get; set; }

    public string AreName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;

    public bool? AreActive { get; set; }

    public string? AreRmks { get; set; }

    public string WsdPlc { get; set; } = null!;

    public string WsdAddress { get; set; } = null!;

    public string WsdEmail { get; set; } = null!;
}
