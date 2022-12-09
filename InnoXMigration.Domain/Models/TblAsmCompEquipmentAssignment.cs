using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmCompEquipmentAssignment
{
    public int EasIdpk { get; set; }

    public int? EasEquipDetailIdfk { get; set; }

    public int? EasEmpIdfk { get; set; }

    public DateTime? EasStartDate { get; set; }

    public DateTime? EasEndDate { get; set; }

    public int? EasDeptIdfk { get; set; }

    public int? EasSectionIdfk { get; set; }

    public int? EasUnitIdfk { get; set; }

    public int? EasLocIdfk { get; set; }

    public string? EasRmks { get; set; }

    public bool? EasAssigned { get; set; }

    public int? EasCreatedBy { get; set; }

    public int? EasEditedBy { get; set; }

    public DateTime? EasCreationDate { get; set; }

    public DateTime? EasEditedDate { get; set; }

    public bool? EasActive { get; set; }
}
