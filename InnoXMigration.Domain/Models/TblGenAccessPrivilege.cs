using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenAccessPrivilege
{
    public int ApvIdpk { get; set; }

    public int? ApvUsaIdfk { get; set; }

    public int? ApvFormIdfk { get; set; }

    public bool? ApvInsert { get; set; }

    public bool? ApvRead { get; set; }

    public bool? ApvUpdate { get; set; }

    public bool? ApvDelete { get; set; }

    public bool? ApvPrint { get; set; }

    public int? ApvCreatedBy { get; set; }

    public int? ApvEditedBy { get; set; }

    public DateTime? ApvCreationDate { get; set; }

    public DateTime? ApvEditedDate { get; set; }
}
