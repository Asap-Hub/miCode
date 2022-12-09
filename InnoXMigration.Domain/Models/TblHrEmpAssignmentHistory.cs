using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrEmpAssignmentHistory
{
    public short EahIdpk { get; set; }

    public string EahName { get; set; } = null!;

    public string EahshtName { get; set; } = null!;

    public bool? EahActive { get; set; }

    public int? EahCreatedBy { get; set; }

    public int? EahLastEditedBy { get; set; }

    public DateTime? EahCreationDate { get; set; }

    public DateTime? EahLastEditedDate { get; set; }
}
