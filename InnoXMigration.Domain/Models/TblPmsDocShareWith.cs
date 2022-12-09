using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmsDocShareWith
{
    public int SwtIdpk { get; set; }

    public int? SwtDocDetailIdfk { get; set; }

    public int? SwtEmpIdfk { get; set; }

    public bool? SwtOwner { get; set; }

    public bool? SwtReader { get; set; }

    public bool? SwtPrint { get; set; }

    public bool? SwtSign { get; set; }

    public string? SwtType { get; set; }

    public bool? SwtShareDocOnly { get; set; }

    public string? SwtSharedFrom { get; set; }

    public bool? SwtRead { get; set; }

    public bool? SwtActive { get; set; }

    public int? SwtCreatedBy { get; set; }

    public int? SwtEditedBy { get; set; }

    public DateTime? SwtCreationDate { get; set; }

    public DateTime? SwtEditedDate { get; set; }
}
