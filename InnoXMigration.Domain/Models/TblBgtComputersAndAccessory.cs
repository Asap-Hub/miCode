using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtComputersAndAccessory
{
    public int CacIdpk { get; set; }

    public string? CacName { get; set; }

    public string? CacShtName { get; set; }

    public bool? CacActive { get; set; }

    public string? CacRmks { get; set; }

    public int? CacCreatedBy { get; set; }

    public int? CacEditedBy { get; set; }

    public DateTime? CacCreationDate { get; set; }

    public DateTime? CacEditedDate { get; set; }
}
