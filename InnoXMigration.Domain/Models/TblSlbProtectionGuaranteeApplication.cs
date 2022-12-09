using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbProtectionGuaranteeApplication
{
    public int PgaIdpk { get; set; }

    public int? PgaStationIdfk { get; set; }

    public int? PgaGuaranteeTypeIdfk { get; set; }

    public string? PgaRequestNo { get; set; }

    public int? PgaRequestNox { get; set; }

    public DateTime? PgaTobeIssuedOn { get; set; }

    public DateTime? PgaTobeSurrenderedOn { get; set; }

    public DateTime? PgaWorkingStartTime { get; set; }

    public DateTime? PgaWorkingEndTime { get; set; }

    public string? PgaWorkingTime { get; set; }

    public DateTime? PgaOutageSwitchingStartTime { get; set; }

    public DateTime? PgaOutageSwitchingEndTime { get; set; }

    public string? PgaOutageSwitchingTime { get; set; }

    public DateTime? PgaRestoreSwitchingStartTime { get; set; }

    public DateTime? PgaRestoreSwitchingEndTime { get; set; }

    public string? PgaRestoreSwitchingTime { get; set; }

    public string? PgaSwitchingTimeAll { get; set; }

    public string? PgaDownTime { get; set; }

    public int? PgaDownTimeAllMins { get; set; }

    public int? PgaDownTimeHours { get; set; }

    public int? PgaDownTimeMins { get; set; }

    public string? PgaTobeIssuedTo { get; set; }

    public int? PgaTobeIssuedToEmpIdfk { get; set; }

    public string? PgaApplicantsOrganisation { get; set; }

    public string? PgaAdvancedRequestBy { get; set; }

    public string? PgaApparatusDescription { get; set; }

    public string? PgaAffectedEquipment { get; set; }

    public string? PgaAdditionalApparatus { get; set; }

    public string? PgaNotesOnReoutage { get; set; }

    public string? PgaApplicantsName { get; set; }

    public DateTime? PgaApplicationDate { get; set; }

    public string? PgaSubmittedBy { get; set; }

    public string? PgaReceivedBy { get; set; }

    public string? PgaForwardedBy { get; set; }

    public string? PgaAcknowledgedBy { get; set; }

    public string? PgaApprovedBy { get; set; }

    public string? PgaClearedBy { get; set; }

    public string? PgaSurrenderedBy { get; set; }

    public int? PgaSubmittedByEmpIdfk { get; set; }

    public int? PgaReceivedByEmpIdfk { get; set; }

    public int? PgaForwardedByEmpIdfk { get; set; }

    public int? PgaAcknowledgedByEmpIdfk { get; set; }

    public int? PgaApprovedByEmpIdfk { get; set; }

    public int? PgaClearedByEmpIdfk { get; set; }

    public int? PgaSurrenderedByEmpIdfk { get; set; }

    public int? PgaCancelledByEmpIdfk { get; set; }

    public bool? PgaSubmitted { get; set; }

    public bool? PgaReceived { get; set; }

    public bool? PgaForwarded { get; set; }

    public bool? PgaAcknowledged { get; set; }

    public bool? PgaApproved { get; set; }

    public bool? PgaCleared { get; set; }

    public bool? PgaSurrendered { get; set; }

    public bool? PgaRescheduled { get; set; }

    public bool? PgaDatesSet { get; set; }

    public bool? PgaCancelled { get; set; }

    public bool? PgaEmergency { get; set; }

    public bool? PgaJhaSubmitted { get; set; }

    public bool? PgaActive { get; set; }

    public string? PgaRmks { get; set; }

    public DateTime? PgaSubmittedOn { get; set; }

    public DateTime? PgaReceivedOn { get; set; }

    public DateTime? PgaForwardedOn { get; set; }

    public DateTime? PgaAcknowledgedOn { get; set; }

    public DateTime? PgaSurrenderedOn { get; set; }

    public DateTime? PgaApprovedOn { get; set; }

    public DateTime? PgaClearedOn { get; set; }

    public int? PgaCreatedBy { get; set; }

    public int? PgaEditedBy { get; set; }

    public DateTime? PgaCreationDate { get; set; }

    public DateTime? PgaEditedDate { get; set; }
}
