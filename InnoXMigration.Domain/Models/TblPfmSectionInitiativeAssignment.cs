using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPfmSectionInitiativeAssignment
{
    public int SxiIdpk { get; set; }

    public int? SxiPeriodIdfk { get; set; }

    public int? SxiBudgetIdfk { get; set; }

    public int? SxiDeptIdfk { get; set; }

    public int? SxiSectionIdfk { get; set; }

    public int? SxiObjectiveIdfk { get; set; }

    public int? SxiInitiativeIdfk { get; set; }

    public bool? SxiActive { get; set; }

    public string? SxiRmks { get; set; }

    public int? SxiCreatedBy { get; set; }

    public int? SxiEditedBy { get; set; }

    public DateTime? SxiCreationDate { get; set; }

    public DateTime? SxiEditedDate { get; set; }
}
