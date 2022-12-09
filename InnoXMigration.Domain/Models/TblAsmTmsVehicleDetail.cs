using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleDetail
{
    public int VdtIdpk { get; set; }

    public string VdtRegNo { get; set; } = null!;

    public string VdtChassisNo { get; set; } = null!;

    public string? VdtEngineNo { get; set; }

    public int? VdtModelIdfk { get; set; }

    public int? VdtManufacturerIdfk { get; set; }

    public int? VdtCountryOfOriginIdfk { get; set; }

    public int? VdtSupplierIdfk { get; set; }

    public DateTime? VdtManufactureDate { get; set; }

    public DateTime? VdtSupplyDate { get; set; }

    public DateTime? VdtDvlaRegDate { get; set; }

    public int? VdtEngineTypeIdfk { get; set; }

    public int? VdtFuelTypeIdfk { get; set; }

    public decimal? VdtCubicCapacity { get; set; }

    public decimal? VdtTankCapacity { get; set; }

    public int? VdtPowerTrainIdfk { get; set; }

    public int? VdtTransmissionTypeIdfk { get; set; }

    public int? VdtEngineMakeIdfk { get; set; }

    public byte? VdtNoOfCylinders { get; set; }

    public decimal? VdtSpeedometerLimit { get; set; }

    public int? VdtSpeedometerUnitIdfk { get; set; }

    public string? VdtColour { get; set; }

    public int? VdtStatusIdfk { get; set; }

    public byte? VdtSeatingCapacity { get; set; }

    public decimal? VdtLength { get; set; }

    public decimal? VdtWidth { get; set; }

    public decimal? VdtHeight { get; set; }

    public byte? VdtNoOfAxles { get; set; }

    public byte? VdtNoOfWheels { get; set; }

    public string? VdtTyreSizeFront { get; set; }

    public string? VdtTyreSizeMiddle { get; set; }

    public string? VdtTyreSizeRear { get; set; }

    public decimal? VdtNetWeight { get; set; }

    public decimal? VdtGrossWeight { get; set; }

    public string? VdtHorsePower { get; set; }

    public decimal? VdtPrice { get; set; }

    public int? VdtPriceCurrencyIdfk { get; set; }

    public bool? VdtAssigned { get; set; }

    public DateTime? VdtLastPmDate { get; set; }

    public DateTime? VdtNextPmDate { get; set; }

    public DateTime? VdtScheduledPmDate { get; set; }

    public bool? VdtPmScheduled { get; set; }

    public int? VdtDaysToPm { get; set; }

    public int? VdtNextPmKm { get; set; }

    public int? VdtScheduledPmRequestIdfk { get; set; }

    public int? VdtScheduledPmWorkshopIdfk { get; set; }

    public DateTime? VdtLastRoadworthRenewalDate { get; set; }

    public DateTime? VdtNextRoadworthyRenewalDate { get; set; }

    public int? VdtDaysToRoadworthyRenewal { get; set; }

    public DateTime? VdtLastInsuranceRenewalDate { get; set; }

    public DateTime? VdtNextInsuranceRenewalDate { get; set; }

    public int? VdtDaysToInsuranceRenewal { get; set; }

    public int? VdtVehicleGroupIdfk { get; set; }

    public int? VdtOwnerEmpIdfk { get; set; }

    public int? VdtAdminEmpIdfk { get; set; }

    public int? VdtDriverEmpIdfk { get; set; }

    public int? VdtApprovingOfficerEmpIdfk { get; set; }

    public int? VdtControllerEmpIdfk { get; set; }

    public int? VdtManagerEmpIdfk { get; set; }

    public int? VdtDirectorEmpIdfk { get; set; }

    public int? VdtAssignedSectionIdfk { get; set; }

    public int? VdtAssignedUnitIdfk { get; set; }

    public bool? VdtGeneral { get; set; }

    public bool? VdtBus { get; set; }

    public bool? VdtSpecialised { get; set; }

    public bool? VdtMotorBike { get; set; }

    public bool? VdtEquipment { get; set; }

    public bool? VdtLightDuty { get; set; }

    public bool? VdtHeavyDuty { get; set; }

    public bool? VdtVehicle { get; set; }

    public bool? VdtActive { get; set; }

    public string? VdtRmks { get; set; }

    public string? VdtCreatedBy { get; set; }

    public int? VdtEditedBy { get; set; }

    public DateTime? VdtCreationDate { get; set; }

    public DateTime? VdtEditedDate { get; set; }
}
