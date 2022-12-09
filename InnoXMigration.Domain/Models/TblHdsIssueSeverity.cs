using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHdsIssueSeverity
{
    public int IsvIdpk { get; set; }

    public string? IsvName { get; set; }

    public string? IsvShtName { get; set; }

    public decimal? IsvOrder { get; set; }

    public bool? IsvActive { get; set; }

    public string? IsvRmks { get; set; }

    public int? IsvCreatedBy { get; set; }

    public int? IsvEditedBy { get; set; }

    public DateTime? IsvCreationDate { get; set; }

    public DateTime? IsvEditedDate { get; set; }
}
