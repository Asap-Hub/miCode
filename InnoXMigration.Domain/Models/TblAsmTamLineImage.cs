using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamLineImage
{
    public int LimIdpk { get; set; }

    public int? LimLineDetailIdfk { get; set; }

    public byte[]? LimImage { get; set; }

    public byte? LimIndex { get; set; }

    public int? LimCreatedBy { get; set; }

    public int? LimEditedBy { get; set; }

    public DateTime? LimCreationDate { get; set; }

    public DateTime? LimEditedDate { get; set; }
}
