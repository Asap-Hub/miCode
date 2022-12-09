using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsInstantMessage
{
    public int ImsIdpk { get; set; }

    public int? ImsRecipientEmpIdfk { get; set; }

    public string? ImsMessage { get; set; }

    public string? ImsMessageType { get; set; }

    public string? ImsFormCode { get; set; }

    public int? ImsRecordIdfk { get; set; }

    public bool? ImsActive { get; set; }

    public int? ImsCreatedBy { get; set; }

    public int? ImsEditedBy { get; set; }

    public DateTime? ImsCreationDate { get; set; }

    public DateTime? ImsEditedDate { get; set; }
}
