using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsPicture
{
    public int VimIdpk { get; set; }

    public int? VimVehicleIdfk { get; set; }

    public byte[]? VimPicture { get; set; }

    public byte? VimIndex { get; set; }

    public int? VimCreatedBy { get; set; }

    public int? VimEditedBy { get; set; }

    public DateTime? VimCreationDate { get; set; }

    public DateTime? VimEditedDate { get; set; }
}
