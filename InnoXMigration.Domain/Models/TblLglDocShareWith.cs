using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblLglDocShareWith
{
    public int SwtIdpk { get; set; }

    public int? SwtCaseIdfk { get; set; }

    public int? SwtEmpIdfk { get; set; }

    public bool? SwtOwner { get; set; }

    public bool? SwtUpdate { get; set; }

    public bool? SwtReader { get; set; }

    public bool? SwtPrint { get; set; }

    public string? SwtTask { get; set; }

    public bool? SwtSign { get; set; }

    public string? SwtType { get; set; }

    public bool? SwtRead { get; set; }

    public bool? SwtActive { get; set; }

    public int? SwtCreatedBy { get; set; }

    public DateTime? SwtCreationDate { get; set; }

    public int? SwtEditedBy { get; set; }

    public DateTime? SwtEditedDate { get; set; }
}
