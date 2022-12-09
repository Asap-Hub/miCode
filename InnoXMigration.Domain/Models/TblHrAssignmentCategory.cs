using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrAssignmentCategory
{
    public int AscIdpk { get; set; }

    public string? AscName { get; set; }

    public string? AscShtName { get; set; }

    public bool? AscActive { get; set; }

    public string? AscRmks { get; set; }

    public int? AscCreatedBy { get; set; }

    public int? AscEditedBy { get; set; }

    public DateTime? AscCreationDate { get; set; }

    public DateTime? AscEditedDate { get; set; }
}
