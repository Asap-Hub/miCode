using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmgUnitInitiative
{
    public int UinIdpk { get; set; }

    public string? UinName { get; set; }

    public string? UinShtName { get; set; }

    public bool? UinActive { get; set; }

    public string? UinRmks { get; set; }

    public string? UinCreatedBy { get; set; }

    public int? UinEditedBy { get; set; }

    public DateTime? UinCreationDate { get; set; }

    public DateTime? UinEditedDate { get; set; }
}
