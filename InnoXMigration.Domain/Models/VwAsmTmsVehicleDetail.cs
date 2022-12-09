using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsVehicleDetail
{
    public int VdtIdpk { get; set; }

    public string VdtRegNo { get; set; } = null!;

    public string VdtChassisNo { get; set; } = null!;

    public decimal VdtCubicCapacity { get; set; }

    public decimal VdtTankCapacity { get; set; }

    public byte VdtNoOfCylinders { get; set; }

    public string VdtTyreSizeFront { get; set; } = null!;

    public string VdtTyreSizeMiddle { get; set; } = null!;

    public string VdtTyreSizeRear { get; set; } = null!;

    public decimal VdtNetWeight { get; set; }

    public decimal VdtGrossWeight { get; set; }

    public int? VdtModelIdfk { get; set; }

    public decimal VdtLength { get; set; }

    public decimal VdtWidth { get; set; }

    public decimal VdtHeight { get; set; }

    public byte VdtNoOfAxles { get; set; }

    public byte VdtNoOfWheels { get; set; }

    public string VdtEngineNo { get; set; } = null!;

    public string VdtHorsePower { get; set; } = null!;

    public int VdtCountryOfOriginIdfk { get; set; }

    public int? VdtSupplierIdfk { get; set; }

    public int? VdtStatusIdfk { get; set; }

    public DateTime? VdtManufactureDate { get; set; }

    public DateTime VdtSupplyDate { get; set; }

    public decimal? ManufactureAge { get; set; }

    public decimal? SupplyAge { get; set; }

    public bool VdtAssigned { get; set; }

    public decimal VdtPrice { get; set; }

    public int? VdtPriceCurrencyIdfk { get; set; }

    public int? VdtPowerTrainIdfk { get; set; }

    public int? VdtFuelTypeIdfk { get; set; }

    public string? VdtColour { get; set; }

    public int? VdtEngineTypeIdfk { get; set; }

    public byte VdtSeatingCapacity { get; set; }

    public bool? VdtActive { get; set; }

    public string? VdtRmks { get; set; }

    public string? VdtCreatedBy { get; set; }

    public int? VdtEditedBy { get; set; }

    public DateTime? VdtCreationDate { get; set; }

    public DateTime? VdtEditedDate { get; set; }

    public int? MdlIdpk { get; set; }

    public string? MdlName { get; set; }

    public string? MdlShtName { get; set; }

    public int? MdlManufacturerIdfk { get; set; }

    public int? MdlVehicleMakeIdfk { get; set; }

    public bool? MdlActive { get; set; }

    public string? MdlRmks { get; set; }

    public string? MdlCreatedBy { get; set; }

    public int? MdlEditedBy { get; set; }

    public DateTime? MdlCreationDate { get; set; }

    public DateTime? MdlEditedDate { get; set; }

    public int? VmkIdpk { get; set; }

    public string? VmkName { get; set; }

    public string? VmkShtName { get; set; }

    public bool? VmkActive { get; set; }

    public string? VmkRmks { get; set; }

    public string? VmkCreatedBy { get; set; }

    public int? VmkEditedBy { get; set; }

    public DateTime? VmkCreationDate { get; set; }

    public DateTime? VmkEditedDate { get; set; }

    public int? VmkVehicleClassIdfk { get; set; }

    public int? VhcIdpk { get; set; }

    public string? VhcName { get; set; }

    public string? VhcShtName { get; set; }

    public bool? VhcActive { get; set; }

    public string? VhcRmks { get; set; }

    public string? VhcCreatedBy { get; set; }

    public int? VhcEditedBy { get; set; }

    public DateTime? VhcCreationDate { get; set; }

    public DateTime? VhcEditedDate { get; set; }

    public int? VstIdpk { get; set; }

    public string? VstName { get; set; }

    public string? VstShtName { get; set; }

    public bool? VstFitStatus { get; set; }

    public bool? VstActive { get; set; }

    public string? VstRmks { get; set; }

    public string? VstCreatedBy { get; set; }

    public int? VstEditedBy { get; set; }

    public DateTime? VstCreationDate { get; set; }

    public DateTime? VstEditedDate { get; set; }

    public int? SplIdpk { get; set; }

    public string? SplName { get; set; }

    public string? SplShtName { get; set; }

    public string? SplMainContact { get; set; }

    public string? SplMobNos { get; set; }

    public string? SplEmail { get; set; }

    public string? SplTelNos { get; set; }

    public string? SplPostalAddress { get; set; }

    public string? SplResidentialAddress { get; set; }

    public bool? SplActive { get; set; }

    public string? SplRmks { get; set; }

    public int? SplCreatedBy { get; set; }

    public int? SplEditedBy { get; set; }

    public DateTime? SplCreationDate { get; set; }

    public DateTime? SplEditedDate { get; set; }

    public int? FtpIdpk { get; set; }

    public string? FtpName { get; set; }

    public string? FtpShtName { get; set; }

    public bool? FtpActive { get; set; }

    public string? FtpRmks { get; set; }

    public string? FtpCreatedBy { get; set; }

    public int? FtpEditedBy { get; set; }

    public DateTime? FtpCreationDate { get; set; }

    public DateTime? FtpEditedDate { get; set; }

    public int? EgtIdpk { get; set; }

    public string? EgtName { get; set; }

    public string? EgtShtName { get; set; }

    public bool? EgtActive { get; set; }

    public string? EgtRmks { get; set; }

    public string? EgtCreatedBy { get; set; }

    public int? EgtEditedBy { get; set; }

    public DateTime? EgtCreationDate { get; set; }

    public DateTime? EgtEditedDate { get; set; }

    public int? CurIdpk { get; set; }

    public string? CurName { get; set; }

    public DateTime? CurDate { get; set; }

    public string? CurShtName { get; set; }

    public string? CurSymbol { get; set; }

    public bool? CurForeign { get; set; }

    public bool? CurActive { get; set; }

    public string? CurRmks { get; set; }

    public int? CurCreatedBy { get; set; }

    public int? CurEditedBy { get; set; }

    public DateTime? CurCreationDate { get; set; }

    public DateTime? CurEditedDate { get; set; }

    public int? PwtIdpk { get; set; }

    public string? PwtName { get; set; }

    public string? PwtShtName { get; set; }

    public bool? PwtActive { get; set; }

    public string? PwtRmks { get; set; }

    public int? TrtIdpk { get; set; }

    public string? TrtName { get; set; }

    public string? TrtShtName { get; set; }

    public bool? TrtActive { get; set; }

    public string? TrtRmks { get; set; }

    public int? VdtTransmissionTypeIdfk { get; set; }

    public int CtyIdpk { get; set; }

    public string CtyName { get; set; } = null!;

    public string CtyShtName { get; set; } = null!;

    public string CtyNationality { get; set; } = null!;

    public string CtyCapital { get; set; } = null!;

    public bool CtyActive { get; set; }

    public int? MftIdpk { get; set; }

    public string? MftName { get; set; }

    public string? MftShtName { get; set; }

    public bool? MftActive { get; set; }

    public string? MftRmks { get; set; }

    public DateTime VdtDvlaRegDate { get; set; }

    public int? EgmIdpk { get; set; }

    public string? EgmName { get; set; }

    public string? EgmShtName { get; set; }

    public bool? EgmActive { get; set; }

    public string? EgmRmks { get; set; }

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

    public string PmWorkshopEmail { get; set; } = null!;

    public bool PmWorkshopExternal { get; set; }

    public int VdtScheduledPmRequestIdfk { get; set; }

    public string? VehicleClassCurrency { get; set; }

    public string? VehicleClassPriceCurrency { get; set; }

    public string? VehicleClassMakePriceCurrency { get; set; }

    public string? VehicleClassMakeModelPriceCurrency { get; set; }

    public int VgpIdpk { get; set; }

    public string? VgpName { get; set; }

    public string? VgpShtName { get; set; }

    public bool? VgpCorporate { get; set; }

    public bool? VgpActive { get; set; }

    public int? VdtVehicleGroupIdfk { get; set; }

    public int? VdtOwnerEmpIdfk { get; set; }

    public int? VdtDriverEmpIdfk { get; set; }

    public int? VdtControllerEmpIdfk { get; set; }

    public int? VdtAdminEmpIdfk { get; set; }

    public int OwnerEmpId { get; set; }

    public string OwnerStaffNo { get; set; } = null!;

    public string OwnerLname { get; set; } = null!;

    public string OwnerFname { get; set; } = null!;

    public string OwnerOnames { get; set; } = null!;

    public string OwnerEmpName { get; set; } = null!;

    public string OwnerEmpName1 { get; set; } = null!;

    public string OwnerEmpName2 { get; set; } = null!;

    public string OwnerEmpName3 { get; set; } = null!;

    public string OwnerEmpName4 { get; set; } = null!;

    public string OwnerEmpName5 { get; set; } = null!;

    public string OwnerEmpName12 { get; set; } = null!;

    public string OwnerEmpName15 { get; set; } = null!;

    public int OwnerDptId { get; set; }

    public string OwnerDptName { get; set; } = null!;

    public string OwnerDptShtName { get; set; } = null!;

    public int OwnerSxnId { get; set; }

    public string OwnerSxnName { get; set; } = null!;

    public string OwnerSxnShtName { get; set; } = null!;

    public int OwnerUntId { get; set; }

    public string OwnerUntName { get; set; } = null!;

    public string OwnerUntShtName { get; set; } = null!;

    public int OwnerLocId { get; set; }

    public string OwnerLocName { get; set; } = null!;

    public string OwnerLocShtName { get; set; } = null!;

    public string OwnerMobNo { get; set; } = null!;

    public string OwnerPlc { get; set; } = null!;

    public int OwnerJbtId { get; set; }

    public string OwnerJbtName { get; set; } = null!;

    public string OwnerJbtShtName { get; set; } = null!;

    public string OwnerMobNox { get; set; } = null!;

    public int DriverEmpId { get; set; }

    public string DriverStaffNo { get; set; } = null!;

    public string DriverLname { get; set; } = null!;

    public string DriverFname { get; set; } = null!;

    public string DriverOnames { get; set; } = null!;

    public string DriverEmpName { get; set; } = null!;

    public string DriverEmpName1 { get; set; } = null!;

    public string DriverEmpName2 { get; set; } = null!;

    public string DriverEmpName3 { get; set; } = null!;

    public string DriverEmpName4 { get; set; } = null!;

    public string DriverEmpName5 { get; set; } = null!;

    public string DriverEmpName12 { get; set; } = null!;

    public string DriverEmpName15 { get; set; } = null!;

    public int DriverDptId { get; set; }

    public string DriverDptName { get; set; } = null!;

    public string DriverDptShtName { get; set; } = null!;

    public int DriverSxnId { get; set; }

    public string DriverSxnName { get; set; } = null!;

    public string DriverSxnShtName { get; set; } = null!;

    public int DriverUntId { get; set; }

    public string DriverUntName { get; set; } = null!;

    public string DriverUntShtName { get; set; } = null!;

    public int DriverLocId { get; set; }

    public string DriverLocName { get; set; } = null!;

    public string DriverLocShtName { get; set; } = null!;

    public string DriverMobNo { get; set; } = null!;

    public string DriverPlc { get; set; } = null!;

    public int DriverJbtId { get; set; }

    public string DriverJbtName { get; set; } = null!;

    public string DriverJbtShtName { get; set; } = null!;

    public string DriverMobNox { get; set; } = null!;

    public int ControllerEmpId { get; set; }

    public string ControllerStaffNo { get; set; } = null!;

    public string ControllerLname { get; set; } = null!;

    public string ControllerFname { get; set; } = null!;

    public string ControllerOnames { get; set; } = null!;

    public string ControllerEmpName { get; set; } = null!;

    public string ControllerEmpName1 { get; set; } = null!;

    public string ControllerEmpName2 { get; set; } = null!;

    public string ControllerEmpName3 { get; set; } = null!;

    public string ControllerEmpName4 { get; set; } = null!;

    public string ControllerEmpName5 { get; set; } = null!;

    public string ControllerEmpName12 { get; set; } = null!;

    public string ControllerEmpName15 { get; set; } = null!;

    public int ControllerDptId { get; set; }

    public string ControllerDptName { get; set; } = null!;

    public string ControllerDptShtName { get; set; } = null!;

    public int ControllerSxnId { get; set; }

    public string ControllerSxnName { get; set; } = null!;

    public string ControllerSxnShtName { get; set; } = null!;

    public int ControllerUntId { get; set; }

    public string ControllerUntName { get; set; } = null!;

    public string ControllerUntShtName { get; set; } = null!;

    public int ControllerLocId { get; set; }

    public string ControllerLocName { get; set; } = null!;

    public string ControllerLocShtName { get; set; } = null!;

    public string ControllerMobNo { get; set; } = null!;

    public string ControllerPlc { get; set; } = null!;

    public int ControllerJbtId { get; set; }

    public string ControllerJbtName { get; set; } = null!;

    public string ControllerJbtShtName { get; set; } = null!;

    public string ControllerMobNox { get; set; } = null!;

    public int AdminEmpId { get; set; }

    public string AdminStaffNo { get; set; } = null!;

    public string AdminLname { get; set; } = null!;

    public string AdminFname { get; set; } = null!;

    public string AdminOnames { get; set; } = null!;

    public string AdminEmpName { get; set; } = null!;

    public string AdminEmpName1 { get; set; } = null!;

    public string AdminEmpName2 { get; set; } = null!;

    public string AdminEmpName3 { get; set; } = null!;

    public string AdminEmpName4 { get; set; } = null!;

    public string AdminEmpName5 { get; set; } = null!;

    public string AdminEmpName12 { get; set; } = null!;

    public string AdminEmpName15 { get; set; } = null!;

    public int AdminDptId { get; set; }

    public string AdminDptName { get; set; } = null!;

    public string AdminDptShtName { get; set; } = null!;

    public int AdminSxnId { get; set; }

    public string AdminSxnName { get; set; } = null!;

    public string AdminSxnShtName { get; set; } = null!;

    public int AdminUntId { get; set; }

    public string AdminUntName { get; set; } = null!;

    public string AdminUntShtName { get; set; } = null!;

    public int AdminLocId { get; set; }

    public string AdminLocName { get; set; } = null!;

    public string AdminLocShtName { get; set; } = null!;

    public string AdminMobNo { get; set; } = null!;

    public string AdminPlc { get; set; } = null!;

    public int AdminJbtId { get; set; }

    public string AdminJbtName { get; set; } = null!;

    public string AdminJbtShtName { get; set; } = null!;

    public string AdminMobNox { get; set; } = null!;

    public bool VdtGeneral { get; set; }

    public bool VdtBus { get; set; }

    public bool VdtSpecialised { get; set; }

    public bool VdtMotorBike { get; set; }

    public bool VdtEquipment { get; set; }

    public decimal VdtSpeedometerLimit { get; set; }

    public int VdtSpeedometerUnitIdfk { get; set; }

    public int SpuIdpk { get; set; }

    public string SpuName { get; set; } = null!;

    public string SpuShtName { get; set; } = null!;

    public bool SpuActive { get; set; }

    public bool VdtLightDuty { get; set; }

    public bool VdtHeavyDuty { get; set; }

    public bool VdtVehicle { get; set; }

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public bool SxnActive { get; set; }

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public bool DptActive { get; set; }

    public int UntIdpk { get; set; }

    public string UntName { get; set; } = null!;

    public string UntShtName { get; set; } = null!;

    public bool UntActive { get; set; }

    public int? VdtManagerEmpIdfk { get; set; }

    public int? VdtDirectorEmpIdfk { get; set; }

    public int ManagerEmpId { get; set; }

    public string MgrStaffNo { get; set; } = null!;

    public string MgrLname { get; set; } = null!;

    public string MgrFname { get; set; } = null!;

    public string MgrOnames { get; set; } = null!;

    public string MgrEmpName { get; set; } = null!;

    public string MgrEmpName1 { get; set; } = null!;

    public string MgrEmpName2 { get; set; } = null!;

    public string MgrEmpName3 { get; set; } = null!;

    public string MgrEmpName4 { get; set; } = null!;

    public string MgrEmpName5 { get; set; } = null!;

    public string MgrEmpName12 { get; set; } = null!;

    public string MgrEmpName15 { get; set; } = null!;

    public int MgrDptId { get; set; }

    public string MgrDptName { get; set; } = null!;

    public string MgrDptShtName { get; set; } = null!;

    public int MgrSxnId { get; set; }

    public string MgrSxnName { get; set; } = null!;

    public string MgrSxnShtName { get; set; } = null!;

    public int MgrUntId { get; set; }

    public string MgrUntName { get; set; } = null!;

    public string MgrUntShtName { get; set; } = null!;

    public int MgrLocId { get; set; }

    public string MgrLocName { get; set; } = null!;

    public string MgrLocShtName { get; set; } = null!;

    public string MgrMobNo { get; set; } = null!;

    public string MgrPlc { get; set; } = null!;

    public int MgrJbtId { get; set; }

    public string MgrJbtName { get; set; } = null!;

    public string MgrJbtShtName { get; set; } = null!;

    public string MgrMobNox { get; set; } = null!;

    public int DirEmpId { get; set; }

    public string DirStaffNo { get; set; } = null!;

    public string DirLname { get; set; } = null!;

    public string DirFname { get; set; } = null!;

    public string DirOnames { get; set; } = null!;

    public string DirEmpName { get; set; } = null!;

    public string DirEmpName1 { get; set; } = null!;

    public string DirEmpName2 { get; set; } = null!;

    public string DirEmpName3 { get; set; } = null!;

    public string DirEmpName4 { get; set; } = null!;

    public string DirEmpName5 { get; set; } = null!;

    public string DirEmpName12 { get; set; } = null!;

    public string DirEmpName15 { get; set; } = null!;

    public int DirDptId { get; set; }

    public string DirDptName { get; set; } = null!;

    public string DirDptShtName { get; set; } = null!;

    public int DirSxnId { get; set; }

    public string DirSxnName { get; set; } = null!;

    public string DirSxnShtName { get; set; } = null!;

    public int DirUntId { get; set; }

    public string DirUntName { get; set; } = null!;

    public string DirUntShtName { get; set; } = null!;

    public int DirLocId { get; set; }

    public string DirLocName { get; set; } = null!;

    public string DirLocShtName { get; set; } = null!;

    public string DirMobNo { get; set; } = null!;

    public string DirPlc { get; set; } = null!;

    public int DirJbtId { get; set; }

    public string DirJbtName { get; set; } = null!;

    public string DirJbtShtName { get; set; } = null!;

    public string DirMobNox { get; set; } = null!;
}
