using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftSafetyPrivilegesAssignment
{
    public int SpaIdpk { get; set; }

    public int? SpaEmpIdfk { get; set; }

    public int? SpaSafetyGroupIdfk { get; set; }

    public bool? SpaCoordinator { get; set; }

    public bool? SpaAssistantCoordinator { get; set; }

    public bool? SpaAdmin { get; set; }

    public bool? SpaDeptAdmin { get; set; }

    public bool? SpaSectionAdmin { get; set; }

    public bool? SpaView { get; set; }

    public bool? SpaSubmitAttendance { get; set; }

    public bool? SpaSubmitSchedules { get; set; }

    public bool? SpaAcknowledge { get; set; }

    public bool? SpaRecommendTopics { get; set; }

    public bool? SpaApproveTopics { get; set; }

    public bool? SpaIssuePpeToGroups { get; set; }

    public bool? SpaAcknowledgePpeRequests { get; set; }

    public bool? SpaRecommendPpeRequests { get; set; }

    public bool? SpaApprovePpeRequests { get; set; }

    public bool? SpaDistributePpe { get; set; }

    public bool? SpaInspector { get; set; }

    public bool? SpaSubmitWasacoReturns { get; set; }

    public bool? SpaSendAlerts { get; set; }

    public bool? SpaAlertFyi { get; set; }

    public bool? SpaChairman { get; set; }

    public bool? SpaManager { get; set; }

    public bool? SpaDirector { get; set; }

    public bool? SpaActive { get; set; }

    public string? SpaRmks { get; set; }

    public int? SpaCreatedBy { get; set; }

    public int? SpaEditedBy { get; set; }

    public DateTime? SpaCreationDate { get; set; }

    public DateTime? SpaEditedDate { get; set; }
}
