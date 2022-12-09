using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPrlPayItemSubclass
{
    public int PisIdpk { get; set; }

    public string? PisName { get; set; }

    public string? PisShtName { get; set; }

    public bool? PisActive { get; set; }

    public string? PisRmks { get; set; }

    public int? PisCreatedBy { get; set; }

    public int? PisEditedBy { get; set; }

    public DateTime? PisCreationDate { get; set; }

    public DateTime? PisEditedDate { get; set; }
}
