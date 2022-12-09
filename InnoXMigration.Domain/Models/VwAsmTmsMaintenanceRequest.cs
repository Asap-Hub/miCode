using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsMaintenanceRequest
{
    public int MrqIdpk { get; set; }

    public DateTime? MrqDate { get; set; }

    public int? MrqVehicleDetailIdfk { get; set; }

    public int? MrqWorkshopIdfk { get; set; }

    public int? MrqRequestedByEmpIdfk { get; set; }

    public string? MrqDefectRequest { get; set; }

    public string MrqReviewReport { get; set; } = null!;

    public string? MrqRmks { get; set; }

    public int VdtIdpk { get; set; }

    public string VdtRegNo { get; set; } = null!;

    public string VdtChassisNo { get; set; } = null!;

    public int WsdIdpk { get; set; }

    public string? WsdName { get; set; }

    public string? WsdShtName { get; set; }

    public string? WsdCode { get; set; }

    public string? WsdContact { get; set; }

    public string? WsdTelNo { get; set; }

    public string WsdPlc { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public int DriverEmpId { get; set; }

    public string? DriverStaffNo { get; set; }

    public string? DriverLname { get; set; }

    public string? DriverFname { get; set; }

    public string DriverOnames { get; set; } = null!;

    public string? DriverEmpName { get; set; }

    public string? DriverEmpName1 { get; set; }

    public string? DriverEmpName5 { get; set; }

    public int DriverDptId { get; set; }

    public string DriverDptName { get; set; } = null!;

    public string DriverDptShtName { get; set; } = null!;

    public int DriverSxnId { get; set; }

    public string DriverSxnName { get; set; } = null!;

    public string DriverSxnShtName { get; set; } = null!;

    public int DriverLocId { get; set; }

    public string DriverLocName { get; set; } = null!;

    public string DriverLocShtName { get; set; } = null!;

    public int DriverJbtId { get; set; }

    public string DriverJbtName { get; set; } = null!;

    public string DriverJbtShtName { get; set; } = null!;

    public string DriverMobNox { get; set; } = null!;

    public string DriverPlc { get; set; } = null!;

    public string DriverMobNo { get; set; } = null!;

    public int RequestedByEmpId { get; set; }

    public string? RequestedByStaffNo { get; set; }

    public string? RequestedByLname { get; set; }

    public string? RequestedByFname { get; set; }

    public string RequestedByOnames { get; set; } = null!;

    public string? RequestedByEmpName { get; set; }

    public string? RequestedByEmpName1 { get; set; }

    public string? RequestedByEmpName5 { get; set; }

    public string? RequestedByEmpName12 { get; set; }

    public int RequestedByDptIdpk { get; set; }

    public string RequestedByDptName { get; set; } = null!;

    public string RequestedByDptShtName { get; set; } = null!;

    public int RequestedBySxnId { get; set; }

    public string RequestedBySxnName { get; set; } = null!;

    public string RequestedBySxnShtName { get; set; } = null!;

    public int RequestedByLocId { get; set; }

    public string RequestedByLocName { get; set; } = null!;

    public string RequestedByLocShtName { get; set; } = null!;

    public int RequestedByJbtIdpk { get; set; }

    public string RequestedByJbtName { get; set; } = null!;

    public string RequestedByJbtShtName { get; set; } = null!;

    public string RequestedByMobNox { get; set; } = null!;

    public string RequestedByPlc { get; set; } = null!;

    public string RequestedByMobNo { get; set; } = null!;

    public int RecommendedByEmpId { get; set; }

    public string RecommendedByStaffNo { get; set; } = null!;

    public string RecommendedByLname { get; set; } = null!;

    public string RecommendedByFname { get; set; } = null!;

    public string RecommendedByOnames { get; set; } = null!;

    public string RecommendedByEmpName { get; set; } = null!;

    public string RecommendedByEmpName1 { get; set; } = null!;

    public string RecommendedByEmpName2 { get; set; } = null!;

    public string RecommendedByEmpName3 { get; set; } = null!;

    public string RecommendedByEmpName4 { get; set; } = null!;

    public string RecommendedByEmpName5 { get; set; } = null!;

    public string RecommendedByEmpName6 { get; set; } = null!;

    public string RecommendedByEmpName7 { get; set; } = null!;

    public string RecommendedByEmpName8 { get; set; } = null!;

    public string RecommendedByEmpName9 { get; set; } = null!;

    public string RecommendedByEmpName10 { get; set; } = null!;

    public string RecommendedByEmpName11 { get; set; } = null!;

    public int RecommendedByDeptId { get; set; }

    public string RecommendedByDeptName { get; set; } = null!;

    public string RecommendedByDeptShtName { get; set; } = null!;

    public int RecommendedBySxnId { get; set; }

    public string RecommendedBySxnName { get; set; } = null!;

    public string RecommendedBySxnShtName { get; set; } = null!;

    public int RecommendedByLocId { get; set; }

    public string RecommendedByLocName { get; set; } = null!;

    public string RecommendedByLocShtName { get; set; } = null!;

    public string RecommendedByMobNox { get; set; } = null!;

    public string RecommendedByPlc { get; set; } = null!;

    public string RecommendedByMobNo { get; set; } = null!;

    public int RecommendedByJbtId { get; set; }

    public string RecommendedByJbtName { get; set; } = null!;

    public string RecommendedByJbtShtName { get; set; } = null!;

    public short RecommendedByGndId { get; set; }

    public string RecommendedByGndName { get; set; } = null!;

    public string RecommendedByGndShtName { get; set; } = null!;

    public int ApprovedByEmpId { get; set; }

    public string ApprovedByStaffNo { get; set; } = null!;

    public string ApprovedByLname { get; set; } = null!;

    public string ApprovedByFname { get; set; } = null!;

    public string ApprovedByOnames { get; set; } = null!;

    public string ApprovedByEmpName { get; set; } = null!;

    public string ApprovedByEmpName1 { get; set; } = null!;

    public string ApprovedByEmpName2 { get; set; } = null!;

    public string ApprovedByEmpName3 { get; set; } = null!;

    public string ApprovedByEmpName4 { get; set; } = null!;

    public string ApprovedByEmpName5 { get; set; } = null!;

    public string ApprovedByEmpName6 { get; set; } = null!;

    public string ApprovedByEmpName7 { get; set; } = null!;

    public string ApprovedByEmpName8 { get; set; } = null!;

    public string ApprovedByEmpName9 { get; set; } = null!;

    public string ApprovedByEmpName10 { get; set; } = null!;

    public string ApprovedByEmpName11 { get; set; } = null!;

    public int ApprovedByDeptId { get; set; }

    public string ApprovedByDeptName { get; set; } = null!;

    public string ApprovedByDeptShtName { get; set; } = null!;

    public int ApprovedBySxnId { get; set; }

    public string ApprovedBySxnName { get; set; } = null!;

    public string ApprovedBySxnShtName { get; set; } = null!;

    public int ApprovedByLocId { get; set; }

    public string ApprovedByLocName { get; set; } = null!;

    public string ApprovedByLocShtName { get; set; } = null!;

    public string ApprovedByMobNox { get; set; } = null!;

    public string ApprovedByPlc { get; set; } = null!;

    public string ApprovedByMobNo { get; set; } = null!;

    public int ApprovedByJbtId { get; set; }

    public string ApprovedByJbtName { get; set; } = null!;

    public string ApprovedByJbtShtName { get; set; } = null!;

    public short ApprovedByGndId { get; set; }

    public string ApprovedByGndName { get; set; } = null!;

    public string ApprovedByGndShtName { get; set; } = null!;

    public int CancelledByEmpId { get; set; }

    public string CancelledByStaffNo { get; set; } = null!;

    public string CancelledByLname { get; set; } = null!;

    public string CancelledByFname { get; set; } = null!;

    public string CancelledByOnames { get; set; } = null!;

    public string CancelledByEmpName { get; set; } = null!;

    public string CancelledByEmpName1 { get; set; } = null!;

    public string CancelledByEmpName5 { get; set; } = null!;

    public int CancelledByDptIdpk { get; set; }

    public string CancelledByDptName { get; set; } = null!;

    public string CancelledByDptShtName { get; set; } = null!;

    public int CancelledBySxnIdpk { get; set; }

    public string CancelledBySxnName { get; set; } = null!;

    public string CancelledBySxnShtName { get; set; } = null!;

    public int CancelledByLocIdpk { get; set; }

    public string CancelledByLocName { get; set; } = null!;

    public string CancelledByLocShtName { get; set; } = null!;

    public int CancelledByJbtIdpk { get; set; }

    public string CancelledByJbtName { get; set; } = null!;

    public string CancelledByJbtShtName { get; set; } = null!;

    public string CancelledByMobNox { get; set; } = null!;

    public string CancelledByPlc { get; set; } = null!;

    public string CancelledByMobNo { get; set; } = null!;

    public int? MrqCreatedBy { get; set; }

    public int? MrqEditedBy { get; set; }

    public DateTime? MrqCreationDate { get; set; }

    public DateTime? MrqEditedDate { get; set; }

    public int? MrqDriverEmpIdfk { get; set; }

    public int? MtaIdpk { get; set; }

    public DateTime? MtaDateIn { get; set; }

    public DateTime? MtaDateOut { get; set; }

    public string MtaJobNo { get; set; } = null!;

    public decimal? MtaSpeedoIn { get; set; }

    public decimal? MtaSpeedoOut { get; set; }

    public bool MtaOpened { get; set; }

    public bool? MrqCancelled { get; set; }

    public int? MrqCancelledByEmpIdfk { get; set; }

    public string? RqstCreatedByStaffNo { get; set; }

    public int? RqstCreatedByEmpId { get; set; }

    public string? RqstCreatedByLname { get; set; }

    public string? RqstCreatedByOnames { get; set; }

    public string? RqstCreatedByEmpName { get; set; }

    public string? RqstCreatedByEmpName1 { get; set; }

    public string? RqstCreatedByEmpName2 { get; set; }

    public string? RqstCreatedByEmpName12 { get; set; }

    public int? RqstCreatedByLocId { get; set; }

    public string? RqstCreatedByLocName { get; set; }

    public int RqstCreatedBySxnId { get; set; }

    public string RqstCreatedBySxnName { get; set; } = null!;

    public int? RqstCreatedByDptId { get; set; }

    public string? RqstCreatedByDptName { get; set; }

    public int RqstCreatedByJbtId { get; set; }

    public string RqstCreatedByJbtName { get; set; } = null!;

    public string RqstCreatedByJbtShtName { get; set; } = null!;

    public string RqstCreatedByMobNox { get; set; } = null!;

    public string RqstCreatedByMobNo { get; set; } = null!;

    public string RqstCreatedByPlc { get; set; } = null!;

    public DateTime? MrqCancellationDate { get; set; }

    public string? MtaCreatedBy { get; set; }

    public DateTime? MtaEditedDate { get; set; }

    public int? MtaServiceRequestIdfk { get; set; }

    public DateTime? MtaCreationDate { get; set; }

    public int? MtaEditedBy { get; set; }

    public int OpenedByEmpId { get; set; }

    public string OpenedByStaffNo { get; set; } = null!;

    public string OpenedByLname { get; set; } = null!;

    public string OpenedByOnames { get; set; } = null!;

    public string OpenedByEmpName { get; set; } = null!;

    public string OpenedByEmpName1 { get; set; } = null!;

    public string OpenedByEmpName2 { get; set; } = null!;

    public int OpenedByLocId { get; set; }

    public string OpenedByLocName { get; set; } = null!;

    public int OpenedBySxnId { get; set; }

    public string OpenedBySxnName { get; set; } = null!;

    public string OpenedBySxnShtName { get; set; } = null!;

    public int OpenedByDptId { get; set; }

    public string OpenedByDptName { get; set; } = null!;

    public string OpenedByDptShtName { get; set; } = null!;

    public int OpenedByJbtId { get; set; }

    public string OpenedByJbtName { get; set; } = null!;

    public string OpenedByJbtShtName { get; set; } = null!;

    public string OpenedByMobNox { get; set; } = null!;

    public string OpenedByMobNo { get; set; } = null!;

    public string OpenedByPlc { get; set; } = null!;

    public decimal MrqPercentComplete { get; set; }

    public DateTime? MrqCompletionDate { get; set; }

    public DateTime? MrqDateUpdated { get; set; }

    public bool MtaDone { get; set; }

    public DateTime? MrqReportDate { get; set; }

    public bool MrqAcknowledged { get; set; }

    public DateTime? MrqAcknowledgedOn { get; set; }

    public decimal MrqRating { get; set; }

    public bool MrqPm { get; set; }

    public int MtpIdpk { get; set; }

    public string? MtpName { get; set; }

    public string? MtpShtName { get; set; }

    public bool? MtpPreventiveMaintenance { get; set; }

    public bool? MtpRoadworthy { get; set; }

    public bool? MtpInsuranceRenewal { get; set; }

    public bool? MtpActive { get; set; }

    public string? MtpRmks { get; set; }

    public int? MrqMaintenanceTypeIdfk { get; set; }

    public bool PmWorkshopExternal { get; set; }

    public string PmWorkshopEmail { get; set; } = null!;

    public DateTime? VdtLastPmDate { get; set; }

    public DateTime? VdtNextPmDate { get; set; }

    public DateTime? VdtScheduledPmDate { get; set; }

    public int VdtDaysToPm { get; set; }

    public DateTime? VdtLastRoadworthRenewalDate { get; set; }

    public DateTime? VdtNextRoadworthyRenewalDate { get; set; }

    public int? VdtDaysToRoadworthyRenewal { get; set; }

    public DateTime? VdtLastInsuranceRenewalDate { get; set; }

    public DateTime? VdtNextInsuranceRenewalDate { get; set; }

    public int VdtDaysToInsuranceRenewal { get; set; }

    public bool VdtPmScheduled { get; set; }

    public int VdtNextPmKm { get; set; }

    public int PmWorkshopId { get; set; }

    public string PmWorkshopName { get; set; } = null!;

    public string PmWorkshopShtName { get; set; } = null!;

    public string PmWorkshopCode { get; set; } = null!;

    public string PmWorkshopContact { get; set; } = null!;

    public string PmWorkshopTelNo { get; set; } = null!;

    public string PmWorkshopPlc { get; set; } = null!;

    public string PmWorkshopAddress { get; set; } = null!;

    public int? MdlIdpk { get; set; }

    public string? MdlName { get; set; }

    public string? MdlShtName { get; set; }

    public int? VmkIdpk { get; set; }

    public string? VmkName { get; set; }

    public string? VmkShtName { get; set; }

    public int? VhcIdpk { get; set; }

    public string? VhcName { get; set; }

    public string? VhcShtName { get; set; }

    public bool MrqOpened { get; set; }

    public bool MrqDone { get; set; }

    public int VdtScheduledPmRequestIdfk { get; set; }

    public int? MrqScheduleWorkshopIdfk { get; set; }

    public int? SchedWkshpId { get; set; }

    public string? SchedWkshpName { get; set; }

    public string? SchedWkshpShtName { get; set; }

    public string? SchedWkshpCode { get; set; }

    public string? SchedWkshpContact { get; set; }

    public int? SchedWkshpTownId { get; set; }

    public string? SchedWkshpTownName { get; set; }

    public string? SchedWkshpTownShtName { get; set; }

    public bool? MrqSmsSent { get; set; }

    public int? MrqAcknowledgedByEmpIdfk { get; set; }

    public int AcknowledgedByEmpId { get; set; }

    public string AcknowledgedByStaffNo { get; set; } = null!;

    public string AcknowledgedByLname { get; set; } = null!;

    public string AcknowledgedByFname { get; set; } = null!;

    public string AcknowledgedByOnames { get; set; } = null!;

    public string AcknowledgedByEmpName { get; set; } = null!;

    public string AcknowledgedByEmpName1 { get; set; } = null!;

    public string AcknowledgedByEmpName5 { get; set; } = null!;

    public string AcknowledgedByEmpName12 { get; set; } = null!;

    public int AcknowledgedByDptIdpk { get; set; }

    public string AcknowledgedByDptName { get; set; } = null!;

    public string AcknowledgedByDptShtName { get; set; } = null!;

    public int AcknowledgedBySxnIdpk { get; set; }

    public string AcknowledgedBySxnName { get; set; } = null!;

    public string AcknowledgedBySxnShtName { get; set; } = null!;

    public int AcknowledgedByLocIdpk { get; set; }

    public string AcknowledgedByLocName { get; set; } = null!;

    public string AcknowledgedByLocShtName { get; set; } = null!;

    public int AcknowledgedByJbtIdpk { get; set; }

    public string AcknowledgedByJbtName { get; set; } = null!;

    public string AcknowledgedByJbtShtName { get; set; } = null!;

    public string AcknowledgedByMobNox { get; set; } = null!;

    public string AcknowledgedByPlc { get; set; } = null!;

    public string AcknowledgedByMobNo { get; set; } = null!;

    public bool MrqApproved { get; set; }

    public DateTime? MrqApprovalDate { get; set; }

    public int MrqApprovedByEmpIdfk { get; set; }

    public DateTime? MrqCancelledOn { get; set; }

    public DateTime? MrqReportedOn { get; set; }

    public bool? MrqRecommended { get; set; }
}
