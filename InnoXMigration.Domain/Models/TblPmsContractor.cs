using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmsContractor
{
    public int CntIdpk { get; set; }

    public string? CntName { get; set; }

    public string? CntShtName { get; set; }

    public bool? CntActive { get; set; }

    public string? CntRmks { get; set; }

    public int? CntCreatedBy { get; set; }

    public int? CntEditedBy { get; set; }

    public DateTime? CntCreationDate { get; set; }

    public DateTime? CntEditedDate { get; set; }
}
