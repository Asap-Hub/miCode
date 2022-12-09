using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenTown
{
    public int TwnIdpk { get; set; }

    public string? TwnName { get; set; }

    public string? TwnShtName { get; set; }

    public int? TwnDistrictIdfk { get; set; }

    public bool? TwnActive { get; set; }

    public string TwnRmks { get; set; } = null!;

    public bool TwnRegionalCapital { get; set; }

    public bool TwnDistrictCapital { get; set; }

    public bool TwnNationalCapital { get; set; }

    public int? CtyIdpk { get; set; }

    public string? CtyName { get; set; }

    public string? CtyShtName { get; set; }

    public string? CtyNationality { get; set; }

    public string? CtyCapital { get; set; }

    public bool? CtyActive { get; set; }

    public int? TwnCountryIdfk { get; set; }

    public int? TwnRegionIdfk { get; set; }

    public int? RgnIdpk { get; set; }

    public string? RgnName { get; set; }

    public string? RgnShtName { get; set; }

    public string? RgnCapital { get; set; }

    public bool? RgnActive { get; set; }

    public int DstIdpk { get; set; }

    public string DstName { get; set; } = null!;

    public string DstShtName { get; set; } = null!;

    public bool DstActive { get; set; }

    public string DstRemarks { get; set; } = null!;

    public string DstCapial { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public int AreIdpk { get; set; }

    public string AreName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;
}
