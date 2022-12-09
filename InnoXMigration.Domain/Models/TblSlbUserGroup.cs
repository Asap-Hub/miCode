using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbUserGroup
{
    public int UgpIdpk { get; set; }

    public string? UgpName { get; set; }

    public string? UgpShtName { get; set; }

    public decimal? UgpOrder { get; set; }

    public bool? UgpActive { get; set; }

    public string? UgpRmks { get; set; }

    public int? UgpCreatedBy { get; set; }

    public int? UgpEditedBy { get; set; }

    public DateTime? UgpCreationDate { get; set; }

    public DateTime? UgpEditedDate { get; set; }
}
