using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHdsIssuesAttendantsAssignment
{
    public int IaaIdpk { get; set; }

    public int? IaaEmpIdfk { get; set; }

    public int? IaaIssueTypeIdfk { get; set; }

    public int? IaaIssueClassIdfk { get; set; }

    public int? IaaIssueSubClassIdfk { get; set; }

    public int? IaaIssueLocationIdfk { get; set; }

    public bool? IaaAssign { get; set; }

    public bool? IaaUpdate { get; set; }

    public bool? IaaRead { get; set; }

    public bool? IaaManager { get; set; }

    public bool? IaaDirector { get; set; }

    public bool? IaaActive { get; set; }

    public string? IaaRmks { get; set; }

    public int? IaaCreatedBy { get; set; }

    public int? IaaEditedBy { get; set; }

    public DateTime? IaaCreationDate { get; set; }

    public DateTime? IaaEditedDate { get; set; }
}
