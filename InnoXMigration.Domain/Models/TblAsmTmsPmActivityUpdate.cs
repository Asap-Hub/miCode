using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsPmActivityUpdate
{
    public int PauIdpk { get; set; }

    public DateTime? PauDate { get; set; }

    public int? PauPreventiveMaintActivityIdfk { get; set; }

    public string? PauActivityUpdate { get; set; }

    public decimal? PauPercentComplete { get; set; }

    public DateTime? PauCompletionDate { get; set; }

    public bool? PauActive { get; set; }

    public string? PauRmks { get; set; }

    public string? PauCreatedBy { get; set; }

    public int? PauEditedBy { get; set; }

    public DateTime? PauCreationDate { get; set; }

    public DateTime? PauEditedDate { get; set; }
}
