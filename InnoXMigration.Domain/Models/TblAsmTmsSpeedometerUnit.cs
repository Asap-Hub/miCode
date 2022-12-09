using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsSpeedometerUnit
{
    public int SpuIdpk { get; set; }

    public string? SpuName { get; set; }

    public string? SpuShtName { get; set; }

    public bool? SpuActive { get; set; }

    public string? SpuRmks { get; set; }

    public string? SpuCreatedBy { get; set; }

    public int? SpuEditedBy { get; set; }

    public DateTime? SpuCreationDate { get; set; }

    public DateTime? SpuEditedDate { get; set; }
}
