using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdStreamPrivilegesAssignment
{
    public int SpaIdpk { get; set; }

    public int? SpaEmpIdfk { get; set; }

    public int? SpaStreamIdfk { get; set; }

    public bool? SpaView { get; set; }

    public bool? SpaMember { get; set; }

    public bool? SpaProjectManager { get; set; }

    public bool? SpaSecretary { get; set; }

    public bool? SpaTeamLead { get; set; }

    public bool? SpaDirector { get; set; }

    public bool? SpaSponsor { get; set; }

    public bool? SpaSendAlerts { get; set; }

    public bool? SpaAlertFyi { get; set; }

    public bool? SpaActive { get; set; }

    public string? SpaRmks { get; set; }

    public int? SpaCreatedBy { get; set; }

    public int? SpaEditedBy { get; set; }

    public DateTime? SpaCreationDate { get; set; }

    public DateTime? SpaEditedDate { get; set; }
}
