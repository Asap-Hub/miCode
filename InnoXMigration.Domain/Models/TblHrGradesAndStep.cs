using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrGradesAndStep
{
    public int GnsIdpk { get; set; }

    public int? GnsGradeIdfk { get; set; }

    public int? GnsStepIdfk { get; set; }

    public DateTime? GnsDate { get; set; }

    public bool? GnsActive { get; set; }

    public int? GnsCreatedBy { get; set; }

    public int? GnsEditedBy { get; set; }

    public DateTime? GnsCreationDate { get; set; }

    public DateTime? GnsEditedDate { get; set; }
}
