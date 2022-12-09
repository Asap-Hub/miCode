using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPjmProjectRevision
{
    public int PrvIdpk { get; set; }

    public int? PrvProjectIdfk { get; set; }

    public DateTime? PrvRevisionDate { get; set; }

    public string? PrvReason { get; set; }

    public bool? PrvActive { get; set; }

    public string? PrvRmks { get; set; }

    public int? PrvCreatedBy { get; set; }

    public int? PrvEditedBy { get; set; }

    public DateTime? PrvCreationDate { get; set; }

    public DateTime? PrvEditedDate { get; set; }
}
