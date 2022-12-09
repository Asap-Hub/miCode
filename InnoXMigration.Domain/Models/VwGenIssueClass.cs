using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenIssueClass
{
    public int IclIdpk { get; set; }

    public string? IclName { get; set; }

    public string? IclShtName { get; set; }

    public int? IclIssueTypeIdfk { get; set; }

    public bool? IclActive { get; set; }

    public string? IclRmks { get; set; }

    public int ItpIdpk { get; set; }

    public string? ItpName { get; set; }

    public string? ItpShtName { get; set; }

    public bool? ItpActive { get; set; }

    public string? ItpRmks { get; set; }

    public int? IclCreatedBy { get; set; }

    public int? IclEditedBy { get; set; }

    public DateTime? IclCreationDate { get; set; }

    public DateTime? IclEditedDate { get; set; }

    public int? ItpCreatedBy { get; set; }

    public int? ItpEditedBy { get; set; }

    public DateTime? ItpCreationDate { get; set; }

    public DateTime? ItpEditedDate { get; set; }
}
