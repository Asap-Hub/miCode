using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdProjectStreamDetail
{
    public int PsdIdpk { get; set; }

    public DateTime? PsdStartDate { get; set; }

    public DateTime? PsdEndDate { get; set; }

    public string? PsdName { get; set; }

    public int? PrjIdpk { get; set; }

    public string? PrjName { get; set; }

    public string? PrjShtName { get; set; }

    public DateTime? PrjStartDate { get; set; }

    public int? TinIdpk { get; set; }

    public string? TinName { get; set; }

    public string? TinShtName { get; set; }

    public string? TinColour { get; set; }

    public int? PsgIdpk { get; set; }

    public string? PsgName { get; set; }

    public string? PsgShtName { get; set; }

    public bool? PsdActive { get; set; }

    public string? PsdRmks { get; set; }
}
