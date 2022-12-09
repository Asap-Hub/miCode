using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleGroup
{
    public int VgpIdpk { get; set; }

    public string? VgpName { get; set; }

    public string? VgpShtName { get; set; }

    public bool? VgpCorporate { get; set; }

    public bool? VgpPersonnal { get; set; }

    public bool? VgpActive { get; set; }

    public string? VgpRmks { get; set; }

    public string? VgpCreatedBy { get; set; }

    public int? VgpEditedBy { get; set; }

    public DateTime? VgpCreationDate { get; set; }

    public DateTime? VgpEditedDate { get; set; }
}
