using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsPowerTrain
{
    public int PwtIdpk { get; set; }

    public string? PwtName { get; set; }

    public string? PwtShtName { get; set; }

    public bool? PwtActive { get; set; }

    public string? PwtRmks { get; set; }

    public string? PwtCreatedBy { get; set; }

    public int? PwtEditedBy { get; set; }

    public DateTime? PwtCreationDate { get; set; }

    public DateTime? PwtEditedDate { get; set; }
}
