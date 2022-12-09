using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPfmStaffInitiative
{
    public int SinIdpk { get; set; }

    public string? SinName { get; set; }

    public string? SinShtName { get; set; }

    public bool? SinPreventManualUpdatesForAll { get; set; }

    public bool? SinPreventStaffSelfAssignmentForAll { get; set; }

    public bool? SinEnforceResultMonitoringModule { get; set; }

    public int? SinResultMonitoringModuleIdfk { get; set; }

    public decimal? SinOrder { get; set; }

    public bool? SinActive { get; set; }

    public string? SinRmks { get; set; }

    public string? SinCreatedBy { get; set; }

    public int? SinEditedBy { get; set; }

    public DateTime? SinCreationDate { get; set; }

    public DateTime? SinEditedDate { get; set; }
}
