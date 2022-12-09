using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleMake
{
    public int VmkIdpk { get; set; }

    public string? VmkName { get; set; }

    public string? VmkShtName { get; set; }

    public int? VmkVehicleClassIdfk { get; set; }

    public bool? VmkActive { get; set; }

    public string? VmkRmks { get; set; }

    public string? VmkCreatedBy { get; set; }

    public int? VmkEditedBy { get; set; }

    public DateTime? VmkCreationDate { get; set; }

    public DateTime? VmkEditedDate { get; set; }
}
