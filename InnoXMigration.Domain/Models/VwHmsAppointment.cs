using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHmsAppointment
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

    public int? HdtIdpk { get; set; }

    public string? HdtName { get; set; }

    public string? HdtShtName { get; set; }

    public string? HdtMobNos { get; set; }

    public string? HdtEmail { get; set; }

    public string? HdtWhatsappNo { get; set; }

    public int? TwnIdpk { get; set; }

    public string? TwnName { get; set; }

    public string? TwnShtName { get; set; }

    public int? RgnIdpk { get; set; }

    public string? RgnName { get; set; }

    public int? CtyIdpk { get; set; }

    public string? CtyName { get; set; }

    public string? CtyShtName { get; set; }

    public int RequesterEmpId { get; set; }

    public string? RequesterStaffNo { get; set; }

    public string? RequesterLname { get; set; }

    public string? RequesterFname { get; set; }

    public string RequesterOnames { get; set; } = null!;

    public string? RequesterEmpName { get; set; }

    public int RequesterDeptId { get; set; }

    public string RequesterDptName { get; set; } = null!;

    public string RequesterDptShtName { get; set; } = null!;

    public int RequesterSxnId { get; set; }

    public string RequesterSxnName { get; set; } = null!;

    public string RequesterSxnShtName { get; set; } = null!;

    public int RequesterUntId { get; set; }

    public string RequesterUntName { get; set; } = null!;

    public string RequesterUntShtName { get; set; } = null!;

    public int RequesterLocId { get; set; }

    public string RequesterLocName { get; set; } = null!;

    public string RequesterLocShtName { get; set; } = null!;

    public int RequesterJbtId { get; set; }

    public string RequesterJbtName { get; set; } = null!;

    public string RequesterJbtShtName { get; set; } = null!;

    public int? RtpIdpk { get; set; }

    public string? RtpName { get; set; }

    public string? RtpShtName { get; set; }

    public bool? RtpActive { get; set; }

    public string RequesterMobNox { get; set; } = null!;
}
