using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsDocSubClass
{
    public int DscIdpk { get; set; }

    public string? DscName { get; set; }

    public string? DscShtName { get; set; }

    public bool? DscActive { get; set; }

    public string? DscRmks { get; set; }

    public int? DscCreatedBy { get; set; }

    public int? DscEditedBy { get; set; }

    public DateTime? DscCreationDate { get; set; }

    public DateTime? DscEditedDate { get; set; }
}
