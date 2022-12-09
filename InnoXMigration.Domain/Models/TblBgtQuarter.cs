using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtQuarter
{
    public int QtrIdpk { get; set; }

    public string? QtrName { get; set; }

    public string? QtrShtName { get; set; }

    public bool? QtrActive { get; set; }

    public string? QtrRmks { get; set; }

    public int? QtrCreatedBy { get; set; }

    public int? QtrEditedBy { get; set; }

    public DateTime? QtrCreationDate { get; set; }

    public DateTime? QtrEditedDate { get; set; }
}
