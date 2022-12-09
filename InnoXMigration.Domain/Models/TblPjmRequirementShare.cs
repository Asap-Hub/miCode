using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPjmRequirementShare
{
    public int PrsIdpk { get; set; }

    public int? PrsProjectIdfk { get; set; }

    public int? PrsEmpIdfk { get; set; }

    public bool? PrsOwner { get; set; }

    public bool? PrsUpdate { get; set; }

    public bool? PrsReader { get; set; }

    public bool? PrsSign { get; set; }

    public string? PrsType { get; set; }

    public bool? PrsRead { get; set; }

    public int? PrsCreatedBy { get; set; }

    public DateTime? PrsCreationDate { get; set; }

    public int? PrsEditedBy { get; set; }

    public DateTime? PrsEditedDate { get; set; }
}
