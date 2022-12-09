using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHmsHospCategory
{
    public int HctIdpk { get; set; }

    public string? HctName { get; set; }

    public string? HctShtName { get; set; }

    public bool? HctActive { get; set; }

    public string? HctRmks { get; set; }

    public string? HctCreatedBy { get; set; }

    public int? HctEditedBy { get; set; }

    public DateTime? HctCreationDate { get; set; }

    public DateTime? HctEditedDate { get; set; }
}
