using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPrlEmployeesPayItemsAssignment
{
    public int EpaIdpk { get; set; }

    public int? EpaEmpIdfk { get; set; }

    public int? EpaElementIdfk { get; set; }

    public DateTime? EpaStartDate { get; set; }

    public DateTime? EpaEndDate { get; set; }

    public bool? EpaActive { get; set; }

    public string? EpaRmks { get; set; }

    public int? EpaCreatedBy { get; set; }

    public int? EpaEditedBy { get; set; }

    public DateTime? EpaCreationDate { get; set; }

    public DateTime? EpaEditedDate { get; set; }
}
