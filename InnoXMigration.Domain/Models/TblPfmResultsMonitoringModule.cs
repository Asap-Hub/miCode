using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPfmResultsMonitoringModule
{
    public int RmmIdpk { get; set; }

    public string? RmmName { get; set; }

    public string? RmmShtName { get; set; }

    public bool? RmmPickFrequencyFromModule { get; set; }

    public bool? RmmSingleAssignmentPerPeriod { get; set; }

    public bool? RmmSafetyManagerMeetingAttendance { get; set; }

    public bool? RmmTaskManager { get; set; }

    public bool? RmmHelpDesk { get; set; }

    public bool? RmmHrLeaveManagement { get; set; }

    public bool? RmmHospManagerMedicalExams { get; set; }

    public bool? RmmActive { get; set; }

    public string? RmmRmks { get; set; }

    public string? RmmCreatedBy { get; set; }

    public int? RmmEditedBy { get; set; }

    public DateTime? RmmCreationDate { get; set; }

    public DateTime? RmmEditedDate { get; set; }
}
