using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdTrendIndicator
{
    public int TinIdpk { get; set; }

    public string? TinName { get; set; }

    public string? TinShtName { get; set; }

    public string? TinColour { get; set; }

    public int TinProjectIdfk { get; set; }

    public byte? TinOrder { get; set; }

    public bool? TinActive { get; set; }

    public string? TinRmks { get; set; }

    public int? TinCreatedBy { get; set; }

    public int? TinEditedBy { get; set; }

    public DateTime? TinCreationDate { get; set; }

    public DateTime? TinEditedDate { get; set; }
}
