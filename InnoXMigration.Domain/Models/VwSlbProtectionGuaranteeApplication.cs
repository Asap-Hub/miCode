using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbProtectionGuaranteeApplication
{
    public int PgaIdpk { get; set; }

    public int? PgaStationIdfk { get; set; }

    public DateTime? PgaTobeIssuedOn { get; set; }

    public DateTime? PgaTobeSurrenderedOn { get; set; }

    public DateTime? PgaWorkingStartTime { get; set; }

    public DateTime? PgaWorkingEndTime { get; set; }

    public DateTime? PgaOutageSwitchingStartTime { get; set; }

    public DateTime? PgaOutageSwitchingEndTime { get; set; }

    public string? PgaOutageSwitchingTime { get; set; }

    public DateTime? PgaRestoreSwitchingStartTime { get; set; }

    public DateTime? PgaRestoreSwitchingEndTime { get; set; }

    public string? PgaRestoreSwitchingTime { get; set; }

    public string? PgaTobeIssuedTo { get; set; }

    public string? PgaApplicantsOrganisation { get; set; }

    public string? PgaAdvancedRequestBy { get; set; }

    public string? PgaApplicantsName { get; set; }

    public DateTime? PgaApplicationDate { get; set; }

    public int? PgaGuaranteeTypeIdfk { get; set; }

    public int PgtIdpk { get; set; }

    public string? PgtName { get; set; }

    public string? PgtShtName { get; set; }

    public string? PgtCode { get; set; }

    public bool? PgtWorkPermit { get; set; }

    public bool? PgtWorkAndTestPermit { get; set; }

    public bool? PgtStationGuarantee { get; set; }

    public bool? PgtActive { get; set; }

    public string? PgaRequestNo { get; set; }

    public string PgaApprovedBy { get; set; } = null!;

    public string PgaClearedBy { get; set; } = null!;

    public bool PgaEmergency { get; set; }

    public bool PgaActive { get; set; }

    public string? PgaRmks { get; set; }

    public int StnIdpk { get; set; }

    public string StnName { get; set; } = null!;

    public string StnShtName { get; set; } = null!;

    public string StnCode { get; set; } = null!;

    public string? PgaApparatusDescription { get; set; }

    public string? PgaAffectedEquipment { get; set; }

    public string? PgaAdditionalApparatus { get; set; }

    public string? PgaNotesOnReoutage { get; set; }

    public bool PgaApproved { get; set; }

    public bool PgaSubmitted { get; set; }

    public int PgaReceivedByEmpIdfk { get; set; }

    public DateTime? PgaReceivedOn { get; set; }

    public int PgaApprovedByEmpIdfk { get; set; }

    public int PgaSubmittedByEmpIdfk { get; set; }

    public DateTime? PgaSubmittedOn { get; set; }

    public int? PgaCreatedBy { get; set; }

    public int RecByEmpId { get; set; }

    public string RecByStaffNo { get; set; } = null!;

    public string RecByLname { get; set; } = null!;

    public string RecByFname { get; set; } = null!;

    public string RecByEmpName1 { get; set; } = null!;

    public string RecByEmpName17 { get; set; } = null!;

    public string RecByEmpName18 { get; set; } = null!;

    public int SubmitByEmpId { get; set; }

    public string SubmitByStaffNo { get; set; } = null!;

    public string SubmitByLname { get; set; } = null!;

    public string SubmitByFname { get; set; } = null!;

    public string SubmitByEmpName1 { get; set; } = null!;

    public string SubmitByEmpName17 { get; set; } = null!;

    public string SubmitByEmpName18 { get; set; } = null!;

    public int PgaTobeIssuedToEmpIdfk { get; set; }

    public bool StnShowInElogBook { get; set; }

    public string PgaSubmittedBy { get; set; } = null!;

    public string PgaDownTime { get; set; } = null!;

    public int PgaDownTimeAllMins { get; set; }

    public int PgaDownTimeHours { get; set; }

    public int PgaDownTimeMins { get; set; }

    public string PgaWorkingTime { get; set; } = null!;

    public string PgaSwitchingTimeAll { get; set; } = null!;

    public bool PgaReceived { get; set; }

    public string PgaReceivedBy { get; set; } = null!;

    public bool PgaForwarded { get; set; }

    public int PgaForwardedByEmpIdfk { get; set; }

    public DateTime? PgaForwardedOn { get; set; }

    public bool PgaSurrendered { get; set; }

    public bool PgaCancelled { get; set; }

    public bool PgaAcknowledged { get; set; }

    public bool PgaDatesSet { get; set; }

    public string? PgaAcknowledgedBy { get; set; }

    public bool PgaCleared { get; set; }

    public string PgaSurrenderedBy { get; set; } = null!;

    public int PgaClearedByEmpIdfk { get; set; }

    public int PgaSurrenderedByEmpIdfk { get; set; }

    public DateTime? PgaClearedOn { get; set; }

    public bool? PgaJhaSubmitted { get; set; }
}
