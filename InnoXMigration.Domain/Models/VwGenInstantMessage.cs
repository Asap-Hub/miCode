using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenInstantMessage
{
    public int ImsIdpk { get; set; }

    public int? ImsRecipientEmpIdfk { get; set; }

    public int? EmpIdpk { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpMobNo { get; set; }

    public string? EmpMobNox { get; set; }

    public string? EmpName16 { get; set; }

    public string? ImsMessage { get; set; }

    public string? ImsMessageType { get; set; }

    public string? ImsFormCode { get; set; }

    public DateTime? ImsMaxTime { get; set; }

    public string? ImsOwner { get; set; }

    public string? ImsSender { get; set; }

    public int? ImsRecordIdfk { get; set; }

    public bool? ImsActive { get; set; }

    public int? ImsCreatedBy { get; set; }

    public int? ImsEditedBy { get; set; }

    public DateTime? ImsCreationDate { get; set; }

    public DateTime? ImsEditedDate { get; set; }

    public int? InitEmpId { get; set; }

    public string? InitStaffNo { get; set; }

    public string? InitLastName { get; set; }

    public string? InitFirstname { get; set; }

    public string? InitEmpName { get; set; }

    public string? InitEmpName12 { get; set; }

    public int? InitDptId { get; set; }

    public string? InitDptName { get; set; }

    public string? InitDptShtName { get; set; }

    public int? InitSxnId { get; set; }

    public string? InitSxnName { get; set; }

    public string? InitSxnShtName { get; set; }

    public int? InitLocId { get; set; }

    public string? InitLocName { get; set; }

    public string? InitLocShtName { get; set; }

    public int? InitJbtId { get; set; }

    public string? InitJbtName { get; set; }

    public string? InitJbtShtName { get; set; }

    public string? InitMobNox { get; set; }

    public string? EmpName12 { get; set; }

    public string? EmpName { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public string? SxnShtName { get; set; }

    public int? JbtIdpk { get; set; }

    public string? JbtName { get; set; }

    public string? JbtShtName { get; set; }

    public bool? ImsDeleted { get; set; }

    public string? InitEmpName16 { get; set; }

    public int? ImsInitiatorEmpIdfk { get; set; }
}
