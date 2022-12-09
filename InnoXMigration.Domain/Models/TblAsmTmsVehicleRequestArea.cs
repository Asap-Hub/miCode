using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleRequestArea
{
    public int VraIdpk { get; set; }

    public string? VraName { get; set; }

    public string? VraShtName { get; set; }

    public bool? VraActive { get; set; }

    public string? VraRmks { get; set; }

    public string? VraCreatedBy { get; set; }

    public int? VraEditedBy { get; set; }

    public DateTime? VraCreationDate { get; set; }

    public DateTime? VraEditedDate { get; set; }
}
