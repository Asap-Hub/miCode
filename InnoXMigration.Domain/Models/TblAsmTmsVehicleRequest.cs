using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleRequest
{
    public int VrqIdpk { get; set; }

    public int? VrqRequesterEmpIdfk { get; set; }

    public int? VrqRecommendedByEmpIdfk { get; set; }

    public int? VrqAssignedByEmpIdfk { get; set; }

    public int? VrqRequesterDeptIdfk { get; set; }

    public int? VrqRequesterSectionIdfk { get; set; }

    public int? VrqDriverEmpIdfk { get; set; }

    public int? VrqDriverDeptIdfk { get; set; }

    public int? VrqDriverSectionIdfk { get; set; }

    public int? VrqPickupInspectionByEmpIdfk { get; set; }

    public int? VrqReturnInspectionByEmpIdfk { get; set; }

    public DateTime? VrqPickupInspectionTime { get; set; }

    public DateTime? VrqReturnInspectionTime { get; set; }

    public bool? VrqVehicleInspectionConditionOk { get; set; }

    public bool? VrqVehicleReturnConditionOk { get; set; }

    public string? VrqPickupInspectionRmks { get; set; }

    public string? VrqReturnInspectionRmks { get; set; }

    public bool? VrqPickupInspectionDone { get; set; }

    public bool? VrqReturnInpsectionDone { get; set; }

    public DateTime? VrqDepartureTime { get; set; }

    public DateTime? VrqEstimatedReturnTime { get; set; }

    public DateTime? VrqActualReturnTime { get; set; }

    public DateTime? VrqArrivalTime { get; set; }

    public int? VrqFromRegionIdfk { get; set; }

    public int? VrqToRegionIdfk { get; set; }

    public string? VrqFromTown { get; set; }

    public string? VrqToTown { get; set; }

    public string? VrqRoute { get; set; }

    public string? VrqRecommendedRoute { get; set; }

    public int? VrqAreaIdfk { get; set; }

    public string? VrqCategory { get; set; }

    public int? VrqCategoryIdfk { get; set; }

    public int? VrqRequestClassIdfk { get; set; }

    public byte? VrqRequestSeatingCapacity { get; set; }

    public byte? VrqNoOnTrip { get; set; }

    public decimal? VrqStartOdometerReading { get; set; }

    public decimal? VrqFinalOdometerReading { get; set; }

    public int? VrqApprovedByEmpIdfk { get; set; }

    public bool? VrqDriverApproved { get; set; }

    public bool? VrqVehicleApproved { get; set; }

    public int? VrqApprovedVehicleIdfk { get; set; }

    public byte? VrqApprovedSeatingCapacity { get; set; }

    public string? VrqAssignmentRmks { get; set; }

    public string? VrqApprovalRmks { get; set; }

    public string? VrqCancellationRmks { get; set; }

    public string? VrqRecommendationRmks { get; set; }

    public string? VrqReactivationRmks { get; set; }

    public string? VrqPurpose { get; set; }

    public string? VrqAmendmentDetails { get; set; }

    public string? VrqAmendmentReasons { get; set; }

    public bool? VrqRecommended { get; set; }

    public bool? VrqApproved { get; set; }

    public bool? VrqAssigned { get; set; }

    public bool? VrqCancelled { get; set; }

    public int? VrqCancelledByEmpIdfk { get; set; }

    public bool? VrqSmsSent { get; set; }

    public bool? VrqRecommendationSmsSent { get; set; }

    public string? VrqDebitCategory { get; set; }

    public string? VrqDebit { get; set; }

    public string? VrqDebitDept { get; set; }

    public string? VrqDebitSection { get; set; }

    public int? VrqCostCenterIdfk { get; set; }

    public string? VrqCostCenter { get; set; }

    public string? VrqDebitNotes { get; set; }

    public decimal? VrqDebitAmount { get; set; }

    public bool? VrqRequestDriver { get; set; }

    public DateTime? VrqRecommededOn { get; set; }

    public bool? VrqRequestVehicle { get; set; }

    public bool? VrqSatisfied { get; set; }

    public string? VrqSatisfactionRmks { get; set; }

    public bool? VrqVehicleKeyOut { get; set; }

    public bool? VrqVehicleKeyReturned { get; set; }

    public int? VrqKeyPickedByEmpIdfk { get; set; }

    public int? VrqKeyReturnedByEmpIdfk { get; set; }

    public string? VrqKeyOutRmks { get; set; }

    public string? VrqKeyReturnRmks { get; set; }

    public decimal? VrqAverageRatingByDriver { get; set; }

    public decimal? VrqAverageRatingByRequester { get; set; }

    public bool? VrqActive { get; set; }

    public bool? VrqOfficialUse { get; set; }

    public string? VrqVehicleKeyRmks { get; set; }

    public string? VrqRmks { get; set; }

    public string? VrqCreatedBy { get; set; }

    public int? VrqEditedBy { get; set; }

    public DateTime? VrqRecommendedOn { get; set; }

    public DateTime? VrqApprovedOn { get; set; }

    public DateTime? VrqKeyPickedOn { get; set; }

    public DateTime? VrqKeyReturnedOn { get; set; }

    public DateTime? VrqCancelledOn { get; set; }

    public DateTime? VrqAssignedOn { get; set; }

    public DateTime? VrqCreationDate { get; set; }

    public DateTime? VrqEditedDate { get; set; }

    public decimal? VrqRating { get; set; }
}
