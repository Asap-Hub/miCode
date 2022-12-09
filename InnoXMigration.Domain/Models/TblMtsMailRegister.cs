using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsMailRegister
{
    public int MrgIdpk { get; set; }

    public int? MrgEmpIdfk { get; set; }

    public string? MrgRecipient { get; set; }

    public DateTime? MrgDocDate { get; set; }

    public DateTime? MrgRecDate { get; set; }

    public DateTime? MrgOutDate { get; set; }

    public string? MrgFileNo { get; set; }

    public string? MrgSubject { get; set; }

    public string? MrgIncomingNotes { get; set; }

    public string? MrgOutgoingMinutes { get; set; }

    public string? MrgShareWith { get; set; }

    public int? MrgAssignmentUnitIdfk { get; set; }

    public int? MrgDocSrcIdfk { get; set; }

    public int? MrgFwdFromIdfk { get; set; }

    public int? MrgSignedByIdfk { get; set; }

    public int? MrgSignedForIdfk { get; set; }

    public int? MrgDocTypeIdfk { get; set; }

    public int? MrgDocClassIdfk { get; set; }

    public int? MrgDocSubClassIdfk { get; set; }

    public int? MrgNum { get; set; }

    public string? MrgType { get; set; }

    public string? MrgRmks { get; set; }

    public bool? MrgIsStaff { get; set; }

    public bool? MrgDispatched { get; set; }

    public bool? MrgHasAttachment { get; set; }

    public int? MrgCreatedBy { get; set; }

    public int? MrgEditedBy { get; set; }

    public DateTime? MrgCreationDate { get; set; }

    public DateTime? MrgEditedDate { get; set; }

    public DateTime? MrgSignDate { get; set; }
}
