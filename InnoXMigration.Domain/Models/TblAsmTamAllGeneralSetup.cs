using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamAllGeneralSetup
{
    public int AgsIdpk { get; set; }

    public string? AgsName { get; set; }

    public string? AgsShtName { get; set; }

    public string? AgsType { get; set; }

    public string? AgsSource { get; set; }

    public byte? AgsOrder { get; set; }

    public bool? AgsActive { get; set; }

    public string? AgsRmks { get; set; }

    public int? AgsCreatedBy { get; set; }

    public int? AgsEditedBy { get; set; }

    public DateTime? AgsCreationDate { get; set; }

    public DateTime? AgsEditedDate { get; set; }
}
