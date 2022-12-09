using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrOvertimeApproval
{
    public int OtaIdpk { get; set; }

    public int? OtaEmpIdfk { get; set; }

    public DateTime? OtaDate { get; set; }

    public short? OtaWeekdayHoursSubmitted { get; set; }

    public short? OtaWeekendHoursSubmitted { get; set; }

    public short? OtaHolidayHoursSubmitted { get; set; }

    public short? OtaTotalHoursSubmitted { get; set; }

    public short? OtaWeekdayHoursApproved { get; set; }

    public short? OtaWeekendHoursApproved { get; set; }

    public short? OtaHolidayHoursApproved { get; set; }

    public short? OtaTotalHoursApproved { get; set; }

    public short? OtaWeekdayHoursLeft { get; set; }

    public short? OtaWeekendHoursLeft { get; set; }

    public short? OtaHolidayHoursLeft { get; set; }

    public short? OtaTotalHoursLeft { get; set; }

    public int? OtaJobTitleIdfk { get; set; }

    public int? OtaDeptIdfk { get; set; }

    public int? OtaSectionIdfk { get; set; }

    public int? OtaUnitIdfk { get; set; }

    public int? OtaLocationIdfk { get; set; }

    public DateTime? OtaSubmittedOn { get; set; }

    public DateTime? OtaReviewedOn { get; set; }

    public DateTime? OtaEndorsedOn { get; set; }

    public DateTime? OtaApprovedOn { get; set; }

    public DateTime? OtaAuthorisedOn { get; set; }

    public DateTime? OtaLockedOn { get; set; }

    public int? OtaAdminEmpIdfk { get; set; }

    public int? OtaMgrEmpIdfk { get; set; }

    public int? OtaDirEmpIdfk { get; set; }

    public int? OtaCeEmpIdfk { get; set; }

    public int? OtaAuditorEmpIdfk { get; set; }

    public int? OtaLockedByEmpIdfk { get; set; }

    public bool? OtaSubmitted { get; set; }

    public bool? OtaLocked { get; set; }

    public bool? OtaReviewed { get; set; }

    public bool? OtaEndorsed { get; set; }

    public bool? OtaApproved { get; set; }

    public bool? OtaAuthorised { get; set; }

    public bool? OtaAudited { get; set; }

    public bool? OtaActive { get; set; }

    public string? OtaRmks { get; set; }

    public int? OtaCreatedBy { get; set; }

    public int? OtaEditedBy { get; set; }

    public DateTime? OtaCreationDate { get; set; }

    public DateTime? OtaEditedDate { get; set; }
}
