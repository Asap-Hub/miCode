using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrGradenStepsx
{
    public int FgnsIdpk { get; set; }

    public int? FgnsGradeIdfk { get; set; }

    public int? FgnsStepIdfk { get; set; }

    public DateTime? FgnsDate { get; set; }

    public bool? FgnsActive { get; set; }

    public int? FgnsCreatedBy { get; set; }

    public int? FgnsEditedBy { get; set; }

    public DateTime? FgnsCreationDate { get; set; }

    public DateTime? FgnsEditedDate { get; set; }
}
