using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrGender
{
    public short GndIdpk { get; set; }

    public string GndName { get; set; } = null!;

    public string GndshtName { get; set; } = null!;

    public bool? GndActive { get; set; }

    public int? GndCreatedBy { get; set; }

    public int? GndLastEditedBy { get; set; }

    public DateTime? GndCreationDate { get; set; }

    public DateTime? GndLastEditedDate { get; set; }
}
