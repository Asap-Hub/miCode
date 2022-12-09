using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleImageDetail
{
    public int VidIdpk { get; set; }

    public int? VidVehicleDetailIdfk { get; set; }

    public string? VidName { get; set; }

    public string? VidDescription { get; set; }

    public byte? VidIndex { get; set; }

    public string? VidRmks { get; set; }

    public int? VidCreatedBy { get; set; }

    public int? VidEditedBy { get; set; }

    public DateTime? VidCreationDate { get; set; }

    public DateTime? VidEditedDate { get; set; }
}
