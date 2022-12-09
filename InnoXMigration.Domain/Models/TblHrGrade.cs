using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrGrade
{
    public int GrdIdpk { get; set; }

    public string? GrdName { get; set; }

    public string? GrdShtName { get; set; }

    public bool? GrdActive { get; set; }

    public string? GrdRmks { get; set; }

    public int? GrdCreatedBy { get; set; }

    public int? GrdEditedBy { get; set; }

    public DateTime? GrdCreationDate { get; set; }

    public DateTime? GrdEditedDate { get; set; }
}
