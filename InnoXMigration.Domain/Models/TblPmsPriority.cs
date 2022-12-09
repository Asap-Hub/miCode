using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmsPriority
{
    public int PrtIdpk { get; set; }

    public string? PrtName { get; set; }

    public string? PrtShtName { get; set; }

    public decimal? PrtOrder { get; set; }

    public bool? PrtActive { get; set; }

    public string? PrtRmks { get; set; }

    public int? PrtCreatedBy { get; set; }

    public int? PrtEditedBy { get; set; }

    public DateTime? PrtCreationDate { get; set; }

    public DateTime? PrtEditedDate { get; set; }
}
