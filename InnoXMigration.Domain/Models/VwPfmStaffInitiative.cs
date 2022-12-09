using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmStaffInitiative
{
    public int SinIdpk { get; set; }

    public string? SinName { get; set; }

    public string? SinShtName { get; set; }

    public bool? SinPreventManualUpdatesForAll { get; set; }

    public bool? SinPreventStaffSelfAssignmentForAll { get; set; }

    public bool? SinEnforceResultMonitoringModule { get; set; }

    public int? SinResultMonitoringModuleIdfk { get; set; }

    public bool? SinActive { get; set; }

    public string? SinRmks { get; set; }

    public int? RmmIdpk { get; set; }

    public string? RmmName { get; set; }

    public string? RmmShtName { get; set; }

    public bool? RmmPickFrequencyFromModule { get; set; }

    public bool? RmmSingleAssignmentPerPeriod { get; set; }

    public bool? RmmSafetyManagerMeetingAttendance { get; set; }

    public bool? RmmTaskManager { get; set; }

    public bool? RmmHelpDesk { get; set; }

    public bool? RmmHrLeaveManagement { get; set; }

    public bool? RmmActive { get; set; }

    public bool? RmmHospManagerMedicalExams { get; set; }
}
