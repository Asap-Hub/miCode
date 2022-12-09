using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSvlAccountName
{
    public int AcnIdpk { get; set; }

    public string? AcnName { get; set; }

    public string? AcnShtName { get; set; }

    public bool? AcnActive { get; set; }

    public string? AcnRmks { get; set; }

    public int? AcnCreatedBy { get; set; }

    public int? AcnEditedBy { get; set; }

    public DateTime? AcnCreationDate { get; set; }

    public DateTime? AcnEditedDate { get; set; }
}
