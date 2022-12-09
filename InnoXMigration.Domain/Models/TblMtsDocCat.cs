using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsDocCat
{
    public int DctIdpk { get; set; }

    public string? DctName { get; set; }

    public string? DctShtName { get; set; }

    public int? DctOrder { get; set; }

    public bool? DctActive { get; set; }

    public string? DctRmks { get; set; }

    public int? DctEditedBy { get; set; }

    public int? DctCreatedBy { get; set; }

    public DateTime? DctCreationDate { get; set; }

    public DateTime? DctEditedDate { get; set; }
}
