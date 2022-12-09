using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenAuditLog
{
    public int AlgIdpk { get; set; }

    public string? AlgFormCode { get; set; }

    public string? AlgAction { get; set; }

    public string? AlgIp { get; set; }

    public int? AlgIdpkx { get; set; }

    public int? AlgCreatedBy { get; set; }

    public DateTime? AlgCreationDate { get; set; }
}
