using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdTrendIndicator
{
    public int TinIdpk { get; set; }

    public string? TinName { get; set; }

    public string? TinShtName { get; set; }

    public string? TinColour { get; set; }

    public byte? TinOrder { get; set; }

    public bool? TinActive { get; set; }

    public string? TinRmks { get; set; }

    public int? PrjIdpk { get; set; }

    public string? PrjName { get; set; }

    public string? PrjShtName { get; set; }

    public int TinProjectIdfk { get; set; }
}
