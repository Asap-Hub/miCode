using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHdsIssueClass
{
    public int IclIdpk { get; set; }

    public string? IclName { get; set; }

    public string? IclShtName { get; set; }

    public int? IclIssueTypeIdfk { get; set; }

    public decimal? IclOrder { get; set; }

    public bool? IclActive { get; set; }

    public string? IclRmks { get; set; }

    public int? IclCreatedBy { get; set; }

    public int? IclEditedBy { get; set; }

    public DateTime? IclCreationDate { get; set; }

    public DateTime? IclEditedDate { get; set; }
}
