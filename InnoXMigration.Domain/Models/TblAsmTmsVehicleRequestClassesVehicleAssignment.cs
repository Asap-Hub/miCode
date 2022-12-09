using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleRequestClassesVehicleAssignment
{
    public int VcaIdpk { get; set; }

    public int? VcaRequestClassIdfk { get; set; }

    public int? VcaRequestAreaIdfk { get; set; }

    public int? VcaVehicleDetailIdfk { get; set; }

    public bool? VcaActive { get; set; }

    public string? VcaRmks { get; set; }

    public int? VcaCreatedBy { get; set; }

    public int? VcaEditedBy { get; set; }

    public DateTime? VcaCreationDate { get; set; }

    public DateTime? VcaEditedDate { get; set; }
}
