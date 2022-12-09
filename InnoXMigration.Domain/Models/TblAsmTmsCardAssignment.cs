using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsCardAssignment
{
    public int CasIdpk { get; set; }

    public int? CasVehicleDetailIdfk { get; set; }

    public int? CasCardDetailIdfk { get; set; }

    public DateTime? CasAssignDate { get; set; }

    public DateTime? CasEndDate { get; set; }

    public bool? CasActive { get; set; }

    public string? CasRmks { get; set; }

    public string? CasCreatedBy { get; set; }

    public int? CasEditedBy { get; set; }

    public DateTime? CasCreationDate { get; set; }

    public DateTime? CasEditedDate { get; set; }
}
