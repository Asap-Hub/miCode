using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenSmsGroup
{
    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public string? SgpCode { get; set; }

    public bool? SgpActive { get; set; }

    public string? SgpRmks { get; set; }

    public int? SgpCreatedBy { get; set; }

    public int? SgpEditedBy { get; set; }

    public DateTime? SgpCreationDate { get; set; }

    public DateTime? SgpEditedDate { get; set; }
}
