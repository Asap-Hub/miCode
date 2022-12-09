using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsCardAssignment
{
    public int CasIdpk { get; set; }

    public int? CasVehicleDetailIdfk { get; set; }

    public int? CasCardDetailIdfk { get; set; }

    public DateTime? CasAssignDate { get; set; }

    public DateTime? CasEndDate { get; set; }

    public bool? CasActive { get; set; }

    public string? CasRmks { get; set; }

    public int CdtIdpk { get; set; }

    public string CdtCardNo { get; set; } = null!;

    public string? CdtIssueDate { get; set; }

    public string? CdtExpiryDate { get; set; }

    public int? CdtServiceProviderIdfk { get; set; }

    public int? CdtTownIdfk { get; set; }

    public bool? CdtActive { get; set; }

    public string CdtRmks { get; set; } = null!;

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

    public bool VdtAssigned { get; set; }

    public decimal VdtPrice { get; set; }

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

    public int CtyIdpk { get; set; }

    public string CtyName { get; set; } = null!;

    public string CtyShtName { get; set; } = null!;

    public int? MftIdpk { get; set; }

    public string? MftName { get; set; }

    public string? MftShtName { get; set; }

    public int? EgmIdpk { get; set; }

    public string? EgmName { get; set; }

    public string? EgmShtName { get; set; }

    public int? SpdIdpk { get; set; }

    public string? SpdName { get; set; }

    public string? SpdShtName { get; set; }

    public string? SpdMainContact { get; set; }

    public string? SpdMobNos { get; set; }

    public string? SpdEmail { get; set; }

    public string? SpdTelNos { get; set; }

    public int? TwnIdpk { get; set; }

    public string? TwnName { get; set; }

    public string? TwnShtName { get; set; }
}
