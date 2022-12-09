using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsVehicleAssignment
{
    public int VasIdpk { get; set; }

    public int? VasVehicleDetailIdfk { get; set; }

    public DateTime? VasStartDate { get; set; }

    public DateTime? VasEndDate { get; set; }

    public int? VasDeptIdfk { get; set; }

    public int? VasSectionIdfk { get; set; }

    public int? VasUnitIdfk { get; set; }

    public int? VasDriverEmpIdfk { get; set; }

    public bool? VasAssigned { get; set; }

    public bool VasActive { get; set; }

    public string VasRmks { get; set; } = null!;

    public int? VasCreatedBy { get; set; }

    public int? VasEditedBy { get; set; }

    public DateTime? VasCreationDate { get; set; }

    public DateTime? VasEditedDate { get; set; }

    public int? VdtIdpk { get; set; }

    public string? VdtChassisNo { get; set; }

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public string DptCode { get; set; } = null!;

    public int EmpIdpk { get; set; }

    public string EmpStaffNo { get; set; } = null!;

    public string EmpLastName { get; set; } = null!;

    public string EmpName { get; set; } = null!;

    public string EmpName1 { get; set; } = null!;

    public string EmpFirstName { get; set; } = null!;

    public string EmpOthernames { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int SxnDeptIdfk { get; set; }

    public string SxnCode { get; set; } = null!;

    public int UntIdpk { get; set; }

    public string UntName { get; set; } = null!;

    public string UntShtName { get; set; } = null!;

    public int UntSectionIdfk { get; set; }

    public string UntCode { get; set; } = null!;

    public string? VdtRegNo { get; set; }

    public DateTime? VdtManufactureDate { get; set; }

    public DateTime? VdtSupplyDate { get; set; }

    public bool? VdtAssigned { get; set; }

    public decimal? VdtPrice { get; set; }

    public string? VdtColour { get; set; }

    public byte? VdtSeatingCapacity { get; set; }

    public bool? VdtActive { get; set; }

    public string? VdtRmks { get; set; }

    public int? MdlIdpk { get; set; }

    public string? MdlName { get; set; }

    public string? MdlShtName { get; set; }

    public int? VmkIdpk { get; set; }

    public string? VmkName { get; set; }

    public string? VmkShtName { get; set; }

    public bool? VmkActive { get; set; }

    public int? VhcIdpk { get; set; }

    public string? VhcName { get; set; }

    public string? VhcShtName { get; set; }

    public bool? VhcActive { get; set; }

    public int? MftIdpk { get; set; }

    public string? MftName { get; set; }

    public string? MftShtName { get; set; }

    public bool? MftActive { get; set; }

    public int? VstIdpk { get; set; }

    public string? VstName { get; set; }

    public string? VstShtName { get; set; }

    public bool? VstFitStatus { get; set; }

    public bool? VstActive { get; set; }

    public int? SplIdpk { get; set; }

    public string? SplName { get; set; }

    public string? SplShtName { get; set; }

    public string? SplMainContact { get; set; }

    public string? SplMobNos { get; set; }

    public string? SplEmail { get; set; }

    public string? SplTelNos { get; set; }

    public int? FtpIdpk { get; set; }

    public string? FtpName { get; set; }

    public string? FtpShtName { get; set; }

    public bool? FtpActive { get; set; }

    public int? EgtIdpk { get; set; }

    public string? EgtName { get; set; }

    public string? EgtShtName { get; set; }

    public bool? EgtActive { get; set; }

    public int? CurIdpk { get; set; }

    public string? CurName { get; set; }

    public DateTime? CurDate { get; set; }

    public string? CurShtName { get; set; }

    public string? CurSymbol { get; set; }

    public int DriverEmpIdfk { get; set; }

    public string DriverStaffNo { get; set; } = null!;

    public string DriverLname { get; set; } = null!;

    public string DriverFname { get; set; } = null!;

    public string DriverOnames { get; set; } = null!;

    public string DriverHrmsName { get; set; } = null!;

    public string DriverEmpName { get; set; } = null!;

    public string DriverEmpName1 { get; set; } = null!;

    public string DriverEmpName2 { get; set; } = null!;

    public string DriverEmpName3 { get; set; } = null!;

    public string DriverEmpName4 { get; set; } = null!;

    public string DriverEmpName5 { get; set; } = null!;

    public short? DriverGndIdfk { get; set; }

    public string? DriverGndName { get; set; }

    public string? DriverGndShtName { get; set; }

    public int? DriverDptIdfk { get; set; }

    public string? DriverDptName { get; set; }

    public string? DriverDptShtName { get; set; }

    public int? DriverSxnIdfk { get; set; }

    public string? DriverSxnName { get; set; }

    public string? DriverSxnShtName { get; set; }

    public int? DriverUntIdfk { get; set; }

    public string? DriverUntName { get; set; }

    public string? DriverUntShtName { get; set; }

    public int? DriverLocIdfk { get; set; }

    public string? DriverLocName { get; set; }

    public string? DriverLocShtName { get; set; }

    public string? DriverEmpTelNo { get; set; }

    public string? DriverEmpMobNo { get; set; }

    public string? DriverPlc { get; set; }

    public string? DriverEmailOff { get; set; }

    public string? DriverEmailPers { get; set; }

    public int? DriverJbtIdfk { get; set; }

    public string? DriverJbtName { get; set; }

    public string? DriverJbtShtName { get; set; }

    public bool? DriverHideMobNo { get; set; }

    public string? DriverMobNox { get; set; }

    public bool? DriverIsStaff { get; set; }

    public bool? DriverIsSeniorStaff { get; set; }

    public bool? DriverIsJuniorStaff { get; set; }

    public bool? DriverIsManagementStaff { get; set; }

    public bool? DriverIsServicePerson { get; set; }

    public bool? DriverIsVoluntaryPerson { get; set; }

    public int OwnerEmpIdfk { get; set; }

    public string OwnerStaffNo { get; set; } = null!;

    public string OwnerLname { get; set; } = null!;

    public string OwnerFname { get; set; } = null!;

    public string OwnerHrmsName { get; set; } = null!;

    public string OwnerEmpName { get; set; } = null!;

    public string OwnerEmpName1 { get; set; } = null!;

    public string OwnerEmpName2 { get; set; } = null!;

    public string OwnerEmpName3 { get; set; } = null!;

    public string OwnerEmpName4 { get; set; } = null!;

    public string OwnerEmpName5 { get; set; } = null!;

    public int? OwnerDptIdfk { get; set; }

    public string? OwnerDptName { get; set; }

    public string? OwnerDptShtName { get; set; }

    public int? OwnerSxnIdfk { get; set; }

    public string? OwnerSxnName { get; set; }

    public string? OwnerSxnShtName { get; set; }

    public int? OwnerUntIdfk { get; set; }

    public string? OwnerUntName { get; set; }

    public string? OwnerUntShtName { get; set; }

    public int? OwnerLocIdfk { get; set; }

    public string? OwnerLocName { get; set; }

    public string? OwnerLocShtName { get; set; }

    public string? OwnerTelNo { get; set; }

    public string? OwnerMobNo { get; set; }

    public string? OwnerPlc { get; set; }

    public string? OwnerEmailOff { get; set; }

    public string? OwnerEmailPers { get; set; }

    public int? OwnerJbtIdfk { get; set; }

    public string? OwnerJbtName { get; set; }

    public string? OwnerJbtShtName { get; set; }

    public int? OwnerOfcIdfk { get; set; }

    public string? OwnerOfcName { get; set; }

    public string? OwnerOfcShtName { get; set; }

    public int? OwnerRomIdfk { get; set; }

    public string? OwnerRomName { get; set; }

    public string? OwnerRomShtName { get; set; }

    public bool? OwnerIsDirector { get; set; }

    public bool? OwnerIsManager { get; set; }

    public bool? OwnerIsSupervisor { get; set; }

    public bool? OwnerIsStaff { get; set; }

    public bool? OwnerIsSeniorStaff { get; set; }

    public bool? OwnerIsJuniorStaff { get; set; }

    public bool? OwnerIsManagementStaff { get; set; }

    public bool? OwnerIsServicePerson { get; set; }

    public bool? OwnerIsVoluntaryPerson { get; set; }

    public string? OwnerMobNox { get; set; }

    public bool? OwnerHideMobNo { get; set; }

    public int AdminEmpIdfk { get; set; }

    public string AdminStaffNo { get; set; } = null!;

    public string AdminLname { get; set; } = null!;

    public string AdminFname { get; set; } = null!;

    public string AdminHrmsName { get; set; } = null!;

    public string AdminEmpName { get; set; } = null!;

    public string AdminEmpName1 { get; set; } = null!;

    public string AdminEmpName2 { get; set; } = null!;

    public string AdminEmpName3 { get; set; } = null!;

    public string AdminEmpName4 { get; set; } = null!;

    public string AdminEmpName5 { get; set; } = null!;

    public int? AdminDptIdfk { get; set; }

    public string? AdminDptName { get; set; }

    public string? AdminDptShtName { get; set; }

    public int? AdminSxnIdfk { get; set; }

    public string? AdminSxnName { get; set; }

    public string? AdminSxnShtName { get; set; }

    public int? AdminUntIdfk { get; set; }

    public string? AdminUntName { get; set; }

    public string? AdminUntShtName { get; set; }

    public int? AdminLocIdfk { get; set; }

    public string? AdminLocName { get; set; }

    public string? AdminLocShtName { get; set; }

    public string? AdminTelNo { get; set; }

    public string? AdminMobNo { get; set; }

    public string? AdminPlc { get; set; }

    public string? AdminEmailOff { get; set; }

    public string? AdminEmailPers { get; set; }

    public int? AdminJbtIdfk { get; set; }

    public string? AdminJbtName { get; set; }

    public string? AdminJbtShtName { get; set; }

    public int? AdminOfcIdfk { get; set; }

    public string? AdminOfcName { get; set; }

    public string? AdminOfcShtName { get; set; }

    public int? AdminRomIdfk { get; set; }

    public string? AdminRomName { get; set; }

    public string? AdminRomShtName { get; set; }

    public bool? AdminIsDirector { get; set; }

    public bool? AdminIsManager { get; set; }

    public bool? AdminIsSupervisor { get; set; }

    public bool? AdminIsStaff { get; set; }

    public bool? AdminIsSeniorStaff { get; set; }

    public bool? AdminIsJuniorStaff { get; set; }

    public bool? AdminIsManagementStaff { get; set; }

    public bool? AdminIsServicePerson { get; set; }

    public bool? AdminIsVoluntaryPerson { get; set; }

    public string? AdminMobNox { get; set; }

    public bool? AdminHideMobNo { get; set; }

    public int ControllerEmpIdfk { get; set; }

    public string ControllerStaffNo { get; set; } = null!;

    public string ControllerLname { get; set; } = null!;

    public string ControllerFname { get; set; } = null!;

    public string ControllerHrmsName { get; set; } = null!;

    public string ControllerEmpName { get; set; } = null!;

    public string ControllerEmpName1 { get; set; } = null!;

    public string ControllerEmpName2 { get; set; } = null!;

    public string ControllerEmpName3 { get; set; } = null!;

    public string ControllerEmpName4 { get; set; } = null!;

    public string ControllerEmpName5 { get; set; } = null!;

    public int? ControllerDptIdfk { get; set; }

    public string? ControllerDptName { get; set; }

    public string? ControllerDptShtName { get; set; }

    public int? ControllerSxnIdfk { get; set; }

    public string? ControllerSxnName { get; set; }

    public string? ControllerSxnShtName { get; set; }

    public int? ControllerUntIdfk { get; set; }

    public string? ControllerUntName { get; set; }

    public string? ControllerUntShtName { get; set; }

    public int? ControllerLocIdfk { get; set; }

    public string? ControllerLocName { get; set; }

    public string? ControllerLocShtName { get; set; }

    public string? ControllerTelNo { get; set; }

    public string? ControllerMobNo { get; set; }

    public string? ControllerPlc { get; set; }

    public string? ControllerEmailOff { get; set; }

    public string? ControllerEmailPers { get; set; }

    public int? ControllerJbtIdfk { get; set; }

    public string? ControllerJbtName { get; set; }

    public string? ControllerJbtShtName { get; set; }

    public int? ControllerOfcIdfk { get; set; }

    public string? ControllerOfcName { get; set; }

    public string? ControllerOfcShtName { get; set; }

    public int? ControllerRomIdfk { get; set; }

    public string? ControllerRomName { get; set; }

    public string? ControllerRomShtName { get; set; }

    public bool? ControllerIsDirector { get; set; }

    public bool? ControllerIsManager { get; set; }

    public bool? ControllerIsSupervisor { get; set; }

    public bool? ControllerIsStaff { get; set; }

    public bool? ControllerIsSeniorStaff { get; set; }

    public bool? ControllerIsJuniorStaff { get; set; }

    public bool? ControllerIsManagementStaff { get; set; }

    public bool? ControllerIsServicePerson { get; set; }

    public bool? ControllerIsVoluntaryPerson { get; set; }

    public string? ControllerMobNox { get; set; }

    public bool? ControllerHideMobNo { get; set; }

    public int MgrEmpIdfk { get; set; }

    public string MgrStaffNo { get; set; } = null!;

    public string MgrLname { get; set; } = null!;

    public string MgrFname { get; set; } = null!;

    public string MgrHrmsName { get; set; } = null!;

    public string MgrEmpName { get; set; } = null!;

    public string MgrEmpName1 { get; set; } = null!;

    public string MgrEmpName2 { get; set; } = null!;

    public string MgrEmpName3 { get; set; } = null!;

    public string MgrEmpName4 { get; set; } = null!;

    public string MgrEmpName5 { get; set; } = null!;

    public int? MgrDptIdfk { get; set; }

    public string? MgrDptName { get; set; }

    public string? MgrDptShtName { get; set; }

    public int? MgrSxnIdfk { get; set; }

    public string? MgrSxnName { get; set; }

    public string? MgrSxnShtName { get; set; }

    public int? MgrUntIdfk { get; set; }

    public string? MgrUntName { get; set; }

    public string? MgrUntShtName { get; set; }

    public int? MgrLocIdfk { get; set; }

    public string? MgrLocName { get; set; }

    public string? MgrLocShtName { get; set; }

    public string? MgrTelNo { get; set; }

    public string? MgrMobNo { get; set; }

    public string? MgrPlc { get; set; }

    public string? MgrEmailOff { get; set; }

    public string? MgrEmailPers { get; set; }

    public int? MgrJbtIdfk { get; set; }

    public string? MgrJbtName { get; set; }

    public string? MgrJbtShtName { get; set; }

    public int? MgrOfcIdfk { get; set; }

    public string? MgrOfcName { get; set; }

    public string? MgrOfcShtName { get; set; }

    public int? MgrRomIdfk { get; set; }

    public string? MgrRomName { get; set; }

    public string? MgrRomShtName { get; set; }

    public bool? MgrIsDirector { get; set; }

    public bool? MgrIsManager { get; set; }

    public bool? MgrIsSupervisor { get; set; }

    public bool? MgrIsStaff { get; set; }

    public bool? MgrIsSeniorStaff { get; set; }

    public bool? MgrIsJuniorStaff { get; set; }

    public bool? MgrIsManagementStaff { get; set; }

    public bool? MgrIsServicePerson { get; set; }

    public bool? MgrIsVoluntaryPerson { get; set; }

    public string? MgrMobNox { get; set; }

    public bool? MgrHideMobNo { get; set; }

    public int DirEmpIdfk { get; set; }

    public string DirStaffNo { get; set; } = null!;

    public string DirLname { get; set; } = null!;

    public string DirFname { get; set; } = null!;

    public string DirHrmsName { get; set; } = null!;

    public string DirEmpName { get; set; } = null!;

    public string DirEmpName1 { get; set; } = null!;

    public string DirEmpName2 { get; set; } = null!;

    public string DirEmpName3 { get; set; } = null!;

    public string DirEmpName4 { get; set; } = null!;

    public string DirEmpName5 { get; set; } = null!;

    public int? DirDptIdfk { get; set; }

    public string? DirDptName { get; set; }

    public string? DirDptShtName { get; set; }

    public int? DirSxnIdfk { get; set; }

    public string? DirSxnName { get; set; }

    public string? DirSxnShtName { get; set; }

    public int? DirUntIdfk { get; set; }

    public string? DirUntName { get; set; }

    public string? DirUntShtName { get; set; }

    public int? DirLocIdfk { get; set; }

    public string? DirLocName { get; set; }

    public string? DirLocShtName { get; set; }

    public string? DirTelNo { get; set; }

    public string? DirMobNo { get; set; }

    public string? DirPlc { get; set; }

    public string? DirEmailOff { get; set; }

    public string? DirEmailPers { get; set; }

    public int? DirJbtIdfk { get; set; }

    public string? DirJbtName { get; set; }

    public string? DirJbtShtName { get; set; }

    public int? DirOfcIdfk { get; set; }

    public string? DirOfcName { get; set; }

    public string? DirOfcShtName { get; set; }

    public int? DirRomIdfk { get; set; }

    public string? DirRomName { get; set; }

    public string? DirRomShtName { get; set; }

    public bool? DirIsDirector { get; set; }

    public bool? DirIsManager { get; set; }

    public bool? DirIsSupervisor { get; set; }

    public bool? DirIsStaff { get; set; }

    public bool? DirIsSeniorStaff { get; set; }

    public bool? DirIsJuniorStaff { get; set; }

    public bool? DirIsManagementStaff { get; set; }

    public bool? DirIsServicePerson { get; set; }

    public bool? DirIsVoluntaryPerson { get; set; }

    public string? DirMobNox { get; set; }

    public bool? DirHideMobNo { get; set; }

    public bool? CurForeign { get; set; }

    public int? PwtIdpk { get; set; }

    public string? PwtName { get; set; }

    public string? PwtShtName { get; set; }

    public int? TrtIdpk { get; set; }

    public string? TrtName { get; set; }

    public string? TrtShtName { get; set; }

    public int? VasOwnerEmpIdfk { get; set; }

    public decimal? VdtCubicCapacity { get; set; }

    public decimal? VdtTankCapacity { get; set; }

    public byte? VdtNoOfCylinders { get; set; }

    public string? VdtTyreSizeFront { get; set; }

    public string? VdtTyreSizeMiddle { get; set; }

    public string? VdtTyreSizeRear { get; set; }

    public decimal? VdtNetWeight { get; set; }

    public decimal? VdtGrossWeight { get; set; }

    public decimal? VdtLength { get; set; }

    public decimal? VdtWidth { get; set; }

    public decimal? VdtHeight { get; set; }

    public byte? VdtNoOfAxles { get; set; }

    public byte? VdtNoOfWheels { get; set; }

    public string? VdtEngineNo { get; set; }

    public string? VdtHorsePower { get; set; }

    public int? CtyIdpk { get; set; }

    public string? CtyName { get; set; }

    public string? CtyShtName { get; set; }

    public int? EgmIdpk { get; set; }

    public DateTime? VdtDvlaRegDate { get; set; }

    public string? EgmName { get; set; }

    public string? EgmShtName { get; set; }

    public decimal? ManufactureAge { get; set; }

    public decimal? SupplyAge { get; set; }

    public int? VasDefaultWorkshopIdfk { get; set; }

    public int WsdIdpk { get; set; }

    public string WsdName { get; set; } = null!;

    public string WsdShtName { get; set; } = null!;

    public string WsdCode { get; set; } = null!;

    public string WsdContact { get; set; } = null!;

    public string WsdTelNo { get; set; } = null!;

    public int TwnIdpk { get; set; }

    public string TwnName { get; set; } = null!;

    public string TwnShtName { get; set; } = null!;

    public int DstIdpk { get; set; }

    public string DstName { get; set; } = null!;

    public string DstShtName { get; set; } = null!;

    public int RgnIdpk { get; set; }

    public string RgnName { get; set; } = null!;

    public string RgnShtName { get; set; } = null!;

    public string CtyNationality { get; set; } = null!;

    public string WsdPlc { get; set; } = null!;

    public string WsdAddress { get; set; } = null!;

    public string WsdEmail { get; set; } = null!;

    public DateTime? VdtLastPmDate { get; set; }

    public DateTime? VdtNextPmDate { get; set; }

    public DateTime? VdtScheduledPmDate { get; set; }

    public int? VdtDaysToPm { get; set; }

    public DateTime? VdtLastRoadworthRenewalDate { get; set; }

    public DateTime? VdtNextRoadworthyRenewalDate { get; set; }

    public int? VdtDaysToRoadworthyRenewal { get; set; }

    public DateTime? VdtLastInsuranceRenewalDate { get; set; }

    public DateTime? VdtNextInsuranceRenewalDate { get; set; }

    public int? VdtDaysToInsuranceRenewal { get; set; }

    public bool? VdtPmScheduled { get; set; }

    public int? VdtNextPmKm { get; set; }

    public int? PmWorkshopId { get; set; }

    public string? PmWorkshopName { get; set; }

    public string? PmWorkshopShtName { get; set; }

    public string? PmWorkshopCode { get; set; }

    public string? PmWorkshopContact { get; set; }

    public string? PmWorkshopTelNo { get; set; }

    public string? PmWorkshopPlc { get; set; }

    public string? PmWorkshopAddress { get; set; }

    public string? PmWorkshopEmail { get; set; }

    public bool? PmWorkshopExternal { get; set; }

    public int? VdtScheduledPmRequestIdfk { get; set; }

    public int? VasTransportUnitIdfk { get; set; }

    public int? TruIdpk { get; set; }

    public string? TruName { get; set; }

    public string? TruShtName { get; set; }

    public int? TruDeptIdfk { get; set; }

    public int? TruSectionIdfk { get; set; }

    public int? TruUnitIdfk { get; set; }

    public bool? TruActive { get; set; }

    public int? VasVehicleControllerEmpIdfk { get; set; }

    public int? VasAdminEmpIdfk { get; set; }

    public string AdminEmpName15 { get; set; } = null!;

    public string DriverEmpName15 { get; set; } = null!;

    public string OwnerEmpName15 { get; set; } = null!;

    public string ControllerEmpName15 { get; set; } = null!;

    public string DirEmpName15 { get; set; } = null!;

    public string MgrEmpName15 { get; set; } = null!;

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public bool? LocActive { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public bool? AreActive { get; set; }

    public bool VasDeleted { get; set; }
}
