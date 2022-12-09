using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbPrivilegesAssignment
{
    public int PvaIdpk { get; set; }

    public int? PvaEmpIdfk { get; set; }

    public int? PvaStationIdfk { get; set; }

    public bool? PvaLog { get; set; }

    public bool? PvaView { get; set; }

    public bool? PvaHome { get; set; }

    public bool? PvaDefaultHome { get; set; }

    public bool? PvaShiftLeader { get; set; }

    public bool? PvaShiftMember { get; set; }

    public bool? PvaTakeOverShift { get; set; }

    public bool? PvaInitiateRemoteShiftChange { get; set; }

    public bool? PvaFlag { get; set; }

    public bool? PvaCaptureStationReadings { get; set; }

    public bool? PvaRequestProtectionGuaranteeApplications { get; set; }

    public bool? PvaSubmitProtectionGuaranteeApplications { get; set; }

    public bool? PvaReceiveProtectionGuaranteeApplications { get; set; }

    public bool? PvaAcknowledgeProtectionGuaranteeApplications { get; set; }

    public bool? PvaApproveProtectionGuaranteeApplications { get; set; }

    public bool? PvaPrepareOrderToOperate { get; set; }

    public bool? PvaApproveOrderToOperate { get; set; }

    public bool? PvaRequestProtectionGuarantees { get; set; }

    public bool? PvaApproveProtectionGuarantees { get; set; }

    public bool? PvaPrepareJobHazardAnalysis { get; set; }

    public bool? PvaApproveJobHazardAnalysis { get; set; }

    public bool? PvaSystemOperator { get; set; }

    public bool? PvaSupervisor { get; set; }

    public bool? PvaManager { get; set; }

    public bool? PvaDirector { get; set; }

    public DateTime? PvaStartDate { get; set; }

    public DateTime? PvaEndDate { get; set; }

    public bool? PvaComment { get; set; }

    public bool? PvaActive { get; set; }

    public string? PvaRmks { get; set; }

    public int? PvaCreatedBy { get; set; }

    public int? PvaEditedBy { get; set; }

    public DateTime? PvaCreationDate { get; set; }

    public DateTime? PvaEditedDate { get; set; }
}
