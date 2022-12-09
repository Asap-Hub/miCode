using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleClass
{
    public int VhcIdpk { get; set; }

    public string? VhcName { get; set; }

    public string? VhcShtName { get; set; }

    public bool? VhcActive { get; set; }

    public string? VhcRmks { get; set; }

    public string? VhcCreatedBy { get; set; }

    public int? VhcEditedBy { get; set; }

    public DateTime? VhcCreationDate { get; set; }

    public DateTime? VhcEditedDate { get; set; }
}
