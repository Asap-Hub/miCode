using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenTaskAssignment
{
    public int TasIdpk { get; set; }

    public int? TasTaskIdfk { get; set; }

    public int? TasAssignedByEmpIdfk { get; set; }

    public int? TasAssignedToEmpIdfk { get; set; }

    public bool? TasActive { get; set; }

    public DateTime? TasCreationDate { get; set; }

    public int? TasCreatedBy { get; set; }

    public int? TasEditedBy { get; set; }

    public DateTime? TasEditedDate { get; set; }
}
