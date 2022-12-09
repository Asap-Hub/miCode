using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsCardType
{
    public int CdtIdpk { get; set; }

    public string? CdtName { get; set; }

    public string? CdtShtName { get; set; }

    public bool? CdtActive { get; set; }

    public string? CdtRmks { get; set; }

    public string? CdtCreatedBy { get; set; }

    public int? CdtEditedBy { get; set; }

    public DateTime? CdtCreationDate { get; set; }

    public DateTime? CdtEditedDate { get; set; }
}
