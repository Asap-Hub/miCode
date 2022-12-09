using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgBusinessSector
{
    public int FbstIdpk { get; set; }

    public string? FbstName { get; set; }

    public string? FbstShtName { get; set; }

    public bool? FbstActive { get; set; }

    public string? FbstRmks { get; set; }

    public int? FbstCreatedBy { get; set; }

    public int? FbstEditedBy { get; set; }

    public DateTime? FbstCreationDate { get; set; }

    public DateTime? FbstEditedDate { get; set; }
}
