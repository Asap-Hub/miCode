using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsPmInventoryChecklistDetail
{
    public int PidIdpk { get; set; }

    public int? PidPmActivityIdfk { get; set; }

    public int? PidChecklisttemIdfk { get; set; }

    public DateTime? PidStartDate { get; set; }

    public DateTime? PidEndDate { get; set; }

    public decimal? PidCost { get; set; }

    public bool? PidBefore { get; set; }

    public bool? PidAfter { get; set; }

    public bool? PidActive { get; set; }

    public string? PidRmks { get; set; }

    public string? PidCreatedBy { get; set; }

    public int? PidEditedBy { get; set; }

    public DateTime? PidCreationDate { get; set; }

    public DateTime? PidEditedDate { get; set; }
}
