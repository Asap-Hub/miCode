using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsVehicleLogBook
{
    public int VlbIdpk { get; set; }

    public int? VlbVehicleAssignIdfk { get; set; }

    public DateTime? VlbTimeIn { get; set; }

    public DateTime? VlbTimeOut { get; set; }

    public decimal? VlbOdometerStart { get; set; }

    public decimal? VlbOdometerEnd { get; set; }

    public decimal? DistanceTravelled { get; set; }

    public int? VlbAuthorisedByEmpIdfk { get; set; }

    public string? VlbDescription { get; set; }

    public bool? VlbCancelled { get; set; }

    public DateTime? VlbDateUpdated { get; set; }

    public bool? VlbActive { get; set; }

    public string? VlbRmks { get; set; }

    public int VasIdpk { get; set; }

    public int? VasVehicleDetailIdfk { get; set; }

    public DateTime? VasStartDate { get; set; }

    public DateTime? VasEndDate { get; set; }

    public bool? VasAssigned { get; set; }

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

    public string? VdtRegNo { get; set; }

    public DateTime? VdtManufactureDate { get; set; }

    public DateTime? VdtSupplyDate { get; set; }

    public bool? VdtAssigned { get; set; }

    public decimal? VdtPrice { get; set; }

    public string? VdtColour { get; set; }

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

    public string? VstName { get; set; }

    public string? VstShtName { get; set; }

    public bool? VstFitStatus { get; set; }

    public bool? VstActive { get; set; }

    public int? SplIdpk { get; set; }

    public string? SplName { get; set; }

    public string? SplShtName { get; set; }

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

    public decimal? SupplyAge { get; set; }

    public decimal? ManufactureAge { get; set; }

    public string? EgmShtName { get; set; }

    public string? EgmName { get; set; }

    public DateTime? VdtDvlaRegDate { get; set; }

    public int? EgmIdpk { get; set; }

    public string? CtyShtName { get; set; }

    public string? CtyName { get; set; }

    public int? CtyIdpk { get; set; }

    public string? VdtHorsePower { get; set; }

    public string? VdtEngineNo { get; set; }

    public byte? VdtNoOfWheels { get; set; }

    public byte? VdtNoOfAxles { get; set; }

    public decimal? VdtHeight { get; set; }

    public decimal? VdtWidth { get; set; }

    public decimal? VdtLength { get; set; }

    public decimal? VdtGrossWeight { get; set; }

    public decimal? VdtNetWeight { get; set; }

    public string? VdtTyreSizeRear { get; set; }

    public string? VdtTyreSizeMiddle { get; set; }

    public string? VdtTyreSizeFront { get; set; }

    public byte? VdtNoOfCylinders { get; set; }

    public decimal? VdtTankCapacity { get; set; }

    public decimal? VdtCubicCapacity { get; set; }

    public string DriverEmpName5 { get; set; } = null!;

    public string OwnerEmpName5 { get; set; } = null!;

    public int? VasOwnerEmpIdfk { get; set; }

    public string? TrtShtName { get; set; }

    public string? TrtName { get; set; }

    public int? TrtIdpk { get; set; }

    public string? PwtShtName { get; set; }

    public string? PwtName { get; set; }

    public int? PwtIdpk { get; set; }

    public bool? CurForeign { get; set; }

    public int LoggedByEmpIdfk { get; set; }

    public string LoggedByStaffNo { get; set; } = null!;

    public string LoggedByLname { get; set; } = null!;

    public string LoggedByFname { get; set; } = null!;

    public string LoggedByOnames { get; set; } = null!;

    public string LoggedByHrmsName { get; set; } = null!;

    public string LoggedByEmpName { get; set; } = null!;

    public string LoggedByEmpName1 { get; set; } = null!;

    public string LoggedByEmpName2 { get; set; } = null!;

    public string LoggedByEmpName3 { get; set; } = null!;

    public string LoggedByEmpName4 { get; set; } = null!;

    public short LoggedByGndIdfk { get; set; }

    public string LoggedByGndName { get; set; } = null!;

    public string LoggedByGndShtName { get; set; } = null!;

    public int LoggedByDptIdfk { get; set; }

    public string LoggedByDptName { get; set; } = null!;

    public string LoggedByDptShtName { get; set; } = null!;

    public int LoggedBySxnIdpk { get; set; }

    public string LoggedBySxnName { get; set; } = null!;

    public string LoggedBySxnShtName { get; set; } = null!;

    public int LoggedByUntIdfk { get; set; }

    public string LoggedByUntName { get; set; } = null!;

    public string LoggedByUntShtName { get; set; } = null!;

    public int LoggedByLocIdfk { get; set; }

    public string LoggedByLocName { get; set; } = null!;

    public string LoggedByLocShtName { get; set; } = null!;

    public string LoggedByEmpTelNo { get; set; } = null!;

    public string LoggedByEmpMobNo { get; set; } = null!;

    public string LoggedByPlc { get; set; } = null!;

    public string LoggedByEmailOff { get; set; } = null!;

    public string LoggedByEmailPers { get; set; } = null!;

    public int LoggedByJbtIdfk { get; set; }

    public string LoggedByJbtName { get; set; } = null!;

    public string LoggedByJbtShtName { get; set; } = null!;

    public bool LoggedByHideMobNo { get; set; }

    public string LoggedByMobNox { get; set; } = null!;

    public bool LoggedByIsStaff { get; set; }

    public bool LoggedByIsSeniorStaff { get; set; }

    public bool LoggedByIsJuniorStaff { get; set; }

    public bool LoggedByIsManagementStaff { get; set; }

    public bool LoggedByIsServicePerson { get; set; }

    public bool LoggedByIsVoluntaryPerson { get; set; }

    public int AuthorisedByEmpIdfk { get; set; }

    public string AuthorisedByStaffNo { get; set; } = null!;

    public string AuthorisedByLname { get; set; } = null!;

    public string AuthorisedByFname { get; set; } = null!;

    public string AuthorisedByOnames { get; set; } = null!;

    public string AuthorisedByHrmsName { get; set; } = null!;

    public string AuthorisedByEmpName { get; set; } = null!;

    public string AuthorisedByEmpName1 { get; set; } = null!;

    public string AuthorisedByEmpName2 { get; set; } = null!;

    public string AuthorisedByEmpName3 { get; set; } = null!;

    public string AuthorisedByEmpName4 { get; set; } = null!;

    public short? AuthorisedByGndIdfk { get; set; }

    public string? AuthorisedByGndName { get; set; }

    public string? AuthorisedByGndShtName { get; set; }

    public int? AuthorisedByDptIdfk { get; set; }

    public string? AuthorisedByDptName { get; set; }

    public string? AuthorisedByDptShtName { get; set; }

    public int? AuthorisedBySxnIdpk { get; set; }

    public string? AuthorisedBySxnName { get; set; }

    public string? AuthorisedBySxnShtName { get; set; }

    public int? AuthorisedByUntIdfk { get; set; }

    public string? AuthorisedByUntName { get; set; }

    public string? AuthorisedByUntShtName { get; set; }

    public int? AuthorisedByLocIdfk { get; set; }

    public string? AuthorisedByLocName { get; set; }

    public string? AuthorisedByLocShtName { get; set; }

    public string? AuthorisedByEmpTelNo { get; set; }

    public string? AuthorisedByEmpMobNo { get; set; }

    public string? AuthorisedByPlc { get; set; }

    public string? AuthorisedByEmailOff { get; set; }

    public string? AuthorisedByEmailPers { get; set; }

    public int? AuthorisedByJbtIdfk { get; set; }

    public string? AuthorisedByJbtName { get; set; }

    public string? AuthorisedByJbtShtName { get; set; }

    public bool? AuthorisedByHideMobNo { get; set; }

    public string? AuthorisedByMobNox { get; set; }

    public bool? AuthorisedByIsStaff { get; set; }

    public bool? AuthorisedByIsSeniorStaff { get; set; }

    public bool? AuthorisedByIsJuniorStaff { get; set; }

    public bool? AuthorisedByIsManagementStaff { get; set; }

    public bool? AuthorisedByIsServicePerson { get; set; }

    public bool? AuthorisedByIsVoluntaryPerson { get; set; }

    public bool VlbAuthorised { get; set; }

    public string VlbFromRegion { get; set; } = null!;

    public string VlbFromTown { get; set; } = null!;

    public string VlbToRegion { get; set; } = null!;

    public string VlbToTown { get; set; } = null!;

    public int? VdtIdpk { get; set; }

    public int? VlbFromRegionIdfk { get; set; }

    public int? VlbToRegionIdfk { get; set; }

    public int FromRegionId { get; set; }

    public string FromRegionName { get; set; } = null!;

    public string FromRegionShtName { get; set; } = null!;

    public int FromCountryId { get; set; }

    public string FromCountryName { get; set; } = null!;

    public string FromCountryShtName { get; set; } = null!;

    public string FromCountryNationality { get; set; } = null!;

    public bool FromCountryDefault { get; set; }

    public bool FromCountryShowInTransport { get; set; }

    public string FromCountryCapital { get; set; } = null!;

    public string FromRegionCapital { get; set; } = null!;

    public int ToRegionId { get; set; }

    public string ToRegionName { get; set; } = null!;

    public string ToRegionShtName { get; set; } = null!;

    public int ToCountryId { get; set; }

    public string ToCountryName { get; set; } = null!;

    public string ToCountryShtName { get; set; } = null!;

    public string ToRegionCapital { get; set; } = null!;

    public string ToCountryCapital { get; set; } = null!;

    public bool ToCountryDefault { get; set; }

    public bool ToCountryShowInTransport { get; set; }

    public int StartFuelLevelId { get; set; }

    public string StartFuelLevelName { get; set; } = null!;

    public string StartFuelLevelShtName { get; set; } = null!;

    public decimal StartFuelLevelOrder { get; set; }

    public int FinalFuelLevelId { get; set; }

    public string FinalFuelLevelName { get; set; } = null!;

    public string FinalFuelLevelShtName { get; set; } = null!;

    public decimal FinalFuelLevelOrder { get; set; }
}
