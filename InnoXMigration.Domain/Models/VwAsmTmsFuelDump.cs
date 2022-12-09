using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsFuelDump
{
    public int FdmIdpk { get; set; }

    public int? FdmVehicleDetailIdfk { get; set; }

    public DateTime? FdmDate { get; set; }

    public int? FdmServiceProviderIdfk { get; set; }

    public int? FdmServiceStationIdfk { get; set; }

    public int? FdmProductIdfk { get; set; }

    public decimal? FdmBalance { get; set; }

    public decimal? FdmQuantity { get; set; }

    public decimal? FdmUnitPrice { get; set; }

    public decimal? FdmTotalAmount { get; set; }

    public decimal? FdmCurrentOdometerReading { get; set; }

    public decimal? FdmPreviousOdometerReading { get; set; }

    public decimal? FdmDistance { get; set; }

    public int? FdmVehicleAssignIdfk { get; set; }

    public int? FdmReceiverEmpIdfk { get; set; }

    public int? FdmAuthoriserEmpIdfk { get; set; }

    public bool FdmDeleted { get; set; }

    public bool FdmAuthorised { get; set; }

    public bool FdmAcknowledged { get; set; }

    public bool FdmActive { get; set; }

    public string FdmRmks { get; set; } = null!;

    public int PrdIdpk { get; set; }

    public string? PrdName { get; set; }

    public string? PrdShtName { get; set; }

    public int? PrdServiceProviderIdfk { get; set; }

    public bool? PrdActive { get; set; }

    public string? PrdRmks { get; set; }

    public string? PrdCreatedBy { get; set; }

    public bool? CardSpdActive { get; set; }

    public int VdtIdpk { get; set; }

    public string VdtRegNo { get; set; } = null!;

    public string VdtChassisNo { get; set; } = null!;

    public int? VdtModelIdfk { get; set; }

    public int? VdtSupplierIdfk { get; set; }

    public int? VdtStatusIdfk { get; set; }

    public DateTime? VdtManufactureDate { get; set; }

    public DateTime VdtSupplyDate { get; set; }

    public bool VdtAssigned { get; set; }

    public decimal VdtPrice { get; set; }

    public int? VdtPriceCurrencyIdfk { get; set; }

    public int? VdtEngineTypeIdfk { get; set; }

    public int? VdtPowerTrainIdfk { get; set; }

    public int? VdtFuelTypeIdfk { get; set; }

    public string? VdtColour { get; set; }

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

    public int ReceiverEmpId { get; set; }

    public string? ReceiverStaffNo { get; set; }

    public string? ReceiverLname { get; set; }

    public string? ReceiverFname { get; set; }

    public string ReceiverOnames { get; set; } = null!;

    public string ReceiverHrmsName { get; set; } = null!;

    public string? ReceiverEmpName { get; set; }

    public string? ReceiverEmpName1 { get; set; }

    public string? ReceiverEmpName2 { get; set; }

    public string ReceiverMobNox { get; set; } = null!;

    public bool ReceiverMobNo { get; set; }

    public string ReceiverPlc { get; set; } = null!;

    public bool ReceiverIsDirector { get; set; }

    public bool ReceiverIsManager { get; set; }

    public bool ReceiverIsSupervisor { get; set; }

    public bool ReceiverIsStaff { get; set; }

    public bool ReceiverIsSeniorStaff { get; set; }

    public bool ReceiverIsJuniorStaff { get; set; }

    public bool ReceiverIsManagementStaff { get; set; }

    public bool ReceiverIsServicePerson { get; set; }

    public bool ReceiverIsVoluntaryPerson { get; set; }

    public bool ReceiverShowInTelDir { get; set; }

    public int DispenserEmpId { get; set; }

    public string? DispenserStaffNo { get; set; }

    public string? DispenserLname { get; set; }

    public string? DispenserFname { get; set; }

    public string DispenserOnames { get; set; } = null!;

    public string DispenserHrmsName { get; set; } = null!;

    public string? DispenserEmpName { get; set; }

    public string? DispenserEmpName1 { get; set; }

    public string? DispenserEmpName2 { get; set; }

    public string DispenserMobNox { get; set; } = null!;

    public bool DispenserMobNo { get; set; }

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

    public bool DispenserShowInTelDir { get; set; }

    public int? AuthoriserEmpId { get; set; }

    public string? AuthoriserStaffNo { get; set; }

    public string? AuthoriserLname { get; set; }

    public string? AuthoriserFname { get; set; }

    public string? AuthoriserOnames { get; set; }

    public string? AuthoriserHrmsName { get; set; }

    public string? AuthoriserEmpName { get; set; }

    public string? AuthoriserEmpName1 { get; set; }

    public string? AuthoriserEmpName2 { get; set; }

    public string? AuthoriserMobNox { get; set; }

    public bool? AuthoriserMobNo { get; set; }

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

    public bool? VstFitStatus { get; set; }

    public string? FdmReceiptNo { get; set; }

    public int? FdmCreatedBy { get; set; }

    public DateTime? FdmCreationDate { get; set; }

    public DateTime? FdmEditedDate { get; set; }

    public bool FdmLocked { get; set; }

    public int? FdmLockedByEmpIdfk { get; set; }

    public DateTime? FdmLockDate { get; set; }

    public int SstIdpk { get; set; }

    public string? SstName { get; set; }

    public string? SstShtName { get; set; }

    public string? SstStationNo { get; set; }

    public int? SstServiceProviderIdfk { get; set; }

    public int? SstTownIdfk { get; set; }

    public bool? SstActive { get; set; }

    public string? SstRmks { get; set; }

    public string? SstCreatedBy { get; set; }

    public int? SstEditedBy { get; set; }

    public int TwnIdpk { get; set; }

    public int SpdIdpk { get; set; }

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

    public DateTime? FdmDateAuthorised { get; set; }

    public DateTime? FdmDateAcknowledged { get; set; }
}
