using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblFinPrlBulkPayslip
{
    public int BpdIdpk { get; set; }

    public byte[]? BpdDoc { get; set; }

    public DateTime? BpdDate { get; set; }

    public string? BpdPayrollType { get; set; }

    public string? BpdFileName { get; set; }

    public string? BpdType { get; set; }

    public string? BpdAttachedFrom { get; set; }

    public bool? BpdProcessed { get; set; }

    public bool? BpdProcess { get; set; }

    public bool? BpdActive { get; set; }

    public int? BpdCreatedBy { get; set; }

    public int? BpdEditedBy { get; set; }

    public DateTime? BpdCreationDate { get; set; }

    public DateTime? BpdEditedDate { get; set; }
}
