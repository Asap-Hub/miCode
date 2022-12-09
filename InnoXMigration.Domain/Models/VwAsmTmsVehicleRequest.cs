using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsVehicleRequest
{
    public int VrqIdpk { get; set; }

    public DateTime? VrqDepartureTime { get; set; }

    public int? DepartureWeekNo { get; set; }

    public string VrqCategory { get; set; } = null!;

    public byte? VrqRequestSeatingCapacity { get; set; }

    public byte VrqApprovedSeatingCapacity { get; set; }

    public string VrqApprovalRmks { get; set; } = null!;

    public string VrqCancellationRmks { get; set; } = null!;

    public int VrqApprovedVehicleIdfk { get; set; }

    public string VrqPurpose { get; set; } = null!;

    public bool VrqApproved { get; set; }

    public bool VrqSmsSent { get; set; }

    public string VrqRmks { get; set; } = null!;

    public string? VrqCreatedBy { get; set; }

    public DateTime? VrqCreationDate { get; set; }

    public int? RequestWeekNo { get; set; }

    public int RequesterEmpId { get; set; }

    public string? RequesterStaffNo { get; set; }

    public string? RequesterLname { get; set; }

    public string? RequesterFname { get; set; }

    public string RequesterOnames { get; set; } = null!;

    public string RequesterHrmsName { get; set; } = null!;

    public string? RequesterEmpName { get; set; }

    public string? RequesterEmpName1 { get; set; }

    public string? RequesterEmpName2 { get; set; }

    public string? RequesterEmpName3 { get; set; }

    public string? RequesterEmpName4 { get; set; }

    public string? RequesterEmpName5 { get; set; }

    public string? RequesterEmpName6 { get; set; }

    public string? RequesterEmpName7 { get; set; }

    public string? RequesterEmpName8 { get; set; }

    public string? RequesterEmpName9 { get; set; }

    public string? RequesterEmpName10 { get; set; }

    public string? RequesterEmpName11 { get; set; }

    public string RequesterEmpName16 { get; set; } = null!;

    public int RequesterDeptId { get; set; }

    public string RequesterDeptName { get; set; } = null!;

    public string RequesterDeptShtName { get; set; } = null!;

    public int RequesterSxnId { get; set; }

    public string RequesterSxnName { get; set; } = null!;

    public string RequesterSxnShtName { get; set; } = null!;

    public int RequesterLocId { get; set; }

    public string RequesterLocName { get; set; } = null!;

    public string RequesterLocShtName { get; set; } = null!;

    public string RequesterMobNox { get; set; } = null!;

    public string RequesterPlc { get; set; } = null!;

    public string RequesterMobNo { get; set; } = null!;

    public int RequesterJbtId { get; set; }

    public string RequesterJbtName { get; set; } = null!;

    public string RequesterJbtShtName { get; set; } = null!;

    public int DriverEmpId { get; set; }

    public string DriverStaffNo { get; set; } = null!;

    public string DriverLname { get; set; } = null!;

    public string DriverFname { get; set; } = null!;

    public string DriverOnames { get; set; } = null!;

    public string DriverHrmsNames { get; set; } = null!;

    public string DriverEmpName { get; set; } = null!;

    public string DriverEmpName1 { get; set; } = null!;

    public string DriverEmpName2 { get; set; } = null!;

    public string DriverEmpName3 { get; set; } = null!;

    public string DriverEmpName4 { get; set; } = null!;

    public string DriverEmpName5 { get; set; } = null!;

    public string DriverEmpName6 { get; set; } = null!;

    public string DriverEmpName7 { get; set; } = null!;

    public string DriverEmpName8 { get; set; } = null!;

    public string DriverEmpName9 { get; set; } = null!;

    public string DriverEmpName10 { get; set; } = null!;

    public string DriverEmpName11 { get; set; } = null!;

    public string DriverEmpName16 { get; set; } = null!;

    public int DriverDeptId { get; set; }

    public string DriverDeptName { get; set; } = null!;

    public string DriverDeptShtName { get; set; } = null!;

    public int DriverSxnId { get; set; }

    public string DriverSxnName { get; set; } = null!;

    public string DriverSxnShtName { get; set; } = null!;

    public int DriverLocId { get; set; }

    public string DriverLocName { get; set; } = null!;

    public string DriverLocShtName { get; set; } = null!;

    public string DriverMobNox { get; set; } = null!;

    public string DriverPlc { get; set; } = null!;

    public string DriverMobNo { get; set; } = null!;

    public int DriverJbtId { get; set; }

    public string DriverJbtName { get; set; } = null!;

    public string DriverJbtShtName { get; set; } = null!;

    public string? VrqFromTown { get; set; }

    public string? VrqToTown { get; set; }

    public int FromRgnId { get; set; }

    public string? FromRgnName { get; set; }

    public string? FromRgnShtName { get; set; }

    public int? FromRgnCtyId { get; set; }

    public string? FromRgnCtyName { get; set; }

    public string? FromRgnCtyShtName { get; set; }

    public string? FromRgnCtyNationality { get; set; }

    public int ToRgnId { get; set; }

    public string? ToRgnName { get; set; }

    public string? ToRgnShtName { get; set; }

    public int? ToRgnCtyId { get; set; }

    public string? ToRgnCtyName { get; set; }

    public string? ToRgnCtyShtName { get; set; }

    public string? ToRgnCtyNationality { get; set; }

    public int VdtIdpk { get; set; }

    public string VdtRegNo { get; set; } = null!;

    public string VdtChassisNo { get; set; } = null!;

    public decimal VdtTankCapacity { get; set; }

    public byte VdtSeatingCapacity { get; set; }

    public short RequesterGndId { get; set; }

    public string RequesterGndName { get; set; } = null!;

    public string RequesterGndShtName { get; set; } = null!;

    public int AssignedByEmpId { get; set; }

    public string AssignedByStaffNo { get; set; } = null!;

    public string AssignedByLname { get; set; } = null!;

    public string AssignedByFname { get; set; } = null!;

    public string AssignedByOnames { get; set; } = null!;

    public string AssignedByEmpName { get; set; } = null!;

    public string AssignedByEmpName1 { get; set; } = null!;

    public string AssignedByEmpName2 { get; set; } = null!;

    public string AssignedByEmpName3 { get; set; } = null!;

    public string AssignedByEmpName4 { get; set; } = null!;

    public string AssignedByEmpName5 { get; set; } = null!;

    public string AssignedByEmpName6 { get; set; } = null!;

    public string AssignedByEmpName7 { get; set; } = null!;

    public string AssignedByEmpName8 { get; set; } = null!;

    public string AssignedByEmpName9 { get; set; } = null!;

    public string AssignedByEmpName10 { get; set; } = null!;

    public string AssignedByEmpName11 { get; set; } = null!;

    public int AssignedByDeptId { get; set; }

    public string AssignedByDeptName { get; set; } = null!;

    public string AssignedByDeptShtName { get; set; } = null!;

    public int AssignedBySxnId { get; set; }

    public string AssignedBySxnName { get; set; } = null!;

    public string AssignedBySxnShtName { get; set; } = null!;

    public int AssignedByLocId { get; set; }

    public string AssignedByLocName { get; set; } = null!;

    public string AssignedByLocShtName { get; set; } = null!;

    public string AssignedByMobNox { get; set; } = null!;

    public string AssignedByPlc { get; set; } = null!;

    public string AssignedByMobNo { get; set; } = null!;

    public int AssignedByJbtId { get; set; }

    public string AssignedByJbtName { get; set; } = null!;

    public string AssignedByJbtShtName { get; set; } = null!;

    public short AssignedByGndId { get; set; }

    public string AssignedByGndName { get; set; } = null!;

    public string AssignedByGndShtName { get; set; } = null!;

    public int ApproverEmpId { get; set; }

    public string ApproverStaffNo { get; set; } = null!;

    public string ApproverLname { get; set; } = null!;

    public string ApproverFname { get; set; } = null!;

    public string ApproverOnames { get; set; } = null!;

    public string ApproverHrmsName { get; set; } = null!;

    public string ApproverEmpName { get; set; } = null!;

    public string ApproverEmpName1 { get; set; } = null!;

    public string ApproverEmpName2 { get; set; } = null!;

    public string ApproverEmpName3 { get; set; } = null!;

    public string ApproverEmpName4 { get; set; } = null!;

    public string ApproverEmpName5 { get; set; } = null!;

    public string ApproverEmpName6 { get; set; } = null!;

    public string ApproverEmpName7 { get; set; } = null!;

    public string ApproverEmpName8 { get; set; } = null!;

    public string ApproverEmpName9 { get; set; } = null!;

    public string ApproverEmpName10 { get; set; } = null!;

    public string ApproverEmpName11 { get; set; } = null!;

    public string ApproverEmpName16 { get; set; } = null!;

    public int ApproverDeptId { get; set; }

    public string ApproverDeptName { get; set; } = null!;

    public string ApproverDeptShtName { get; set; } = null!;

    public int ApproverSxnId { get; set; }

    public string ApproverSxnName { get; set; } = null!;

    public string ApproverSxnShtName { get; set; } = null!;

    public int ApproverLocId { get; set; }

    public string ApproverLocName { get; set; } = null!;

    public string ApproverLocShtName { get; set; } = null!;

    public string ApproverMobNox { get; set; } = null!;

    public string ApproverPlc { get; set; } = null!;

    public string ApproverMobNo { get; set; } = null!;

    public int ApproverJbtId { get; set; }

    public string ApproverJbtName { get; set; } = null!;

    public string ApproverJbtShtName { get; set; } = null!;

    public short ApproverGndId { get; set; }

    public string ApproverGndName { get; set; } = null!;

    public string ApproverGndShtName { get; set; } = null!;

    public int CancelledByEmpId { get; set; }

    public string CancelledByStaffNo { get; set; } = null!;

    public string CancelledByLname { get; set; } = null!;

    public string CancelledByFname { get; set; } = null!;

    public string CancelledByOnames { get; set; } = null!;

    public string CancelledByHrmsName { get; set; } = null!;

    public string CancelledByEmpName { get; set; } = null!;

    public string CancelledByEmpName1 { get; set; } = null!;

    public string CancelledByEmpName2 { get; set; } = null!;

    public string CancelledByEmpName3 { get; set; } = null!;

    public string CancelledByEmpName4 { get; set; } = null!;

    public string CancelledByEmpName5 { get; set; } = null!;

    public string CancelledByEmpName6 { get; set; } = null!;

    public string CancelledByEmpName7 { get; set; } = null!;

    public string CancelledByEmpName8 { get; set; } = null!;

    public string CancelledByEmpName9 { get; set; } = null!;

    public string CancelledByEmpName10 { get; set; } = null!;

    public string CancelledByEmpName11 { get; set; } = null!;

    public int CancelledByDeptId { get; set; }

    public string CancelledByDeptName { get; set; } = null!;

    public string CancelledByDeptShtName { get; set; } = null!;

    public int CancelledBySxnId { get; set; }

    public string CancelledBySxnName { get; set; } = null!;

    public string CancelledBySxnShtName { get; set; } = null!;

    public int CancelledByLocId { get; set; }

    public string CancelledByLocName { get; set; } = null!;

    public string CancelledByLocShtName { get; set; } = null!;

    public string CancelledByMobNox { get; set; } = null!;

    public string CancelledByPlc { get; set; } = null!;

    public string CancelledByMobNo { get; set; } = null!;

    public int CancelledByJbtId { get; set; }

    public string CancelledByJbtName { get; set; } = null!;

    public string CancelledByJbtShtName { get; set; } = null!;

    public short CancelledByGndId { get; set; }

    public string CancelledByGndName { get; set; } = null!;

    public string CancelledByGndShtName { get; set; } = null!;

    public int VraIdpk { get; set; }

    public string VraName { get; set; } = null!;

    public string VraShtName { get; set; } = null!;

    public bool VraActive { get; set; }

    public int VrqAreaIdfk { get; set; }

    public bool VrqRequestDriver { get; set; }

    public bool VrqRequestVehicle { get; set; }

    public bool VrqDriverApproved { get; set; }

    public bool VrqVehicleApproved { get; set; }

    public int? VrqRequesterEmpIdfk { get; set; }

    public string VrqRoute { get; set; } = null!;

    public bool VrqCancelled { get; set; }

    public int VrqCancelledByEmpIdfk { get; set; }

    public DateTime? VrqCancelledOn { get; set; }

    public byte VrqNoOnTrip { get; set; }

    public bool VrqRecommendationSmsSent { get; set; }

    public bool VrqRecommended { get; set; }

    public bool VrqSatisfied { get; set; }

    public string VrqSatisfactionRmks { get; set; } = null!;

    public bool VrqVehicleKeyOut { get; set; }

    public bool VrqVehicleKeyReturned { get; set; }

    public bool VrqActive { get; set; }

    public int VrqKeyPickedByEmpIdfk { get; set; }

    public int VrqKeyReturnedByEmpIdfk { get; set; }

    public DateTime? VrqEstimatedReturnTime { get; set; }

    public DateTime VrqActualReturnTime { get; set; }

    public int? VrqRequestClassIdfk { get; set; }

    public int VctIdpk { get; set; }

    public string VctName { get; set; } = null!;

    public string VctShtName { get; set; } = null!;

    public bool VctActive { get; set; }

    public int VrcIdpk { get; set; }

    public string VrcName { get; set; } = null!;

    public string VrcShtName { get; set; } = null!;

    public bool VrcActive { get; set; }

    public bool VrqOfficialUse { get; set; }

    public DateTime? VrqKeyPickedOn { get; set; }

    public DateTime? VrqKeyReturnedOn { get; set; }

    public DateTime? VrqApprovedOn { get; set; }

    public DateTime? VrqRecommendedOn { get; set; }

    public string VrqDebitNotes { get; set; } = null!;

    public decimal VrqDebitAmount { get; set; }

    public string VrqReactivationRmks { get; set; } = null!;

    public decimal VrqStartOdometerReading { get; set; }

    public decimal VrqFinalOdometerReading { get; set; }

    public decimal TripDistance { get; set; }

    public string VrqRecommendedRoute { get; set; } = null!;

    public string RequesterEmpName12 { get; set; } = null!;

    public int RecommendedByEmpId { get; set; }

    public string RecommendedByStaffNo { get; set; } = null!;

    public string RecommendedByLname { get; set; } = null!;

    public string RecommendedByFname { get; set; } = null!;

    public string RecommendedByOnames { get; set; } = null!;

    public string RecommendedByHrmsName { get; set; } = null!;

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

    public bool VrqPickupInspectionDone { get; set; }

    public bool VrqReturnInpsectionDone { get; set; }

    public bool VctPersonal { get; set; }

    public string VrqRecommendationRmks { get; set; } = null!;

    public string VrqDebitCategory { get; set; } = null!;

    public string VrqCostCenter { get; set; } = null!;

    public int VrqCostCenterIdfk { get; set; }

    public int CctIdpk { get; set; }

    public string CctName { get; set; } = null!;

    public string CctShtName { get; set; } = null!;

    public string VrqDebit { get; set; } = null!;

    public string VrqDebitDept { get; set; } = null!;

    public string VrqDebitSection { get; set; } = null!;

    public string VrqAssignmentRmks { get; set; } = null!;

    public string VrqAmendmentDetails { get; set; } = null!;

    public string VrqAmendmentReasons { get; set; } = null!;

    public int? VrqEstimatedNoOfDays { get; set; }

    public int? VrqActualNoOfDays { get; set; }

    public int VrrVehicleRequestIdfk { get; set; }

    public string VrrSatisfactionRmks { get; set; } = null!;

    public decimal VrrEffectiveCommunicationByRequester { get; set; }

    public decimal VrrTimeConsciousnessByRequester { get; set; }

    public decimal VrrDriverNeatnessByRequester { get; set; }

    public decimal VrrVehicleNeatnessByRequester { get; set; }

    public decimal VrrDriverInappropriateOvertakingByRequester { get; set; }

    public decimal VrrDriverOverSpeedingByRequester { get; set; }

    public bool VrrSuspectedProblemWithEyeSightByRequester { get; set; }

    public bool VrrDriverSuspectedOfAlcoholUsageByRequester { get; set; }

    public decimal VrrAverageRatingByRequester { get; set; }

    public decimal VrrAverageRatingByDriver { get; set; }

    public bool? VrrSatisfied { get; set; }

    public bool? VrrActive { get; set; }

    public bool? VrrDriversRatingAcknowledged { get; set; }

    public bool? VrrRequestersRatingAcknowledged { get; set; }

    public decimal? VrqAverageRatingByDriver { get; set; }

    public decimal? VrqAverageRatingByRequester { get; set; }

    public decimal? VrrSatisfiedWithGeneralConductOfDriverByRequester { get; set; }

    public decimal? VrrEffectiveCommunicationByDriver { get; set; }

    public decimal? VrrTimeConsciousnessByDriver { get; set; }

    public decimal? VrrRequesterNeatnessOfVehicleInteriorByDriver { get; set; }

    public decimal? VrrAskingDriverToOverSpeedByDriver { get; set; }

    public decimal? VrrAskingDriverToDriveLongerThanUsualByDriver { get; set; }

    public decimal? VrrSatisfiedWithGeneralConductOfRequesterByDriver { get; set; }
}
