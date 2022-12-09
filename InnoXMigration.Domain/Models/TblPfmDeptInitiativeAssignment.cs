using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPfmDeptInitiativeAssignment
{
    public int DiaIdpk { get; set; }

    public int? DiaPeriodIdfk { get; set; }

    public int? DiaDeptIdfk { get; set; }

    public int? DiaObjectiveIdfk { get; set; }

    public int? DiaCorporateInitiativeIdfk { get; set; }

    public int? DiaDeptInitiativeIdfk { get; set; }

    public bool? DiaActive { get; set; }

    public string? DiaRmks { get; set; }

    public int? DiaCreatedBy { get; set; }

    public int? DiaEditedBy { get; set; }

    public DateTime? DiaCreationDate { get; set; }

    public DateTime? DiaEditedDate { get; set; }
}
