using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrGradesx
{
    public int FgrdIdpk { get; set; }

    public string? FgrdName { get; set; }

    public string? FgrdShtName { get; set; }

    public bool? FgrdActive { get; set; }

    public string? FgrdRmks { get; set; }

    public int? FgrdCreatedBy { get; set; }

    public int? FgrdEditedBy { get; set; }

    public DateTime? FgrdCreationDate { get; set; }

    public DateTime? FgrdEditedDate { get; set; }
}
