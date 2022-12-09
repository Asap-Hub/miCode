using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrEmployeeCategory
{
    public int EctIdpk { get; set; }

    public string? EctName { get; set; }

    public string? EctShtName { get; set; }

    public bool? EctActive { get; set; }

    public string? EctRmks { get; set; }

    public int? EctCreatedBy { get; set; }

    public int? EctEditedBy { get; set; }

    public DateTime? EctCreationDate { get; set; }

    public DateTime? EctEditedDate { get; set; }
}
