using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblOraAllPaymentsVertical
{
    public DateTime? EffectiveDate { get; set; }

    public string? StaffNo { get; set; }

    public string? ReportName { get; set; }

    public string? ElementName { get; set; }

    public string? Classification { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? CreationDate { get; set; }
}
