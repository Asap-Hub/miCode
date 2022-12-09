using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsFuelLevel
{
    public int FlvIdpk { get; set; }

    public string? FlvName { get; set; }

    public string? FlvShtName { get; set; }

    public decimal? FlvOrder { get; set; }

    public bool? FlvActive { get; set; }

    public string? FlvRmks { get; set; }

    public int? FlvCreatedBy { get; set; }

    public int? FlvEditedBy { get; set; }

    public DateTime? FlvCreationDate { get; set; }

    public DateTime? FlvEditedDate { get; set; }
}
