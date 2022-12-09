using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TtblGenPrivilegesComputingAsset
{
    public int AcaIdpk { get; set; }

    public int? AcaEmpIdfk { get; set; }

    public bool? AcaSupervisor { get; set; }

    public bool? AcaManager { get; set; }

    public bool? AcaDirector { get; set; }

    public bool? AcaClassifyIssues { get; set; }

    public bool? AcaAssignRequests { get; set; }

    public bool? AcaTechnician { get; set; }

    public bool? AcaSysAdmin { get; set; }

    public bool? AcaSendAlertsToGroupMembers { get; set; }

    public bool? AcaClassifyIssuesReported { get; set; }

    public bool? AcaActive { get; set; }

    public string? AcaRmks { get; set; }

    public int? AcaCreatedBy { get; set; }

    public int? AcaEditedBy { get; set; }

    public DateTime? AcaCreationDate { get; set; }

    public DateTime? AcaEditedDate { get; set; }
}
