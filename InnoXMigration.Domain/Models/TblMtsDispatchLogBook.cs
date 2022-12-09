using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsDispatchLogBook
{
    public int DlbIdpk { get; set; }

    public int? DlbEmpIdfk { get; set; }

    public string? DlbRecipient { get; set; }

    public DateTime? DlbDocDate { get; set; }

    public DateTime? DlbRecDate { get; set; }

    public DateTime? DlbOutDate { get; set; }

    public string? DlbFileNo { get; set; }

    public string? DlbSubject { get; set; }

    public string? DlbIncomingNotes { get; set; }

    public string? DlbOutgoingMinutes { get; set; }

    public string? DlbShareWith { get; set; }

    public int? DlbAssignmentUnitIdfk { get; set; }

    public int? DlbDocSrcIdfk { get; set; }

    public int? DlbFwdFromIdfk { get; set; }

    public int? DlbSignedByIdfk { get; set; }

    public int? DlbSignedForIdfk { get; set; }

    public int? DlbDocTypeIdfk { get; set; }

    public int? DlbDocClassIdfk { get; set; }

    public int? DlbDocSubClassIdfk { get; set; }

    public int? DlbNum { get; set; }

    public string? DlbType { get; set; }

    public string? DlbRmks { get; set; }

    public bool? DlbIsStaff { get; set; }

    public bool? DlbDispatched { get; set; }

    public bool? DlbHasAttachment { get; set; }

    public int? DlbCreatedBy { get; set; }

    public int? DlbEditedBy { get; set; }

    public DateTime? DlbCreationDate { get; set; }

    public DateTime? DlbEditedDate { get; set; }

    public DateTime? DlbSignDate { get; set; }
}
