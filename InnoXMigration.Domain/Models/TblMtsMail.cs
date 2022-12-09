using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsMail
{
    public int MtrIdpk { get; set; }

    public DateTime? MtrDocDate { get; set; }

    public DateTime? MtrRecDate { get; set; }

    public DateTime? MtrOutDate { get; set; }

    public string? MtrFileNo { get; set; }

    public string? MtrSubject { get; set; }

    public string? MtrSummaryContent { get; set; }

    public string? MtrIncomingNotes { get; set; }

    public string? MtrOutgoingMinutes { get; set; }

    public string? MtrOutTo { get; set; }

    public string? MtrCc { get; set; }

    public string? MtrBcc { get; set; }

    public bool? MtrIncoming { get; set; }

    public bool? MtrOutgoing { get; set; }

    public string? MtrShareWith { get; set; }

    public int? MtrAssignmentUnitIdfk { get; set; }

    public int? MtrDocSrcIdfk { get; set; }

    public int? MtrFwdFromIdfk { get; set; }

    public int? MtrSignedByIdfk { get; set; }

    public int? MtrSignedForIdfk { get; set; }

    public int? MtrDocTypeIdfk { get; set; }

    public int? MtrDocClassIdfk { get; set; }

    public int? MtrDocSubClassIdfk { get; set; }

    public int? MtrDocUnitIdfk { get; set; }

    public int? MtrNum { get; set; }

    public string? MtrType { get; set; }

    public string? MtrRmks { get; set; }

    public bool? MtrDispatched { get; set; }

    public bool? MtrRegistered { get; set; }

    public bool? MtrHasAttachment { get; set; }

    public bool? MtrLocked { get; set; }

    public int? MtrLockedByIdfk { get; set; }

    public DateTime? MtrLockedDate { get; set; }

    public int? MtrUnlockedByIdfk { get; set; }

    public DateTime? MtrUnlockedDate { get; set; }

    public int? MtrCreatedBy { get; set; }

    public int? MtrEditedBy { get; set; }

    public DateTime? MtrCreationDate { get; set; }

    public DateTime? MtrEditedDate { get; set; }

    public DateTime? MtrSignDate { get; set; }
}
