using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtBudgetUnit
{
    public int BduIdpk { get; set; }

    public string? BduName { get; set; }

    public string? BduShtName { get; set; }

    public bool? BduActive { get; set; }

    public string? BduRmks { get; set; }

    public int? BduCreatedBy { get; set; }

    public int? BduEditedBy { get; set; }

    public DateTime? BduCreationDate { get; set; }

    public DateTime? BduEditedDate { get; set; }
}
