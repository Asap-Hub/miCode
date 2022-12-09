using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblFinAccountGroup
{
    public int AgpIdpk { get; set; }

    public string? AgpName { get; set; }

    public string? AgpShtName { get; set; }

    public string? AgpCode { get; set; }

    public string? AgpDescription { get; set; }

    public bool? AgpActive { get; set; }

    public string? AgpRmks { get; set; }

    public string? AgpCreatedBy { get; set; }

    public int? AgpEditedBy { get; set; }

    public DateTime? AgpCreationDate { get; set; }

    public DateTime? AgpEditedDate { get; set; }
}
