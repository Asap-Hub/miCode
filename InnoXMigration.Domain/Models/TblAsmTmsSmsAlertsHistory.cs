using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsSmsAlertsHistory
{
    public int SahIdpk { get; set; }

    public int? SahMaintenanceScheduleIdfk { get; set; }

    public int? SahRecipientEmpIdfk { get; set; }

    public string? SahType { get; set; }

    public string? SahMessage { get; set; }

    public string? SahMobNo { get; set; }

    public bool? SahActive { get; set; }

    public string? SahRmks { get; set; }

    public string? SahCreatedBy { get; set; }

    public int? SahEditedBy { get; set; }

    public DateTime? SahCreationDate { get; set; }

    public DateTime? SahEditedDate { get; set; }
}
