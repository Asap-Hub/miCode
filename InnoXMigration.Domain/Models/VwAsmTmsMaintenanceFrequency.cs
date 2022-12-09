using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsMaintenanceFrequency
{
    public int? MtfIdpk { get; set; }

    public int? MtfVehicleDetailIdfk { get; set; }

    public int MtfFrequencyDays { get; set; }

    public int MtfFrequencyKm { get; set; }

    public bool MtfActive { get; set; }

    public string MtfRmks { get; set; } = null!;

    public int VehDetailId { get; set; }

    public string VehDetailRegNo { get; set; } = null!;

    public string VehDetailChassisNo { get; set; } = null!;

    public int? MdlIdpk { get; set; }

    public string? MdlName { get; set; }

    public string? MdlShtName { get; set; }

    public int? VmkIdpk { get; set; }

    public string? VmkName { get; set; }

    public string? VmkShtName { get; set; }

    public int? VhcIdpk { get; set; }

    public string? VhcName { get; set; }

    public string? VhcShtName { get; set; }

    public int? MftIdpk { get; set; }

    public string? MftName { get; set; }

    public string? MftShtName { get; set; }

    public int MtfFirstSmsPromptDays { get; set; }

    public int MtfSecondSmsPromptDays { get; set; }

    public int MtfThirdSmsPromptDays { get; set; }

    public int MtfFourthSmsPromptDays { get; set; }

    public bool MtfPromptDriver { get; set; }

    public bool MtfPromptOwner { get; set; }

    public bool MtfPromptAdmin { get; set; }

    public bool MtfAutoReschedule { get; set; }

    public bool MtfPromptVehicleController { get; set; }

    public int MtsSmsCount { get; set; }

    public int? WsdIdpk { get; set; }

    public string? WsdName { get; set; }

    public string? WsdShtName { get; set; }

    public string? WsdCode { get; set; }

    public string? WsdContact { get; set; }

    public string? WsdTelNo { get; set; }

    public int? WsdLocIdfk { get; set; }

    public bool? WsdActive { get; set; }

    public string? WsdRmks { get; set; }

    public int? TwnIdpk { get; set; }

    public string? TwnName { get; set; }

    public string? TwnShtName { get; set; }

    public int? DstIdpk { get; set; }

    public string? DstName { get; set; }

    public string? DstShtName { get; set; }

    public int? RgnIdpk { get; set; }

    public string? RgnName { get; set; }

    public string? RgnShtName { get; set; }

    public int? CtyIdpk { get; set; }

    public string? CtyName { get; set; }

    public string? CtyShtName { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public string? WsdPlc { get; set; }

    public string? WsdAddress { get; set; }

    public int? MtfAdminEmpIdfk { get; set; }

    public int? MtfControllerEmpIdfk { get; set; }

    public int MtpIdpk { get; set; }

    public string? MtpName { get; set; }

    public string? MtpShtName { get; set; }

    public bool? MtpPreventiveMaintenance { get; set; }

    public bool? MtpRoadworthy { get; set; }

    public bool? MtpInsuranceRenewal { get; set; }

    public bool? MtpActive { get; set; }

    public string? MtpRmks { get; set; }

    public int? MtfMaintenanceTypeIdfk { get; set; }

    public int? DriverEmpId { get; set; }

    public string? DriverStaffNo { get; set; }

    public string? DriverLname { get; set; }

    public string? DriverFname { get; set; }

    public string? DriverOnames { get; set; }

    public string? DriverName { get; set; }

    public string? DriverEmpName1 { get; set; }

    public string? DriverEmpName2 { get; set; }

    public string? DriverEmpName3 { get; set; }

    public string? DriverEmpName4 { get; set; }

    public string? DriverEmpName15 { get; set; }

    public int? DriverDptId { get; set; }

    public string? DriverDptName { get; set; }

    public string? DriverDptShtName { get; set; }

    public int? DriverSxnId { get; set; }

    public string? DriverSxnName { get; set; }

    public string? DriverSxnShtName { get; set; }

    public int? DriverUntId { get; set; }

    public string? DriverUnitName { get; set; }

    public string? DriverUnitShtName { get; set; }

    public int? DriverLocId { get; set; }

    public string? DriverLocName { get; set; }

    public string? DriverLocShtName { get; set; }

    public string? DriverMobNo { get; set; }

    public string? DriverMobNox { get; set; }

    public string? DriverPlc { get; set; }

    public int? DriverJbtId { get; set; }

    public string? DriverJbtName { get; set; }

    public string? DriverJbtShtName { get; set; }

    public int? DriverRomId { get; set; }

    public string? DriverRomName { get; set; }

    public string? DriverRomShtName { get; set; }

    public int? DriverOfcId { get; set; }

    public string? DriverOfcName { get; set; }

    public string? DriverOfcShtName { get; set; }

    public bool? DriverHideMobNo { get; set; }

    public int? OwnerEmpId { get; set; }

    public string? OwnerStaffNo { get; set; }

    public string? OwnerLname { get; set; }

    public string? OwnerFname { get; set; }

    public string? OwnerOnames { get; set; }

    public string? OwnerHrmsName { get; set; }

    public string? OwnerEmpName { get; set; }

    public string? OwnerempName1 { get; set; }

    public string? OwnerEmpName2 { get; set; }

    public string? OwnerEmpName3 { get; set; }

    public string? OwnerEmpName4 { get; set; }

    public string? OwnerEmpName15 { get; set; }

    public int? OwnerDptId { get; set; }

    public string? OwnerDptName { get; set; }

    public string? OwnerDptShtName { get; set; }

    public int? OwnerSxnId { get; set; }

    public string? OwnerSxnName { get; set; }

    public string? OwnerSxnShtName { get; set; }

    public int? OwnerUntId { get; set; }

    public string? OwnerUntName { get; set; }

    public string? OwnerUntShtName { get; set; }

    public string? OwnerDirTelNo { get; set; }

    public string? OwnerMobNo { get; set; }

    public string? OwnerPlc { get; set; }

    public int? OwnerJbtId { get; set; }

    public string? OwnerJbtName { get; set; }

    public string? OwnerJbtShtName { get; set; }

    public int? OwnerOfcId { get; set; }

    public string? OwnerOfcName { get; set; }

    public string? OwnerOfcShtName { get; set; }

    public int? OwnerRomId { get; set; }

    public string? OwnerRomName { get; set; }

    public string? OwnerRomShtName { get; set; }

    public string? OwnerMobNox { get; set; }

    public bool? OwnerHideMobNo { get; set; }

    public int? AdminEmpId { get; set; }

    public string? AdminStaffNo { get; set; }

    public string? AdminLname { get; set; }

    public string? AdminFname { get; set; }

    public string? AdminOnames { get; set; }

    public string? AdminHrmsName { get; set; }

    public string? AdminEmpName { get; set; }

    public string? AdminempName1 { get; set; }

    public string? AdminEmpName2 { get; set; }

    public string? AdminEmpName3 { get; set; }

    public string? AdminEmpName4 { get; set; }

    public string? AdminEmpName15 { get; set; }

    public int? AdminDptId { get; set; }

    public string? AdminDptName { get; set; }

    public string? AdminDptShtName { get; set; }

    public int? AdminSxnId { get; set; }

    public string? AdminSxnName { get; set; }

    public string? AdminSxnShtName { get; set; }

    public int? AdminUntId { get; set; }

    public string? AdminUntName { get; set; }

    public string? AdminUntShtName { get; set; }

    public string? AdminDirTelNo { get; set; }

    public string? AdminMobNo { get; set; }

    public string? AdminPlc { get; set; }

    public int? AdminJbtId { get; set; }

    public string? AdminJbtName { get; set; }

    public string? AdminJbtShtName { get; set; }

    public int? AdminOfcId { get; set; }

    public string? AdminOfcName { get; set; }

    public string? AdminOfcShtName { get; set; }

    public int? AdminRomId { get; set; }

    public string? AdminRomName { get; set; }

    public string? AdminRomShtName { get; set; }

    public string? AdminMobNox { get; set; }

    public bool? AdminHideMobNo { get; set; }

    public int? ControllerEmpId { get; set; }

    public string? ControllerStaffNo { get; set; }

    public string? ControllerLname { get; set; }

    public string? ControllerFname { get; set; }

    public string? ControllerOnames { get; set; }

    public string? ControllerHrmsName { get; set; }

    public string? ControllerEmpName { get; set; }

    public string? ControllerempName1 { get; set; }

    public string? ControllerEmpName2 { get; set; }

    public string? ControllerEmpName3 { get; set; }

    public string? ControllerEmpName4 { get; set; }

    public string? ControllerEmpName15 { get; set; }

    public int? ControllerDptId { get; set; }

    public string? ControllerDptName { get; set; }

    public string? ControllerDptShtName { get; set; }

    public int? ControllerSxnId { get; set; }

    public string? ControllerSxnName { get; set; }

    public string? ControllerSxnShtName { get; set; }

    public int? ControllerUntId { get; set; }

    public string? ControllerUntName { get; set; }

    public string? ControllerUntShtName { get; set; }

    public string? ControllerDirTelNo { get; set; }

    public string? ControllerMobNo { get; set; }

    public string? ControllerPlc { get; set; }

    public int? ControllerJbtId { get; set; }

    public string? ControllerJbtName { get; set; }

    public string? ControllerJbtShtName { get; set; }

    public int? ControllerOfcId { get; set; }

    public string? ControllerOfcName { get; set; }

    public string? ControllerOfcShtName { get; set; }

    public int? ControllerRomId { get; set; }

    public string? ControllerRomName { get; set; }

    public string? ControllerRomShtName { get; set; }

    public string? ControllerMobNox { get; set; }

    public bool? ControllerHideMobNo { get; set; }

    public string? VdtRegNo { get; set; }

    public string? VdtChassisNo { get; set; }

    public decimal? VdtCubicCapacity { get; set; }

    public decimal? VdtTankCapacity { get; set; }

    public int? VdtIdpk { get; set; }

    public bool MtfSmsSent { get; set; }

    public DateTime? MtfStartDate { get; set; }

    public DateTime? MtfMaintenanceDate { get; set; }

    public int MtfOwnerEmpIdfk { get; set; }

    public int MtfDriverEmpIdfk { get; set; }

    public bool MtfDeleted { get; set; }

    public int MtfBatchNo { get; set; }

    public DateTime? MtfLastAlertDate { get; set; }

    public DateTime? MtfNextAlertDate { get; set; }

    public string? MtfReschedulePlan { get; set; }

    public bool MtfPromptManager { get; set; }

    public bool MtfPromptDirector { get; set; }
}
