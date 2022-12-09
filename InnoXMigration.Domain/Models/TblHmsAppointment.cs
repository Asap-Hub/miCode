using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHmsAppointment
{
    public int ApnIdpk { get; set; }

    public int ApnRequestId { get; set; }

    public int? ApnEmpIdfk { get; set; }

    public string? ApnCategory { get; set; }

    public DateTime? ApnRequestStartTime { get; set; }

    public DateTime? ApnRequestEndTime { get; set; }

    public DateTime? ApnScheduleStartTime { get; set; }

    public DateTime? ApnScheduleEndTme { get; set; }

    public int? ApnFacilityIdfk { get; set; }

    public int? ApnRequestTypeIdfk { get; set; }

    public string? ApnDetails { get; set; }

    public bool? ApnScheduled { get; set; }

    public bool? ApnActive { get; set; }

    public int? ApnScheduledByEmpIdfk { get; set; }

    public DateTime? ApnScheduledOn { get; set; }

    public string? ApnRmks { get; set; }

    public string? ApnCreatedBy { get; set; }

    public int? ApnEditedBy { get; set; }

    public DateTime? ApnCreationDate { get; set; }

    public DateTime? ApnEditedDate { get; set; }
}
