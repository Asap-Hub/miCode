using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftPpeSize
{
    public int PszIdpk { get; set; }

    public string? PszName { get; set; }

    public string? PszShtName { get; set; }

    public int? PszPpeTypeIdfk { get; set; }

    public bool? PszActive { get; set; }

    public string? PszRmks { get; set; }

    public int? PszCreatedBy { get; set; }

    public int? PszEditedBy { get; set; }

    public DateTime? PszCreationDate { get; set; }

    public DateTime? PszEditedDate { get; set; }
}
