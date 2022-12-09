using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPrlPayrollDetail
{
    public int PdtIdpk { get; set; }

    public string? PdtName { get; set; }

    public string? PdtShtName { get; set; }

    public bool? PdtActive { get; set; }

    public string? PdtRmks { get; set; }

    public int? PdtCreatedBy { get; set; }

    public int? PdtEditedBy { get; set; }

    public DateTime? PdtCreationDate { get; set; }

    public DateTime? PdtEditedDate { get; set; }
}
