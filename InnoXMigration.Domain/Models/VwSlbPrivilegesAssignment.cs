using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbPrivilegesAssignment
{
    public int PvaIdpk { get; set; }

    public int? PvaStationIdfk { get; set; }

    public bool PvaLog { get; set; }

    public bool PvaView { get; set; }

    public bool PvaHome { get; set; }

    public bool PvaDefaultHome { get; set; }

    public bool PvaShiftLeader { get; set; }

    public bool PvaTakeOverShift { get; set; }

    public bool PvaInitiateRemoteShiftChange { get; set; }

    public bool PvaFlag { get; set; }

    public bool StnMasterStation { get; set; }

    public bool StnNationalControlCenter { get; set; }

    public bool StnOperational { get; set; }

    public bool PvaShiftMember { get; set; }

    public bool PvaSupervisor { get; set; }

    public bool PvaManager { get; set; }

    public bool PvaDirector { get; set; }

    public bool PvaComment { get; set; }

    public bool PvaActive { get; set; }

    public int StnIdpk { get; set; }

    public string StnName { get; set; } = null!;

    public string StnShtName { get; set; } = null!;

    public string StnCode { get; set; } = null!;

    public string StnContact { get; set; } = null!;

    public string StnTelNo { get; set; } = null!;

    public string StnPlc { get; set; } = null!;

    public bool StnActive { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string EmpOthernames { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public string? EmpFlnamesNoSpace { get; set; }

    public string? EmpLfonamesNoSpace { get; set; }

    public string? EmpLfnamesNoSpace { get; set; }

    public string? PvaRmks { get; set; }

    public int? PvaEmpIdfk { get; set; }

    public int? PvaCreatedBy { get; set; }

    public int? PvaEditedBy { get; set; }

    public DateTime? PvaCreationDate { get; set; }

    public DateTime? PvaEditedDate { get; set; }

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public string FjbtName { get; set; } = null!;

    public string FjbtShtName { get; set; } = null!;

    public bool LocActive { get; set; }

    public string AreName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;

    public bool AreActive { get; set; }

    public string EmpMobNox { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public bool PvaCaptureStationReadings { get; set; }

    public bool StnSubstation { get; set; }

    public bool StnGenStation { get; set; }

    public string? EmpName16 { get; set; }

    public string? EmpName17 { get; set; }

    public bool PvaPrepareOrderToOperate { get; set; }

    public bool PvaApproveOrderToOperate { get; set; }

    public bool PvaPrepareJobHazardAnalysis { get; set; }

    public bool PvaApproveJobHazardAnalysis { get; set; }

    public bool PvaRequestProtectionGuaranteeApplications { get; set; }

    public bool PvaSubmitProtectionGuaranteeApplications { get; set; }

    public bool PvaApproveProtectionGuaranteeApplications { get; set; }

    public bool PvaRequestProtectionGuarantees { get; set; }

    public bool PvaApproveProtectionGuarantees { get; set; }

    public bool StnShowInElogBook { get; set; }

    public string? EmpName19 { get; set; }

    public bool PvaReceiveProtectionGuaranteeApplications { get; set; }

    public bool PvaAcknowledgeProtectionGuaranteeApplications { get; set; }

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public DateTime PvaStartDate { get; set; }

    public DateTime PvaEndDate { get; set; }
}
