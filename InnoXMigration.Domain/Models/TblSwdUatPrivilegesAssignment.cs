using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdUatPrivilegesAssignment
{
    public int UpaIdpk { get; set; }

    public int? UpaEmpIdfk { get; set; }

    public int? UpaTestScenarioIdfk { get; set; }

    public bool? UpaAdmin { get; set; }

    public bool? UpaView { get; set; }

    public bool? UpaTester { get; set; }

    public bool? UpaResolver { get; set; }

    public bool? UpaSendAlerts { get; set; }

    public bool? UpaAlertFyi { get; set; }

    public bool? UpaProcessOwner { get; set; }

    public bool? UpaTeamLead { get; set; }

    public bool? UpaSupervisor { get; set; }

    public bool? UpaManager { get; set; }

    public bool? UpaDirector { get; set; }

    public bool? UpaActive { get; set; }

    public string? UpaRmks { get; set; }

    public int? UpaCreatedBy { get; set; }

    public int? UpaEditedBy { get; set; }

    public DateTime? UpaCreationDate { get; set; }

    public DateTime? UpaEditedDate { get; set; }
}
