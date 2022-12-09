using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftSafetyPrivilegesAssignment
{
    public int SpaIdpk { get; set; }

    public bool SpaCoordinator { get; set; }

    public bool SpaAssistantCoordinator { get; set; }

    public bool SpaView { get; set; }

    public bool SpaSubmitAttendance { get; set; }

    public bool SpaAcknowledge { get; set; }

    public bool SpaRecommendTopics { get; set; }

    public bool SpaApproveTopics { get; set; }

    public bool SpaDistributePpe { get; set; }

    public bool SpaInspector { get; set; }

    public bool SpaAdmin { get; set; }

    public bool SpaSendAlerts { get; set; }

    public bool SpaChairman { get; set; }

    public bool SpaManager { get; set; }

    public bool SpaDirector { get; set; }

    public bool SpaActive { get; set; }

    public int SpaSafetyGroupIdfk { get; set; }

    public int EmpIdpk { get; set; }

    public string EmpStaffNo { get; set; } = null!;

    public string EmpLastname { get; set; } = null!;

    public string EmpFirstname { get; set; } = null!;

    public string EmpOtherNames { get; set; } = null!;

    public string EmpName { get; set; } = null!;

    public string EmpName1 { get; set; } = null!;

    public string EmpName2 { get; set; } = null!;

    public string EmpName3 { get; set; } = null!;

    public string EmpName4 { get; set; } = null!;

    public string EmpFlnamesNoSpace { get; set; } = null!;

    public string EmpLfonamesNoSpace { get; set; } = null!;

    public string EmpLfnamesNoSpace { get; set; } = null!;

    public string SpaRmks { get; set; } = null!;

    public int SpaEmpIdfk { get; set; }

    public int? SpaCreatedBy { get; set; }

    public int? SpaEditedBy { get; set; }

    public DateTime? SpaCreationDate { get; set; }

    public DateTime? SpaEditedDate { get; set; }

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public int SgpIdpk { get; set; }

    public string SgpName { get; set; } = null!;

    public string SgpShtName { get; set; } = null!;

    public bool SgpActive { get; set; }

    public string SgpRmks { get; set; } = null!;

    public int? SgpCreatedBy { get; set; }

    public string EmpMobNox { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpPlc { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public bool SpaAlertFyi { get; set; }

    public bool SpaApprovePpeRequests { get; set; }

    public bool SpaIssuePpeToGroups { get; set; }

    public bool SpaRecommendPpeRequests { get; set; }

    public bool SpaAcknowledgePpeRequests { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public string CoordStaffNo { get; set; } = null!;

    public string CoordLname { get; set; } = null!;

    public string CoordFname { get; set; } = null!;

    public string CoordEmpName { get; set; } = null!;

    public string CoordJbtName { get; set; } = null!;

    public string CoordJbtShtName { get; set; } = null!;

    public int CoordDeptId { get; set; }

    public string CoordDeptName { get; set; } = null!;

    public string CoordDeptShtName { get; set; } = null!;

    public int CoordSxnId { get; set; }

    public string CoordSxnName { get; set; } = null!;

    public string CoordSxnShtName { get; set; } = null!;

    public bool SpaSubmitSchedules { get; set; }

    public bool SgpSafetyGroup { get; set; }

    public bool SgpMasterGroup { get; set; }

    public bool SgpTechnicalGroup { get; set; }

    public bool SpaSubmitWasacoReturns { get; set; }
}
