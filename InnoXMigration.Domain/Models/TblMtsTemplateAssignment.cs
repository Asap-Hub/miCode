using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsTemplateAssignment
{
    public int TmaIdpk { get; set; }

    public int? TmaTemplateTypeIdfk { get; set; }

    public int? TmaTemplateIdfk { get; set; }

    public int? TmaEmpIdfk { get; set; }

    public bool? TmaActive { get; set; }

    public string? TmaRmks { get; set; }

    public int? TmaCreatedBy { get; set; }

    public int? TmaEditedBy { get; set; }

    public DateTime? TmaCreationDate { get; set; }

    public DateTime? TmaEditedDate { get; set; }
}
