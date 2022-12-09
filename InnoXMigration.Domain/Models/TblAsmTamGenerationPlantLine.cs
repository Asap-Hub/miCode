using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamGenerationPlantLine
{
    public int GpnIdpk { get; set; }

    public string? GpnName { get; set; }

    public int? GpnGenerationPlantIdfk { get; set; }

    public bool? GpnActive { get; set; }

    public string? GpnRmks { get; set; }

    public int? GpnCreatedBy { get; set; }

    public int? GpnEditedBy { get; set; }

    public DateTime? GpnCreationDate { get; set; }

    public DateTime? GpnEditedDate { get; set; }
}
