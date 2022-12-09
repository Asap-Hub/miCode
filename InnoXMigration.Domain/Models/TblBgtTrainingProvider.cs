using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtTrainingProvider
{
    public int TprIdpk { get; set; }

    public string? TprName { get; set; }

    public string? TprShtName { get; set; }

    public bool? TprActive { get; set; }

    public string? TprRmks { get; set; }

    public int? TprCreatedBy { get; set; }

    public int? TprEditedBy { get; set; }

    public DateTime? TprCreationDate { get; set; }

    public DateTime? TprEditedDate { get; set; }
}
