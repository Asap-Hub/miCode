using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAmgAttendanceCategory
{
    public int AtcIdpk { get; set; }

    public string? AtcName { get; set; }

    public string? AtcShtName { get; set; }

    public bool? AtcPresent { get; set; }

    public decimal? AtcOrder { get; set; }

    public decimal? AtcWeight { get; set; }

    public bool? AtcExempt { get; set; }

    public bool? AtcActive { get; set; }

    public string? AtcRmks { get; set; }

    public int? AtcCreatedBy { get; set; }

    public int? AtcEditedBy { get; set; }

    public DateTime? AtcCreationDate { get; set; }

    public DateTime? AtcEditedDate { get; set; }
}
