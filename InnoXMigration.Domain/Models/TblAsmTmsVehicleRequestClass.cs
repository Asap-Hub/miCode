using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleRequestClass
{
    public int VrcIdpk { get; set; }

    public string? VrcName { get; set; }

    public string? VrcShtName { get; set; }

    public bool? VrcActive { get; set; }

    public string? VrcRmks { get; set; }

    public string? VrcCreatedBy { get; set; }

    public int? VrcEditedBy { get; set; }

    public DateTime? VrcCreationDate { get; set; }

    public DateTime? VrcEditedDate { get; set; }
}
