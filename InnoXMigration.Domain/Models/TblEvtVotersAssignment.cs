using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblEvtVotersAssignment
{
    public int VasIdpk { get; set; }

    public int? VasElectionDetailIdfk { get; set; }

    public int? VasVoterEmpIdfk { get; set; }

    public bool? VasActive { get; set; }

    public string? VasRmks { get; set; }

    public string? VasCreatedBy { get; set; }

    public int? VasEditedBy { get; set; }

    public DateTime? VasCreationDate { get; set; }

    public DateTime? VasEditedDate { get; set; }
}
