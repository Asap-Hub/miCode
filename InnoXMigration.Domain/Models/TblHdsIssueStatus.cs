using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHdsIssueStatus
{
    public int IstIdpk { get; set; }

    public string? IstName { get; set; }

    public string? IstShtName { get; set; }

    public decimal? IstOrder { get; set; }

    public bool? IstSubmitted { get; set; }

    public bool? IstCompleted { get; set; }

    public bool? IstActive { get; set; }

    public string? IstRmks { get; set; }

    public int? IstCreatedBy { get; set; }

    public int? IstEditedBy { get; set; }

    public DateTime? IstCreationDate { get; set; }

    public DateTime? IstEditedDate { get; set; }
}
