using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPrlPayItemGroup
{
    public int PigIdpk { get; set; }

    public string? PigName { get; set; }

    public string? PigShtName { get; set; }

    public bool? PigActive { get; set; }

    public string? PigRmks { get; set; }

    public int? PigCreatedBy { get; set; }

    public int? PigEditedBy { get; set; }

    public DateTime? PigCreationDate { get; set; }

    public DateTime? PigEditedDate { get; set; }
}
