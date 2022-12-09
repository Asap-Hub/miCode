using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHdsIssueType
{
    public int ItpIdpk { get; set; }

    public string? ItpName { get; set; }

    public string? ItpShtName { get; set; }

    public decimal? ItpOrder { get; set; }

    public bool? ItpActive { get; set; }

    public string? ItpRmks { get; set; }

    public int? ItpCreatedBy { get; set; }

    public int? ItpEditedBy { get; set; }

    public DateTime? ItpCreationDate { get; set; }

    public DateTime? ItpEditedDate { get; set; }
}
