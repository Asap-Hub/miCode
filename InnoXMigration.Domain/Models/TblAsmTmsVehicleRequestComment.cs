using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleRequestComment
{
    public int VrcIdpk { get; set; }

    public int? VrcVehicleRequestIdfk { get; set; }

    public int? VrcEmpIdfk { get; set; }

    public string? VrcComment { get; set; }

    public bool? VrcActive { get; set; }

    public int? VrcCreatedBy { get; set; }

    public int? VrcEditedBy { get; set; }

    public DateTime? VrcCreationDate { get; set; }

    public DateTime? VrcEditedDate { get; set; }
}
