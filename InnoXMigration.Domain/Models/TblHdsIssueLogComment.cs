using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHdsIssueLogComment
{
    public int IcmIdpk { get; set; }

    public int? IcmIssueLogIdfk { get; set; }

    public int? IcmEmpIdfk { get; set; }

    public string? IcmComment { get; set; }

    public bool? IcmActive { get; set; }

    public int? IcmCreatedBy { get; set; }

    public int? IcmEditedBy { get; set; }

    public DateTime? IcmCreationDate { get; set; }

    public DateTime? IcmEditedDate { get; set; }
}
