using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleStatus
{
    public int VstIdpk { get; set; }

    public string? VstName { get; set; }

    public string? VstShtName { get; set; }

    public bool? VstFitStatus { get; set; }

    public bool? VstActive { get; set; }

    public string? VstRmks { get; set; }

    public string? VstCreatedBy { get; set; }

    public int? VstEditedBy { get; set; }

    public DateTime? VstCreationDate { get; set; }

    public DateTime? VstEditedDate { get; set; }
}
