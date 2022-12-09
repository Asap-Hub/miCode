using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftGroupMemberDeletionReason
{
    public int GdrIdpk { get; set; }

    public int? GdrEmpIdfk { get; set; }

    public int? GdrGroupIdfk { get; set; }

    public DateTime? GdrDate { get; set; }

    public string? GdrReason { get; set; }

    public int? GdrReasonIdfk { get; set; }

    public string? GdrRmks { get; set; }

    public bool? GdrActive { get; set; }

    public int? GdrCreatedBy { get; set; }

    public int? GdrEditedBy { get; set; }

    public DateTime? GdrCreationDate { get; set; }

    public DateTime? GdrEditedDate { get; set; }
}
