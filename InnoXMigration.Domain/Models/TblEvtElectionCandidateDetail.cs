using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblEvtElectionCandidateDetail
{
    public int EcdIdpk { get; set; }

    public int? EcdElectionDetailIdfk { get; set; }

    public int? EcdPositionIdfk { get; set; }

    public int? EcdEmpIdfk { get; set; }

    public bool? EcdCandidate { get; set; }

    public bool? EcdAdministrator { get; set; }

    public bool? EcdActive { get; set; }

    public string? EcdRmks { get; set; }

    public string? EcdCreatedBy { get; set; }

    public int? EcdEditedBy { get; set; }

    public DateTime? EcdCreationDate { get; set; }

    public DateTime? EcdEditedDate { get; set; }
}
