using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmRstMaterial
{
    public int MtrIdpk { get; set; }

    public string? MtrName { get; set; }

    public string? MtrShtName { get; set; }

    public string? MtrCode { get; set; }

    public string? MtrStoreNo { get; set; }

    public bool? MtrActive { get; set; }

    public string? MtrRmks { get; set; }

    public int? MtrCreatedBy { get; set; }

    public int? MtrEditedBy { get; set; }

    public DateTime? MtrCreationDate { get; set; }

    public DateTime? MtrEditedDate { get; set; }
}
