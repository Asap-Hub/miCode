using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsVehicleMake
{
    public int VmkIdpk { get; set; }

    public string? VmkName { get; set; }

    public string? VmkShtName { get; set; }

    public bool? VmkActive { get; set; }

    public string? VmkRmks { get; set; }

    public string? VmkCreatedBy { get; set; }

    public int? VmkEditedBy { get; set; }

    public DateTime? VmkCreationDate { get; set; }

    public DateTime? VmkEditedDate { get; set; }

    public int? VmkVehicleClassIdfk { get; set; }

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
