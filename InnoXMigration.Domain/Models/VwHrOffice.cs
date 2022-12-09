using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrOffice
{
    public int OfcIdpk { get; set; }

    public string? OfcName { get; set; }

    public string? OfcShtName { get; set; }

    public int? OfcLocationIdfk { get; set; }

    public bool? OfcActive { get; set; }

    public string? OfcRmks { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public int? LocAreaIdfk { get; set; }

    public bool? LocActive { get; set; }

    public string? LocRmks { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public bool? AreActive { get; set; }

    public string? AreRmks { get; set; }
}
