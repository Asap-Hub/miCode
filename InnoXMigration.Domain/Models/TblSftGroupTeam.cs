using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftGroupTeam
{
    public int GtmIdpk { get; set; }

    public string? GtmName { get; set; }

    public string? GtmShtName { get; set; }

    public bool? GtmActive { get; set; }

    public string? GtmRmks { get; set; }

    public int? GtmCreatedBy { get; set; }

    public int? GtmEditedBy { get; set; }

    public DateTime? GtmCreationDate { get; set; }

    public DateTime? GtmEditedDate { get; set; }
}
