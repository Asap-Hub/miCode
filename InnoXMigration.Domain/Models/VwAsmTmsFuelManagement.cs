using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsFuelManagement
{
    public int FmgIdpk { get; set; }

    public int? FmgVehicleDetailIdfk { get; set; }

    public DateTime? FmgDate { get; set; }

    public int? FmgDriverIdfk { get; set; }

    public int? FmgServiceProviderIdfk { get; set; }

    public int? FmgServiceStationIdfk { get; set; }

    public int? FmgProductIdfk { get; set; }

    public int? FmgCardIdfk { get; set; }

    public decimal? FmgAmount { get; set; }

    public decimal? FmgBalance { get; set; }

    public decimal FmgQuantityRequested { get; set; }

    public decimal FmgQuantityDispensed { get; set; }

    public decimal FmgCurrentOdometerReading { get; set; }

    public decimal FmgPreviousOdometerReading { get; set; }

    public bool FmgDeleted { get; set; }

    public bool FmgActive { get; set; }

    public string FmgRmks { get; set; } = null!;

    public int CdtIdpk { get; set; }

    public string CdtCardNo { get; set; } = null!;

    public int CdtServiceProviderIdfk { get; set; }

    public int CdtTownIdfk { get; set; }

    public bool CdtActive { get; set; }

    public string CdtRmks { get; set; } = null!;

    public int? CardSpdId { get; set; }

    public string? CardSpdName { get; set; }

    public string? CardSpdShtName { get; set; }

    public string? CardSpdMainContact { get; set; }

    public string? CardSpdMobNos { get; set; }

    public string? CardSpdEmail { get; set; }

    public string? CardSpdTelNos { get; set; }

    public string? CardSpdPostalAddress { get; set; }

    public string? TwnName { get; set; }

    public string? TwnShtName { get; set; }

    public string? DstName { get; set; }

    public int? DstIdpk { get; set; }

    public string? DstShtName { get; set; }

    public int? RgnIdpk { get; set; }

    public string? RgnName { get; set; }

    public string? RgnShtName { get; set; }

    public int? VdtIdpk { get; set; }

    public string? VdtRegNo { get; set; }

    public string? VdtChassisNo { get; set; }

    public int? VdtModelIdfk { get; set; }

    public int? VdtSupplierIdfk { get; set; }

    public int? VdtStatusIdfk { get; set; }

    public DateTime? VdtManufactureDate { get; set; }

    public DateTime? VdtSupplyDate { get; set; }

    public bool? VdtAssigned { get; set; }

    public decimal? VdtPrice { get; set; }

    public int? VdtPriceCurrencyIdfk { get; set; }

    public int? VdtEngineTypeIdfk { get; set; }

    public int? VdtPowerTrainIdfk { get; set; }

    public int? VdtFuelTypeIdfk { get; set; }

    public string? VdtColour { get; set; }

    public byte? VdtSeatingCapacity { get; set; }

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

    public int? DriverEmpId { get; set; }

    public string? DriverStaffNo { get; set; }

    public string? DriverLname { get; set; }

    public string? DriverFname { get; set; }

    public string? DriverOnames { get; set; }

    public string? DriverHrmsName { get; set; }

    public string? DriverName { get; set; }

    public string? DriverName12 { get; set; }

    public string? DriverName1 { get; set; }

    public string? DriverName2 { get; set; }

    public string? DriverMobNox { get; set; }

    public string? DriverMobNo { get; set; }

    public bool? DriverHideMobNo { get; set; }

    public bool? DriverIsDirector { get; set; }

    public bool? DriverIsManager { get; set; }

    public bool? DriverIsSupervisor { get; set; }

    public bool? DriverIsStaff { get; set; }

    public bool? DriverIsSeniorStaff { get; set; }

    public bool? DriverIsJuniorStaff { get; set; }

    public bool? DriverIsManagementStaff { get; set; }

    public bool? DriverIsServicePerson { get; set; }

    public bool? DriverIsVoluntaryPerson { get; set; }

    public bool? DriverShowInTelDir { get; set; }

    public int? MftIdpk { get; set; }

    public string? MftName { get; set; }

    public string? MftShtName { get; set; }

    public int? VstIdpk { get; set; }

    public string? VstName { get; set; }

    public string? VstShtName { get; set; }

    public int? PwtIdpk { get; set; }

    public string? PwtName { get; set; }

    public string? PwtShtName { get; set; }

    public int? SplIdpk { get; set; }

    public string? SplName { get; set; }

    public string? SplShtName { get; set; }

    public int? FtpIdpk { get; set; }

    public string? FtpName { get; set; }

    public string? FtpShtName { get; set; }

    public int? EgtIdpk { get; set; }

    public string? EgtName { get; set; }

    public string? EgtShtName { get; set; }

    public int DriverDptIdpk { get; set; }

    public string DriverDptName { get; set; } = null!;

    public string DriverDptShtName { get; set; } = null!;

    public int DriverSxnIdpk { get; set; }

    public string DriverSxnName { get; set; } = null!;

    public string DriverSxnShtName { get; set; } = null!;

    public int? UntIdpk { get; set; }

    public string? UntName { get; set; }

    public string? UntShtName { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public string? EmpTelNo { get; set; }

    public string? EmpMobNo { get; set; }

    public string? EmpIntercom { get; set; }

    public string? EmpOfficialEmail { get; set; }

    public string? EmpPersonalEmail { get; set; }

    public int? JbtIdpk { get; set; }

    public string? JbtName { get; set; }

    public string? JbtShtName { get; set; }

    public bool? VstFitStatus { get; set; }

    public string? FmgReceiptNo { get; set; }

    public int? FmgCreatedBy { get; set; }

    public DateTime? FmgCreationDate { get; set; }

    public DateTime? FmgEditedDate { get; set; }

    public bool FmgLocked { get; set; }

    public int? FmgLockedByEmpIdfk { get; set; }

    public DateTime? FmgLockDate { get; set; }

    public int? SstIdpk { get; set; }

    public string? SstName { get; set; }

    public string? SstShtName { get; set; }

    public string? SstStationNo { get; set; }

    public int? SstServiceProviderIdfk { get; set; }

    public int? SstTownIdfk { get; set; }

    public bool? SstActive { get; set; }

    public string? SstRmks { get; set; }

    public string? SstCreatedBy { get; set; }

    public int? SstEditedBy { get; set; }

    public int? TwnIdpk { get; set; }

    public int? SpdIdpk { get; set; }

    public string? SpdName { get; set; }

    public string? SpdShtName { get; set; }

    public string? SpdMainContact { get; set; }

    public string? SpdMobNos { get; set; }

    public string? SpdEmail { get; set; }

    public string? SpdTelNos { get; set; }

    public string? SpdPostalAddress { get; set; }

    public string? SpdResidentialAddress { get; set; }

    public bool? SpdActive { get; set; }

    public string? SstMainContacts { get; set; }

    public string? SstTelNos { get; set; }

    public string? SsteMails { get; set; }

    public bool FmgVerified { get; set; }

    public int? FmgPurchaseModeIdfk { get; set; }

    public int PcmIdpk { get; set; }

    public string PcmName { get; set; } = null!;

    public string PcmShtName { get; set; } = null!;

    public bool PcmActive { get; set; }

    public string PcmRmks { get; set; } = null!;

    public int? FmgVehicleAssignmentIdfk { get; set; }

    public int VehAssignIdpk { get; set; }

    public DateTime? VasStartDate { get; set; }

    public DateTime? VasEndDate { get; set; }

    public int VehAssignDeptId { get; set; }

    public int VehAssignSectionId { get; set; }

    public int VehAssignUnitId { get; set; }

    public int VehAssignDriverEmpId { get; set; }

    public bool VehAssignAssigned { get; set; }

    public bool VehAssignActive { get; set; }

    public string VehAssignRmks { get; set; } = null!;

    public string VehAssignDeptName { get; set; } = null!;

    public string VehAssignDeptShtName { get; set; } = null!;

    public int VehAssignSxnId { get; set; }

    public string VehAssignSxnName { get; set; } = null!;

    public string VehAssignSxnShtName { get; set; } = null!;

    public string VehAssignUnitName { get; set; } = null!;

    public string VehAssignUnitShtName { get; set; } = null!;

    public string VehAssignUnitCode { get; set; } = null!;

    public int? FmgAuthoriserEmpIdfk { get; set; }

    public int? AuthoriserEmpId { get; set; }

    public string? AuthoriserStaffNo { get; set; }

    public string? AuthoriserLname { get; set; }

    public string? AuthoriserFname { get; set; }

    public string? AuthoriserOnames { get; set; }

    public string? AuthoriserHrmsName { get; set; }

    public string? AuthoriserEmpName { get; set; }

    public string? AuthoriserEmpName1 { get; set; }

    public string? AuthoriserEmpName2 { get; set; }

    public string? AuthoriserEmpName12 { get; set; }

    public string? AuthoriserMobNox { get; set; }

    public string? AuthoriserMobNo { get; set; }

    public bool? AuthoriserHideMobNo { get; set; }

    public string? AuthoriserPlc { get; set; }

    public bool? AuthoriserIsDirector { get; set; }

    public bool? AuthoriserIsManager { get; set; }

    public bool? AuthoriserIsSupervisor { get; set; }

    public bool? AuthoriserIsStaff { get; set; }

    public bool? AuthoriserIsSeniorStaff { get; set; }

    public bool? AuthoriserIsJuniorStaff { get; set; }

    public bool? AuthoriserIsManagementStaff { get; set; }

    public bool? AuthoriserIsServicePerson { get; set; }

    public bool? AuthoriserIsVoluntaryPerson { get; set; }

    public bool? AuthoriserShowInTelDir { get; set; }

    public DateTime FmgDateAuthorised { get; set; }

    public string FmgDateAcknowledged { get; set; } = null!;

    public bool FmgAcknowledged { get; set; }

    public bool FmgAuthorised { get; set; }

    public int DispenserEmpId { get; set; }

    public string DispenserStaffNo { get; set; } = null!;

    public string DispenserLname { get; set; } = null!;

    public string DispenserFname { get; set; } = null!;

    public string DispenserOnames { get; set; } = null!;

    public string DispenserHrmsName { get; set; } = null!;

    public string DispenserEmpName { get; set; } = null!;

    public string DispenserEmpName1 { get; set; } = null!;

    public string DispenserEmpName2 { get; set; } = null!;

    public string DispenserMobNox { get; set; } = null!;

    public string DispenserMobNo { get; set; } = null!;

    public bool DispenserHideMobNo { get; set; }

    public string DispenserPlc { get; set; } = null!;

    public bool DispenserIsDirector { get; set; }

    public bool DispenserIsManager { get; set; }

    public bool DispenserIsSupervisor { get; set; }

    public bool DispenserIsStaff { get; set; }

    public bool DispenserIsSeniorStaff { get; set; }

    public bool DispenserIsJuniorStaff { get; set; }

    public bool DispenserIsManagementStaff { get; set; }

    public bool DispenserIsServicePerson { get; set; }

    public bool DispenserIsVoluntaryPerson { get; set; }

    public int DispneserEmpId { get; set; }

    public int DispenserDptId { get; set; }

    public string DispenserDptName { get; set; } = null!;

    public string DispenserDptShtName { get; set; } = null!;

    public int DispenserSxnId { get; set; }

    public string DispenserSxnName { get; set; } = null!;

    public string DispenserSxnShtName { get; set; } = null!;

    public string FmgDeleteRmks { get; set; } = null!;

    public int FmgDebitDeptIdfk { get; set; }

    public int FmgDebitSectionIdfk { get; set; }

    public int FmgCostCenterIdfk { get; set; }

    public bool PcmFuelDump { get; set; }

    public bool PcmPettyCash { get; set; }

    public bool PcmCard { get; set; }

    public string FmgDispenserRmks { get; set; } = null!;

    public DateTime FmgDateDispensed { get; set; }

    public int? FmgDispenserEmpIdfk { get; set; }

    public decimal FmgQuantityAuthorised { get; set; }

    public string FmgAuthoriserRmks { get; set; } = null!;

    public int? FunIdpk { get; set; }

    public string? FunName { get; set; }

    public string? FunShtName { get; set; }

    public bool? FunActive { get; set; }

    public string? FunRmks { get; set; }

    public int? FmgFuelUnitIdfk { get; set; }

    public bool FmgCancelled { get; set; }

    public int CctIdpk { get; set; }

    public string CctName { get; set; } = null!;

    public string CctShtName { get; set; } = null!;

    public int CctGroupIdfk { get; set; }

    public string CctCode { get; set; } = null!;

    public bool CctActive { get; set; }

    public int CostCenterDeptId { get; set; }

    public string CostCenterDeptName { get; set; } = null!;

    public string CostCenterDeptShtName { get; set; } = null!;

    public int CostCenterSxnId { get; set; }

    public string CostCenterSxnName { get; set; } = null!;

    public string CostCenterSxnShtName { get; set; } = null!;

    public string CostCenterSxnCode { get; set; } = null!;

    public string CostCenterDeptCode { get; set; } = null!;

    public int CostCenterUnitId { get; set; }

    public string CostCenterUnitName { get; set; } = null!;

    public string CostCenterUnitShtName { get; set; } = null!;

    public string CostCenterUnitCode { get; set; } = null!;

    public int CcgIdpk { get; set; }

    public string CcgName { get; set; } = null!;

    public string CcgShtName { get; set; } = null!;

    public bool CcgActive { get; set; }

    public int PrdIdpk { get; set; }

    public string? PrdName { get; set; }

    public string? PrdShtName { get; set; }

    public bool? PrdActive { get; set; }

    public DateTime? Expr1 { get; set; }

    public int? FmgCommitDays { get; set; }

    public decimal? FmgCommitDaysx { get; set; }

    public int? FmgCommitHours { get; set; }
}
