using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrPromotionsHistory
{
    public int PhsIdpk { get; set; }

    public int? PhsEmpIdfk { get; set; }

    public int? PhsGradeIdfk { get; set; }

    public int? PhsStepIdfk { get; set; }

    public DateTime? PhsDate { get; set; }

    public int? PhsCreatedBy { get; set; }

    public int? PhsEditedBy { get; set; }

    public DateTime? PhsCreationDate { get; set; }

    public DateTime? PhsEditedDate { get; set; }
}
