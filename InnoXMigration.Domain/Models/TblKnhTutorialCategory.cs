using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblKnhTutorialCategory
{
    public int TctIdpk { get; set; }

    public string? TctName { get; set; }

    public string? TctShtName { get; set; }

    public string? TctRmks { get; set; }

    public bool? TctActive { get; set; }

    public int? TctCreatedBy { get; set; }

    public int? TctEditedBy { get; set; }

    public DateTime? TctCreationDate { get; set; }

    public DateTime? TctEditedDate { get; set; }
}
