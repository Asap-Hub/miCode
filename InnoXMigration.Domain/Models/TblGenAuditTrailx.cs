using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenAuditTrailx
{
    public int AdtIdpk { get; set; }

    public string? AdtFormCode { get; set; }

    public string? AdtAction { get; set; }

    public string? AdtIp { get; set; }

    public int? AdtIdpkx { get; set; }

    public int? AdtCreatedBy { get; set; }

    public DateTime? AdtCreationDate { get; set; }
}
