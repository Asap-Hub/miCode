using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSsvPrivilegesAssignment
{
    public int SpaIdpk { get; set; }

    public int? SpaEmpIdfk { get; set; }

    public int? SpaDeptIdfk { get; set; }

    public int? SpaSectionIdfk { get; set; }

    public bool? SpaSupervisor { get; set; }

    public bool? SpaManager { get; set; }

    public bool? SpaHod { get; set; }

    public bool? SpaExecutiveApprover { get; set; }

    public bool? SpaFinanceApprover { get; set; }

    public bool? SpaBudgetApprover { get; set; }

    public bool? SpaHodHr { get; set; }

    public bool? SpaHodAudit { get; set; }

    public bool? SpaHodLegal { get; set; }

    public bool? SpaDependantsApprover { get; set; }

    public bool? SpaActive { get; set; }

    public string? SpaRmks { get; set; }

    public int? SpaCreatedBy { get; set; }

    public int? SpaEditedBy { get; set; }

    public DateTime? SpaCreationDate { get; set; }

    public DateTime? SpaEditedDate { get; set; }
}
