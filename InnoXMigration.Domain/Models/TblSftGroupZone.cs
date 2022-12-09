using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftGroupZone
{
    public int GznIdpk { get; set; }

    public string? GznName { get; set; }

    public string? GznShtName { get; set; }

    public bool? GznActive { get; set; }

    public string? GznRmks { get; set; }

    public int? GznCreatedBy { get; set; }

    public int? GznEditedBy { get; set; }

    public DateTime? GznCreationDate { get; set; }

    public DateTime? GznEditedDate { get; set; }
}
