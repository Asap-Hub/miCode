using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblFinAccountType
{
    public int AtpIdpk { get; set; }

    public string? AtpName { get; set; }

    public string? AtpShtName { get; set; }

    public string? AtpCode { get; set; }

    public string? AtpDescription { get; set; }

    public bool? AtpActive { get; set; }

    public string? AtpRmks { get; set; }

    public string? AtpCreatedBy { get; set; }

    public int? AtpEditedBy { get; set; }

    public DateTime? AtpCreationDate { get; set; }

    public DateTime? AtpEditedDate { get; set; }
}
