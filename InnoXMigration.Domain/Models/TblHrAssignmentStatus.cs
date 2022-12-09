using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrAssignmentStatus
{
    public int AstIdpk { get; set; }

    public string? AstName { get; set; }

    public string? AstShtName { get; set; }

    public bool? AstActive { get; set; }

    public string? AstRmks { get; set; }

    public int? AstCreatedBy { get; set; }

    public int? AstEditedBy { get; set; }

    public DateTime? AstCreationDate { get; set; }

    public DateTime? AstEditedDate { get; set; }
}
