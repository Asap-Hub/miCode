using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmgObjectiveDestination
{
    public int OdsIdpk { get; set; }

    public int? OdsObjectiveIdfk { get; set; }

    public DateTime? OdsStartDate { get; set; }

    public DateTime? OdsEndDate { get; set; }

    public string? OdsFrom { get; set; }

    public string? OdsTo { get; set; }

    public bool? OdsActive { get; set; }

    public string? OdsRmks { get; set; }

    public int? OdsCreatedBy { get; set; }

    public int? OdsEditedBy { get; set; }

    public DateTime? OdsCreationDate { get; set; }

    public DateTime? OdsEditedDate { get; set; }
}
