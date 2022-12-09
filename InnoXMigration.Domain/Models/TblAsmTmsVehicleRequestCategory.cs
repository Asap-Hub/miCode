using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleRequestCategory
{
    public int VctIdpk { get; set; }

    public string? VctName { get; set; }

    public string? VctShtName { get; set; }

    public bool? VctPersonal { get; set; }

    public bool? VctActive { get; set; }

    public string? VctRmks { get; set; }

    public string? VctCreatedBy { get; set; }

    public int? VctEditedBy { get; set; }

    public DateTime? VctCreationDate { get; set; }

    public DateTime? VctEditedDate { get; set; }
}
