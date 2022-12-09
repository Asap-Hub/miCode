using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsEmpDocsShareWith
{
    public int SwtIdpk { get; set; }

    public int? SwtDocDetailIdfk { get; set; }

    public int? SwtEmpIdfk { get; set; }

    public bool? SwtOwn { get; set; }

    public bool? SwtUpdate { get; set; }

    public bool? SwtRead { get; set; }

    public bool? SwtLock { get; set; }

    public bool? SwtPrint { get; set; }

    public bool? SwtActive { get; set; }

    public bool? SwtSign { get; set; }

    public string? SwtTask { get; set; }

    public string? SwtType { get; set; }

    public int? SwtCreatedBy { get; set; }

    public DateTime? SwtCreationDate { get; set; }

    public int? SwtEditedBy { get; set; }

    public DateTime? SwtEditedDate { get; set; }
}
