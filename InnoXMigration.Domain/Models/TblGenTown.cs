using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenTown
{
    public int TwnIdpk { get; set; }

    public string? TwnName { get; set; }

    public string? TwnShtName { get; set; }

    public int? TwnCountryIdfk { get; set; }

    public int? TwnRegionIdfk { get; set; }

    public int? TwnDistrictIdfk { get; set; }

    public int? TwnLocationIdfk { get; set; }

    public bool? TwnDistrictCapital { get; set; }

    public bool? TwnRegionalCapital { get; set; }

    public bool? TwnNationalCapital { get; set; }

    public bool? TwnActive { get; set; }

    public string? TwnRmks { get; set; }

    public int? TwnCreatedBy { get; set; }

    public int? TwnEditedBy { get; set; }

    public DateTime? TwnCreationDate { get; set; }

    public DateTime? TwnEditedDate { get; set; }
}
