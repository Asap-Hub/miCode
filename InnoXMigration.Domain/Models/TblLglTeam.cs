using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblLglTeam
{
    public int LtmIdpk { get; set; }

    public string? LtmName { get; set; }

    public string? LtmShtName { get; set; }

    public bool? LtmActive { get; set; }

    public string? LtmRmks { get; set; }

    public int? LtmCreatedBy { get; set; }

    public int? LtmEditedBy { get; set; }

    public DateTime? LtmCreationDate { get; set; }

    public DateTime? LtmEditedDate { get; set; }
}
