using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrLocation
{
    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public int? LocAreaIdfk { get; set; }

    public DateTime? LocStartDate { get; set; }

    public string? LocCode { get; set; }

    public DateTime? LocEndDate { get; set; }

    public bool? LocActive { get; set; }

    public string? LocRmks { get; set; }

    public int? LocCreatedBy { get; set; }

    public int? LocEditedBy { get; set; }

    public DateTime? LocCreationDate { get; set; }

    public DateTime? LocEditedDate { get; set; }
}
