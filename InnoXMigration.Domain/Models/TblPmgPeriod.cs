using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmgPeriod
{
    public int PrdIdpk { get; set; }

    public string? PrdName { get; set; }

    public string? PrdShtName { get; set; }

    public DateTime? PrdStartDate { get; set; }

    public DateTime? PrdEndDate { get; set; }

    public bool? PrdOpened { get; set; }

    public bool? PrdActive { get; set; }

    public string? PrdRmks { get; set; }

    public string? PrdCreatedBy { get; set; }

    public int? PrdEditedBy { get; set; }

    public DateTime? PrdCreationDate { get; set; }

    public DateTime? PrdEditedDate { get; set; }
}
