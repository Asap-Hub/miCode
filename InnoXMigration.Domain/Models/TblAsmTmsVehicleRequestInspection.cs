using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleRequestInspection
{
    public int VriIdpk { get; set; }

    public int? VriRequestIdfk { get; set; }

    public bool? VriPickupBrakesWorkingCorrectly { get; set; }

    public bool? VriPickupBumpersInGoodCondition { get; set; }

    public bool? VriPickupHornWorkingProperly { get; set; }

    public bool? VriPickupSeatbeltsInGoodCondition { get; set; }

    public bool? VriPickupWariningTriangleAvailable { get; set; }

    public bool? VriPickupWindowsControlsWorking { get; set; }

    public bool? VriPickupInteriorIsClean { get; set; }

    public bool? VriPickupCracksOnWindscreen { get; set; }

    public bool? VriPickupSideMirrorsInGoodCondition { get; set; }

    public bool? VriPickupBrakeLightsWorkingCorrectly { get; set; }

    public bool? VriPickupHeadlightsWorkingCorrectly { get; set; }

    public bool? VriPickupIndicatorLightsWorkingCorrectly { get; set; }

    public bool? VriPickupReverseLightsWorkingCorrectly { get; set; }

    public bool? VriPickupAllInsideLightsWorkingCorrectly { get; set; }

    public bool? VriPickupTyresInGoodCondition { get; set; }

    public bool? VriPickupSpareTyreAvailable { get; set; }

    public bool? VriPickupToolsForReplacingTyresAvailable { get; set; }

    public bool? VriPickupBrakeFluidLevelOk { get; set; }

    public bool? VriPickupEngineOilLevelOk { get; set; }

    public bool? VriPickupPowerSteeringFluidLevelOk { get; set; }

    public bool? VriPickupCoolantLevelOk { get; set; }

    public bool? VriPickupFireExtinguisherAvailable { get; set; }

    public bool? VriPickupFullyStockedFirstAidKidAvailable { get; set; }

    public bool? VriPickupBatteryOk { get; set; }

    public bool? VriPickupAnyLeakages { get; set; }

    public bool? VriPickupWipersInGoodCondition { get; set; }

    public bool? VriPickupAnyDents { get; set; }

    public bool? VriPickupAnyScratches { get; set; }

    public bool? VriPickupInsuranceValid { get; set; }

    public bool? VriPickupRoadworthyValid { get; set; }

    public bool? VriPickupDriversLicensePresentAndValid { get; set; }

    public bool? VriPickupAllFloorMatsIntact { get; set; }

    public bool? VriPickupAcInGoodCondition { get; set; }

    public bool? VriReturnBrakesWorkingCorrectly { get; set; }

    public bool? VriReturnBumpersInGoodCondition { get; set; }

    public bool? VriReturnHornWorkingProperly { get; set; }

    public bool? VriReturnSeatbeltsInGoodCondition { get; set; }

    public bool? VriReturnWariningTriangleAvailable { get; set; }

    public bool? VriReturnWindowsControlsWorking { get; set; }

    public bool? VriReturnInteriorIsClean { get; set; }

    public bool? VriReturnCracksOnWindscreen { get; set; }

    public bool? VriReturnSideMirrorsInGoodCondition { get; set; }

    public bool? VriReturnBrakeLightsWorkingCorrectly { get; set; }

    public bool? VriReturnHeadlightsWorkingCorrectly { get; set; }

    public bool? VriReturnIndicatorLightsWorkingCorrectly { get; set; }

    public bool? VriReturnReverseLightsWorkingCorrectly { get; set; }

    public bool? VriReturnAllInsideLightsWorkingCorrectly { get; set; }

    public bool? VriReturnTyresInGoodCondition { get; set; }

    public bool? VriReturnSpareTyreAvailable { get; set; }

    public bool? VriReturnToolsForReplacingTyresAvailable { get; set; }

    public bool? VriReturnBrakeFluidLevelOk { get; set; }

    public bool? VriReturnEngineOilLevelOk { get; set; }

    public bool? VriReturnPowerSteeringFluidLevelOk { get; set; }

    public bool? VriReturnCoolantLevelOk { get; set; }

    public bool? VriReturnFireExtinguisherAvailable { get; set; }

    public bool? VriReturnFullyStockedFirstAidKidAvailable { get; set; }

    public bool? VriReturnBatteryOk { get; set; }

    public bool? VriReturnAnyLeakages { get; set; }

    public bool? VriReturnWipersInGoodCondition { get; set; }

    public bool? VriReturnAnyDents { get; set; }

    public bool? VriReturnAnyScratches { get; set; }

    public bool? VriReturnInsuranceValid { get; set; }

    public bool? VriReturnRoadworthyValid { get; set; }

    public bool? VriReturnDriversLicensePresentAndValid { get; set; }

    public bool? VriReturnAllFloorMatsIntact { get; set; }

    public bool? VriReturnAcInGoodCondition { get; set; }

    public int? VriPickupInspectorEmpIdfk { get; set; }

    public int? VriReturnInspectionByEmpIdfk { get; set; }

    public DateTime? VriPickupInspectionTime { get; set; }

    public DateTime? VriReturnInspectionTime { get; set; }

    public bool? VriVehiclePickupConditionOk { get; set; }

    public bool? VriVehicleReturnConditionOk { get; set; }

    public string? VriPickupInspectionRmks { get; set; }

    public string? VriReturnInspectionRmks { get; set; }

    public bool? VriActive { get; set; }

    public int? VriCreatedBy { get; set; }

    public int? VriEditedBy { get; set; }

    public DateTime? VriCreationDate { get; set; }

    public DateTime? VriEditedDate { get; set; }
}
