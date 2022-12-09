using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenAccessPrivilegesHistory
{
    public int AphIdpk { get; set; }

    public int? AphUsaIdfk { get; set; }

    public int? AphFormIdfk { get; set; }

    public bool? AphInsert { get; set; }

    public bool? AphRead { get; set; }

    public bool? AphUpdate { get; set; }

    public bool? AphDelete { get; set; }

    public bool? AphPrint { get; set; }

    public int? AphCreatedBy { get; set; }

    public DateTime? AphCreationDate { get; set; }
}
