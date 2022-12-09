using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenIssueSubClass
{
    public int IscIdpk { get; set; }

    public string? IscName { get; set; }

    public string? IscShtName { get; set; }

    public int? IscClassIdfk { get; set; }

    public bool? IscActive { get; set; }

    public string? IscRmks { get; set; }

    public int? IscCreatedBy { get; set; }

    public int? IscEditedBy { get; set; }

    public DateTime? IscEditedDate { get; set; }

    public DateTime? IscCreationDate { get; set; }

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
