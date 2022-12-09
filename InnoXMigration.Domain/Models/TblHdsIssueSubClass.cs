using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHdsIssueSubClass
{
    public int IscIdpk { get; set; }

    public string? IscName { get; set; }

    public string? IscShtName { get; set; }

    public int? IscClassIdfk { get; set; }

    public decimal? IscOrder { get; set; }

    public bool? IscActive { get; set; }

    public string? IscRmks { get; set; }

    public int? IscCreatedBy { get; set; }

    public int? IscEditedBy { get; set; }

    public DateTime? IscCreationDate { get; set; }

    public DateTime? IscEditedDate { get; set; }
}
