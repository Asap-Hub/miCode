using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenAuditTrail
{
    public int AtrIdpk { get; set; }

    public string? AtrFormCode { get; set; }

    public string? AtrAction { get; set; }

    public string? AtrIp { get; set; }

    public int? AtrIdpkx { get; set; }

    public int? AtrCreatedBy { get; set; }

    public DateTime? AtrCreationDate { get; set; }
}
