using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmsSeverity
{
    public int PsvIdpk { get; set; }

    public string? PsvName { get; set; }

    public string? PsvShtName { get; set; }

    public byte? PsvOrder { get; set; }

    public bool? PsvActive { get; set; }

    public string? PsvRmks { get; set; }

    public int? PsvCreatedBy { get; set; }

    public int? PsvEditedBy { get; set; }

    public DateTime? PsvCreationDate { get; set; }

    public DateTime? PsvEditedDate { get; set; }
}
