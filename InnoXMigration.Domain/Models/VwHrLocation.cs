using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrLocation
{
    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public int? LocAreaIdfk { get; set; }

    public bool? LocActive { get; set; }

    public string LocRmks { get; set; } = null!;

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public bool? AreActive { get; set; }

    public string AreRmks { get; set; } = null!;

    public DateTime? LocStartDate { get; set; }

    public DateTime? LocEndDate { get; set; }

    public string LocCode { get; set; } = null!;
}
