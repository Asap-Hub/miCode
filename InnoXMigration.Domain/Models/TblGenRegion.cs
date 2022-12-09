using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenRegion
{
    public int RgnIdpk { get; set; }

    public string? RgnName { get; set; }

    public string? RgnShtName { get; set; }

    public int? RgnCountryIdfk { get; set; }

    public string? RgnCode { get; set; }

    public string? RgnCapital { get; set; }

    public bool? RgnActive { get; set; }

    public string? RgnRemarks { get; set; }

    public int? RgnCreatedBy { get; set; }

    public int? RgnLastEditedBy { get; set; }

    public DateTime? RgnCreationDate { get; set; }

    public DateTime? RgnLastEditedDate { get; set; }
}
