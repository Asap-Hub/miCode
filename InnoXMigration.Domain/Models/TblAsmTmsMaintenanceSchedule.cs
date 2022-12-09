using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsMaintenanceSchedule
{
    public int MtsIdpk { get; set; }

    public DateTime? MtsDate { get; set; }

    public int? MtsVehicleDetailIdfk { get; set; }

    public int? MtsMaintenanceTypeIdfk { get; set; }

    public int? MtsMaintenanceLocIdfk { get; set; }

    public int? MtsDeptIdfk { get; set; }

    public int? MtsSectionIdfk { get; set; }

    public int? MtsUnitIdfk { get; set; }

    public int? MtsOwnerEmpIdfk { get; set; }

    public int? MtsDriverEmpIdfk { get; set; }

    public bool? MtsPromptDriver { get; set; }

    public bool? MtsPromptOwner { get; set; }

    public DateTime? MtsSmsDate { get; set; }

    public byte? MtsSmsCount { get; set; }

    public bool? MtsSmsSent { get; set; }

    public bool? MtsSend { get; set; }

    public bool? MtsActive { get; set; }

    public string? MtsRmks { get; set; }

    public int? MtsCreatedBy { get; set; }

    public int? MtsEditedBy { get; set; }

    public DateTime? MtsCreationDate { get; set; }

    public DateTime? MtsEditedDate { get; set; }
}
