using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleImage
{
    public int VimIdpk { get; set; }

    public int? VimVehicleDetailIdfk { get; set; }

    public byte[]? VimImage { get; set; }

    public byte? VimIndex { get; set; }

    public bool? VimActive { get; set; }

    public int? VimCreatedBy { get; set; }

    public int? VimEditedBy { get; set; }

    public DateTime? VimCreationDate { get; set; }

    public DateTime? VimEditedDate { get; set; }
}
