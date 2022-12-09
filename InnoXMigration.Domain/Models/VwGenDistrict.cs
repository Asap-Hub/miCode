using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenDistrict
{
    public int DstIdpk { get; set; }

    public string? DstName { get; set; }

    public string? DstShtName { get; set; }

    public int? DstRegionIdfk { get; set; }

    public bool? DstActive { get; set; }

    public string? DstRemarks { get; set; }

    public int? RgnIdpk { get; set; }

    public string? RgnName { get; set; }

    public string? RgnShtName { get; set; }

    public int? RgnCountryIdfk { get; set; }

    public bool? RgnActive { get; set; }

    public string? RgnRemarks { get; set; }

    public int? RgnCreatedBy { get; set; }

    public int? RgnLastEditedBy { get; set; }

    public DateTime? RgnCreationDate { get; set; }

    public DateTime? RgnLastEditedDate { get; set; }

    public int? CtyIdpk { get; set; }

    public string? CtyName { get; set; }

    public string? CtyShtName { get; set; }

    public string? CtyNationality { get; set; }

    public bool? CtyActive { get; set; }

    public string? CtyRmks { get; set; }

    public string? DstCapial { get; set; }

    public string? RgnCapital { get; set; }

    public string? CtyCapital { get; set; }
}
