using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmStaffInitiativesAssignment
{
    public int SiaIdpk { get; set; }

    public int? SiaPeriodIdfk { get; set; }

    public int? SiaSectionIdfk { get; set; }

    public int? SiaUnitIdfk { get; set; }

    public int? SiaStaffInitiativeIdfk { get; set; }

    public int? SiaMeasureIdfk { get; set; }

    public int? SiaTargetIdfk { get; set; }

    public int SiaWeight { get; set; }

    public string? SiaStakeholders { get; set; }

    public bool? SiaActive { get; set; }

    public string? SiaRmks { get; set; }

    public int? PrdIdpk { get; set; }

    public string? PrdName { get; set; }

    public string? PrdShtName { get; set; }

    public DateTime? PrdStartDate { get; set; }

    public DateTime? PrdEndDate { get; set; }

    public int? MsrIdpk { get; set; }

    public string? MsrName { get; set; }

    public string? MsrShtName { get; set; }

    public int? TgtIdpk { get; set; }

    public string? TgtName { get; set; }

    public string? TgtShtName { get; set; }

    public int? SiaSupActualIdfk { get; set; }

    public int StaffActualIdpk { get; set; }

    public string StaffActualName { get; set; } = null!;

    public string StaffActualShtName { get; set; } = null!;

    public bool StaffActualActive { get; set; }

    public int SupActualIdpk { get; set; }

    public string SupActualName { get; set; } = null!;

    public string SupActualShtName { get; set; } = null!;

    public bool SupActualActive { get; set; }

    public int StaffRatingIdpk { get; set; }

    public decimal StaffRatingRate { get; set; }

    public string StaffRatingInterpretation { get; set; } = null!;

    public string StaffRatingShtInterpretation { get; set; } = null!;

    public string StaffRatingGrade { get; set; } = null!;

    public bool StaffRatingActive { get; set; }

    public int SupRatingIdpk { get; set; }

    public decimal SupRatingRate { get; set; }

    public string SupRatingInterpretation { get; set; } = null!;

    public string SupRatingShtInterpretation { get; set; } = null!;

    public string SupRatingGrade { get; set; } = null!;

    public bool SupRatingActive { get; set; }

    public decimal SiaTargetFrequency { get; set; }

    public decimal SiaStaffPercentageComplete { get; set; }

    public int? SiaEmpIdfk { get; set; }

    public int? EmpId { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpOthernames { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public int UntIdpk { get; set; }

    public string UntName { get; set; } = null!;

    public string UntShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SinIdpk { get; set; }

    public string SinName { get; set; } = null!;

    public string SinShtName { get; set; } = null!;

    public bool SinActive { get; set; }

    public string SiaStakeholderIds { get; set; } = null!;

    public int RmmIdpk { get; set; }

    public string RmmName { get; set; } = null!;

    public string RmmShtName { get; set; } = null!;

    public int SiaMonitorResultsFromIdfk { get; set; }

    public bool RmmActive { get; set; }

    public bool SiaApplyTargetFrequency { get; set; }

    public bool SiaAllowActualsManualUpdate { get; set; }

    public bool SiaSubmitted { get; set; }

    public DateTime? SiaSubmittedOn { get; set; }

    public int? SiaSubmittedByEmpIdfk { get; set; }

    public int? SiaAcknowledgedByEmpIdfk { get; set; }

    public DateTime? SiaAcknowledgedOn { get; set; }

    public string SiaStaffAppraisalRmks { get; set; } = null!;

    public bool SiaAcknowledged { get; set; }

    public string EmpName16 { get; set; } = null!;

    public string EmpName17 { get; set; } = null!;

    public bool PrdOpened { get; set; }

    public bool PrdActive { get; set; }

    public short SiaOrder { get; set; }

    public bool SiaLocked { get; set; }

    public int SupEmpId { get; set; }

    public string SupStaffNo { get; set; } = null!;

    public string SupLname { get; set; } = null!;

    public string SupFname { get; set; } = null!;

    public string SupEmpName { get; set; } = null!;

    public string SupEmpName1 { get; set; } = null!;

    public string SupEmpName16 { get; set; } = null!;

    public string SupEmpName17 { get; set; } = null!;

    public int SupJbtIdpk { get; set; }

    public string SupJbtName { get; set; } = null!;

    public string SupJbtShtName { get; set; } = null!;

    public int SupDeptId { get; set; }

    public string SupDeptName { get; set; } = null!;

    public string SupDeptShtName { get; set; } = null!;

    public int SupSxnId { get; set; }

    public string SupSxnName { get; set; } = null!;

    public string SupSxnShtName { get; set; } = null!;

    public string SupMobNox { get; set; } = null!;

    public int MgrEmpId { get; set; }

    public string MgrStaffNo { get; set; } = null!;

    public string MgrLname { get; set; } = null!;

    public string MgrFname { get; set; } = null!;

    public string MgrEmpName { get; set; } = null!;

    public string MgrEmpName1 { get; set; } = null!;

    public string MgrEmpName16 { get; set; } = null!;

    public string MgrEmpName17 { get; set; } = null!;

    public int MgrJbtIdpk { get; set; }

    public string MgrJbtName { get; set; } = null!;

    public string MgrJbtShtName { get; set; } = null!;

    public int MgrDeptId { get; set; }

    public string MgrDeptName { get; set; } = null!;

    public string MgrDeptShtName { get; set; } = null!;

    public int MgrSxnId { get; set; }

    public string MgrSxnName { get; set; } = null!;

    public string MgrSxnShtName { get; set; } = null!;

    public string MgrMobNox { get; set; } = null!;

    public int DirEmpId { get; set; }

    public string DirStaffNo { get; set; } = null!;

    public string DirLname { get; set; } = null!;

    public string DirFname { get; set; } = null!;

    public string DirEmpName { get; set; } = null!;

    public string DirEmpName1 { get; set; } = null!;

    public string DirEmpName16 { get; set; } = null!;

    public string DirEmpName17 { get; set; } = null!;

    public int DirJbtIdpk { get; set; }

    public string DirJbtName { get; set; } = null!;

    public string DirJbtShtName { get; set; } = null!;

    public int DirDeptId { get; set; }

    public string DirDeptName { get; set; } = null!;

    public string DirDeptShtName { get; set; } = null!;

    public int DirSxnId { get; set; }

    public string DirSxnName { get; set; } = null!;

    public string DirSxnShtName { get; set; } = null!;

    public string DirMobNox { get; set; } = null!;

    public int? SiaSupervisorEmpIdfk { get; set; }

    public int? SiaManagerEmpIdfk { get; set; }

    public int? SiaDirectorEmpIdfk { get; set; }

    public bool? RmmSafetyManagerMeetingAttendance { get; set; }

    public int? CinIdpk { get; set; }

    public string? CinName { get; set; }

    public string? CinShtName { get; set; }

    public int? UinIdpk { get; set; }

    public string? UinName { get; set; }

    public string? UinShtName { get; set; }

    public bool? UinActive { get; set; }

    public int? SiaCorporateInitiativeIdfk { get; set; }

    public int? SiaUnitInitiativeIdfk { get; set; }

    public string SiaStaffActualValue { get; set; } = null!;

    public string SiaSupActualValue { get; set; } = null!;

    public int? SiaStaffRatingIdfk { get; set; }

    public int? SiaSupRatingIdfk { get; set; }

    public decimal SiaSupPercentageComplete { get; set; }

    public string? SiaSupAppraisalRmks { get; set; }

    public bool? SiaCompulsory { get; set; }

    public string SiaState { get; set; } = null!;

    public bool SiaSignedOff { get; set; }

    public decimal SiaTargetPercentageToComplete { get; set; }

    public decimal SiaTargetPercentageComplete { get; set; }

    public int? SiaObjectiveIdfk { get; set; }

    public int? ObjIdpk { get; set; }

    public string? ObjObjective { get; set; }

    public string? ObjObjectiveSht { get; set; }
}
