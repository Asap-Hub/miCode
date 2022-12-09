using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsCubicCapacity
{
    public int CbcIdpk { get; set; }

    public string? CbcName { get; set; }

    public string? CbcShtName { get; set; }

    public bool? CbcActive { get; set; }

    public string? CbcRmks { get; set; }

    public string? CbcCreatedBy { get; set; }

    public int? CbcEditedBy { get; set; }

    public DateTime? CbcCreationDate { get; set; }

    public DateTime? CbcEditedDate { get; set; }
}
