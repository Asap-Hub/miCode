using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamConductorCodeName
{
    public int CcnIdpk { get; set; }

    public string? CcnName { get; set; }

    public string? CcnShtName { get; set; }

    public bool? CcnActive { get; set; }

    public string? CcnRmks { get; set; }

    public string? CcnCreatedBy { get; set; }

    public int? CcnEditedBy { get; set; }

    public DateTime? CcnCreationDate { get; set; }

    public DateTime? CcnEditedDate { get; set; }
}
