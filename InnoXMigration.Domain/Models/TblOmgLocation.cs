using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblOmgLocation
{
    public int LocIdpk { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public string? LocCode { get; set; }

    public bool? LocActive { get; set; }

    public string? LocRmks { get; set; }

    public int? LocCreatedBy { get; set; }

    public int? LocEditedBy { get; set; }

    public DateTime? LocCreationDate { get; set; }

    public DateTime? LocEditedDate { get; set; }
}
