using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class Towns91x
{
    public int? FtwnIdpk { get; set; }

    public string? FtwnName { get; set; }

    public string? FtwnShtName { get; set; }

    public int? FtwnCountryIdfk { get; set; }

    public int? FtwnRegionIdfk { get; set; }

    public int? FtwnDistrictIdfk { get; set; }

    public bool? FtwnDistrictCapital { get; set; }

    public bool? FtwnRegionalCapital { get; set; }

    public bool? FtwnNationalCapital { get; set; }

    public bool? FtwnActive { get; set; }

    public string? FtwnRmks { get; set; }

    public int? FtwnCreatedBy { get; set; }

    public int? FtwnEditedBy { get; set; }

    public DateTime? FtwnCreationDate { get; set; }

    public DateTime? FtwnEditedDate { get; set; }
}
