using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblEvtElectionPosition
{
    public int EpsIdpk { get; set; }

    public string? EpsName { get; set; }

    public string? EpsShtName { get; set; }

    public int? EpsElectionDetailIdfk { get; set; }

    public string? EpsCandidates { get; set; }

    public string? EpsAdministrators { get; set; }

    public bool? EpsActive { get; set; }

    public string? EpsRmks { get; set; }

    public string? EpsCreatedBy { get; set; }

    public int? EpsEditedBy { get; set; }

    public DateTime? EpsCreationDate { get; set; }

    public DateTime? EpsEditedDate { get; set; }
}
