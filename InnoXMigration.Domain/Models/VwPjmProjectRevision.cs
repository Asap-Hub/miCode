using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPjmProjectRevision
{
    public int PrvIdpk { get; set; }

    public int? PrvProjectIdfk { get; set; }

    public DateTime? PrvRevisionDate { get; set; }

    public string? PrvReason { get; set; }

    public bool? PrvActive { get; set; }

    public string? PrvRmks { get; set; }

    public int PjrIdpk { get; set; }

    public string? PjrName { get; set; }

    public string? PjrShtName { get; set; }
}
