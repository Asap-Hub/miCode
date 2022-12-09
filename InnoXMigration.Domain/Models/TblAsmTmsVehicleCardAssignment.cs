using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleCardAssignment
{
    public int VcaIdpk { get; set; }

    public int? VcaVehicleDetailIdfk { get; set; }

    public int? VcaCardDetailIdfk { get; set; }

    public int? VcaServiceProviderIdfk { get; set; }

    public DateTime? VcaAssignDate { get; set; }

    public DateTime? VcaEndDate { get; set; }

    public bool? VcaActive { get; set; }

    public string? VcaRmks { get; set; }

    public string? VcaCreatedBy { get; set; }

    public int? VcaEditedBy { get; set; }

    public DateTime? VcaCreationDate { get; set; }

    public DateTime? VcaEditedDate { get; set; }
}
