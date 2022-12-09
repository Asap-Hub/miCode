using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPjmProjectName
{
    public int PnmIdpk { get; set; }

    public string? PnmName { get; set; }

    public string? PnmShtName { get; set; }

    public DateTime? PnmStartDate { get; set; }

    public DateTime? PnmActualEndDate { get; set; }

    public DateTime? PnmProposedEndDate { get; set; }

    public byte? PnmNoOfPhases { get; set; }

    public bool? PnmActive { get; set; }

    public string? PnmRmks { get; set; }

    public int? PnmCreatedBy { get; set; }

    public int? PnmEditedBy { get; set; }

    public DateTime? PnmCreationDate { get; set; }

    public DateTime? PnmEditedDate { get; set; }
}
