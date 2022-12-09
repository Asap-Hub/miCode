using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblFinPeriodDetail
{
    public int PdtIdpk { get; set; }

    public string? PdtName { get; set; }

    public string? PdtShtName { get; set; }

    public DateTime? PdtStartDate { get; set; }

    public DateTime? PdtEndDate { get; set; }

    public bool? PdtOpened { get; set; }

    public bool? PdtActive { get; set; }

    public string? PdtRmks { get; set; }

    public string? PdtCreatedBy { get; set; }

    public int? PdtEditedBy { get; set; }

    public DateTime? PdtCreationDate { get; set; }

    public DateTime? PdtEditedDate { get; set; }
}
