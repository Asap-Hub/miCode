using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftGroupGradesAssignment
{
    public int GgaIdpk { get; set; }

    public int? GgaGroupIdfk { get; set; }

    public int? GgaGradeNameIdfk { get; set; }

    public DateTime? GgaStartDate { get; set; }

    public DateTime? GgaEndDate { get; set; }

    public bool? GgaActive { get; set; }

    public string? GgaRmks { get; set; }

    public int? GgaCreatedBy { get; set; }

    public int? GgaEditedBy { get; set; }

    public DateTime? GgaCreationDate { get; set; }

    public DateTime? GgaEditedDate { get; set; }
}
