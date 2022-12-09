using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbLogBook
{
    public int LbkIdpk { get; set; }

    public DateTime? LbkLogDate { get; set; }

    public int? LbkEventTypeIdfk { get; set; }

    public int? LbkLogStationIdfk { get; set; }

    public int? LbkHomeStationIdfk { get; set; }

    public string? LbkEvent { get; set; }

    public int? EvtIdpk { get; set; }

    public string? EvtName { get; set; }

    public string? EvtShtName { get; set; }

    public bool? EvtActive { get; set; }

    public string? EvtRmks { get; set; }

    public int? LbkCorrespondentIdfk { get; set; }

    public DateTime? LbkCreationDate { get; set; }

    public bool? LbkDeleted { get; set; }

    public int? HomeStationId { get; set; }

    public string? HomeStationName { get; set; }

    public string? HomeStationShtName { get; set; }

    public bool? HomeStationActive { get; set; }

    public string? HomeStationRmks { get; set; }

    public int? LoggedByUsaId { get; set; }

    public int? LoggedByEmpId { get; set; }

    public string? LoggedByStaffNo { get; set; }

    public string? LoggedByName { get; set; }

    public string? LoggedByName1 { get; set; }

    public string? LoggedByName2 { get; set; }

    public string? LoggedByName3 { get; set; }

    public string? CorrespondentStaffNo { get; set; }

    public string? CorrespondentName1 { get; set; }

    public string? CorrespondentName2 { get; set; }

    public string? CorrespondentName3 { get; set; }

    public string? CorrespondentName { get; set; }

    public int? LogStationId { get; set; }

    public string? LogStationName { get; set; }

    public string? LogStationShtName { get; set; }

    public string? LogStationCode { get; set; }

    public string? LogStationContact { get; set; }

    public string? LogStationTelNo { get; set; }

    public string? LogStationAtPlc { get; set; }

    public bool? LogStationActive { get; set; }

    public bool? LbkFirstLog { get; set; }

    public int? CrdIdpk { get; set; }

    public bool? LbkActive { get; set; }

    public bool LbkFlag { get; set; }

    public bool LbkComment { get; set; }

    public int? LbkCreatedBy { get; set; }

    public int? TimeDiff { get; set; }

    public string? LbkRmks { get; set; }

    public int LbkEditedBy { get; set; }

    public DateTime? LbkEditedDate { get; set; }

    public bool LbkSynced { get; set; }

    public DateTime? LbkLastSyncedOn { get; set; }
}
