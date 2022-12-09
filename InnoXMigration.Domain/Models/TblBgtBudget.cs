using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtBudget
{
    public int BgtIdpk { get; set; }

    public string? BgtName { get; set; }

    public string? BgtShtName { get; set; }

    public DateTime? BgtStartDate { get; set; }

    public DateTime? BgtEndDate { get; set; }

    public bool? BgtOpened { get; set; }

    public bool? BgtActive { get; set; }

    public string? BgtRmks { get; set; }

    public int? BgtCreatedBy { get; set; }

    public int? BgtEditedBy { get; set; }

    public DateTime? BgtCreationDate { get; set; }

    public DateTime? BgtEditedDate { get; set; }
}
