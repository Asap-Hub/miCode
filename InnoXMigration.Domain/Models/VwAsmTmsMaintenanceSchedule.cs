using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsMaintenanceSchedule
{
    public int MtsIdpk { get; set; }

    public int? MtsVehicleDetailIdfk { get; set; }

    public int? MtsMaintenanceTypeIdfk { get; set; }

    public DateTime? MtsDate { get; set; }

    public int? MtsDeptIdfk { get; set; }

    public int? MtsSectionIdfk { get; set; }

    public int? MtsUnitIdfk { get; set; }

    public int? MtsDriverEmpIdfk { get; set; }

    public int? MtsOwnerEmpIdfk { get; set; }

    public bool? MtsPromptOwner { get; set; }

    public bool? MtsPromptDriver { get; set; }

    public bool? MtsActive { get; set; }

    public string? MtsRmks { get; set; }

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

    public int? VdtPowerTrainIdfk { get; set; }

    public string? VdtColour { get; set; }

    public int? VdtEngineTypeIdfk { get; set; }

    public byte VdtSeatingCapacity { get; set; }

    public bool? VdtActive { get; set; }

    public string? VdtRmks { get; set; }

    public string? VdtCreatedBy { get; set; }

    public int? VdtEditedBy { get; set; }

    public DateTime? VdtCreationDate { get; set; }

    public DateTime? VdtEditedDate { get; set; }

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

    public string? VmkRmks { get; set; }

    public string? VmkCreatedBy { get; set; }

    public int? VmkEditedBy { get; set; }

    public DateTime? VmkCreationDate { get; set; }

    public DateTime? VmkEditedDate { get; set; }

    public int? VmkVehicleClassIdfk { get; set; }

    public int? VhcIdpk { get; set; }

    public string? VhcName { get; set; }

    public string? VhcShtName { get; set; }

    public int? MftIdpk { get; set; }

    public string? MftName { get; set; }

    public string? MftShtName { get; set; }

    public int? VstIdpk { get; set; }

    public string? VstName { get; set; }

    public string? VstShtName { get; set; }

    public bool? VstFitStatus { get; set; }

    public int? SplIdpk { get; set; }

    public string? SplName { get; set; }

    public string? SplShtName { get; set; }

    public string? SplMainContact { get; set; }

    public string? SplMobNos { get; set; }

    public string? SplEmail { get; set; }

    public string? SplTelNos { get; set; }

    public string? SplPostalAddress { get; set; }

    public string? SplResidentialAddress { get; set; }

    public decimal VdtTankCapacity { get; set; }

    public int? FtpIdpk { get; set; }

    public string? FtpName { get; set; }

    public string? FtpShtName { get; set; }

    public int? EgtIdpk { get; set; }

    public string? EgtName { get; set; }

    public string? EgtShtName { get; set; }

    public int? CurIdpk { get; set; }

    public string? CurName { get; set; }

    public DateTime? CurDate { get; set; }

    public string? CurShtName { get; set; }

    public string? CurSymbol { get; set; }

    public bool? CurForeign { get; set; }

    public int? PwtIdpk { get; set; }

    public string? PwtName { get; set; }

    public string? PwtShtName { get; set; }

    public int? TrtIdpk { get; set; }

    public string? TrtName { get; set; }

    public string? TrtShtName { get; set; }

    public int? VdtTransmissionTypeIdfk { get; set; }

    public int MtpIdpk { get; set; }

    public string? MtpName { get; set; }

    public string? MtpShtName { get; set; }

    public int DriverEmpId { get; set; }

    public string? DriverStaffNo { get; set; }

    public string? DriverLname { get; set; }

    public string? DriverFname { get; set; }

    public string DriverOnames { get; set; } = null!;

    public string? DriverName { get; set; }

    public string? DriverName1 { get; set; }

    public string? DriverName2 { get; set; }

    public string? DriverName3 { get; set; }

    public string? DriverName4 { get; set; }

    public int DriverDptIdpk { get; set; }

    public string DriverDptName { get; set; } = null!;

    public string DriverDptShtName { get; set; } = null!;

    public int DriverSxnIdpk { get; set; }

    public string DriverSxnName { get; set; } = null!;

    public string DriverSxnShtName { get; set; } = null!;

    public int DriverUntIdpk { get; set; }

    public string DriverUnitName { get; set; } = null!;

    public string DriverUnitShtName { get; set; } = null!;

    public int DriverLocIdpk { get; set; }

    public string DriverLocName { get; set; } = null!;

    public string DriverLocShtName { get; set; } = null!;

    public string DriverDirTelNo { get; set; } = null!;

    public string DriverMobNo { get; set; } = null!;

    public string DriverMobNox { get; set; } = null!;

    public string DriverPlc { get; set; } = null!;

    public int DriverJbtIdpk { get; set; }

    public string DriverJbtName { get; set; } = null!;

    public string DriverJbtShtName { get; set; } = null!;

    public int DriverRomIdpk { get; set; }

    public string DriverRomName { get; set; } = null!;

    public string DriverRomShtName { get; set; } = null!;

    public int DriverOfcIdpk { get; set; }

    public string DriverOfcName { get; set; } = null!;

    public string DriverOfcShtName { get; set; } = null!;

    public bool DriverHideMobNo { get; set; }

    public int OwnerEmpId { get; set; }

    public string? OwnerStaffNo { get; set; }

    public string? OwnerLname { get; set; }

    public string? OwnerFname { get; set; }

    public string OwnerOnames { get; set; } = null!;

    public string OwnerHrmsName { get; set; } = null!;

    public string? OwnerName { get; set; }

    public string? OwnerName1 { get; set; }

    public string? OwnerName2 { get; set; }

    public string? OwnerName3 { get; set; }

    public string? OwnerName4 { get; set; }

    public int OwnerDptIdpk { get; set; }

    public string OwnerDptName { get; set; } = null!;

    public string OwnerDptShtName { get; set; } = null!;

    public int OwnerSxnIdpk { get; set; }

    public string OwnerSxnName { get; set; } = null!;

    public string OwnerSxnShtName { get; set; } = null!;

    public int OwnerUntIdpk { get; set; }

    public string OwnerUntName { get; set; } = null!;

    public string OwnerUntShtName { get; set; } = null!;

    public string OwnerDirTelNo { get; set; } = null!;

    public string OwnerMobNo { get; set; } = null!;

    public string OwnerPlc { get; set; } = null!;

    public int OwnerJbtIdpk { get; set; }

    public string OwnerJbtName { get; set; } = null!;

    public string OwnerJbtShtName { get; set; } = null!;

    public int OwnerOfcIdpk { get; set; }

    public string OwnerOfcName { get; set; } = null!;

    public string OwnerOfcShtName { get; set; } = null!;

    public int OwnerRomIdpk { get; set; }

    public string OwnerRomName { get; set; } = null!;

    public string OwnerRomShtName { get; set; } = null!;

    public string OwnerMobNox { get; set; } = null!;

    public bool OwnerHideMobNo { get; set; }

    public int? MtsMaintenanceLocIdfk { get; set; }

    public bool? MtsSmsSent { get; set; }

    public DateTime? MtsSmsDate { get; set; }

    public int WsdIdpk { get; set; }

    public string? WsdName { get; set; }

    public string? WsdShtName { get; set; }

    public string? WsdCode { get; set; }

    public string? WsdContact { get; set; }

    public string? WsdTelNo { get; set; }

    public int? WsdLocIdfk { get; set; }

    public bool? WsdActive { get; set; }

    public string? WsdRmks { get; set; }

    public int TwnIdpk { get; set; }

    public string? TwnName { get; set; }

    public string? TwnShtName { get; set; }

    public bool? TwnActive { get; set; }

    public string TwnRmks { get; set; } = null!;

    public int DstIdpk { get; set; }

    public string DstName { get; set; } = null!;

    public string DstShtName { get; set; } = null!;

    public int? RgnIdpk { get; set; }

    public string? RgnName { get; set; }

    public string? RgnShtName { get; set; }

    public int? CtyIdpk { get; set; }

    public string? CtyName { get; set; }

    public string? CtyShtName { get; set; }

    public string? CtyNationality { get; set; }

    public bool? CtyActive { get; set; }

    public string? RgnCapital { get; set; }

    public string? CtyCapital { get; set; }

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public bool? LocActive { get; set; }

    public int? AreIdpk { get; set; }

    public string AreName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;

    public byte MtsSmsCount { get; set; }

    public bool? MtsSend { get; set; }
}
