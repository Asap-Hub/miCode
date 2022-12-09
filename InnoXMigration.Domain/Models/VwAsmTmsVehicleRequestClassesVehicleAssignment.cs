using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsVehicleRequestClassesVehicleAssignment
{
    public int VcaIdpk { get; set; }

    public int? VcaVehicleDetailIdfk { get; set; }

    public int? VcaRequestClassIdfk { get; set; }

    public int? VcaRequestAreaIdfk { get; set; }

    public bool? VcaActive { get; set; }

    public string? VcaRmks { get; set; }

    public int VrcIdpk { get; set; }

    public string? VrcName { get; set; }

    public string? VrcShtName { get; set; }

    public bool? VrcActive { get; set; }

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

    public DateTime? VdtManufactureDate { get; set; }

    public DateTime VdtSupplyDate { get; set; }

    public bool VdtAssigned { get; set; }

    public decimal VdtPrice { get; set; }

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

    public int? PwtIdpk { get; set; }

    public string? PwtName { get; set; }

    public string? PwtShtName { get; set; }

    public int VraIdpk { get; set; }

    public string? VraName { get; set; }

    public string? VraShtName { get; set; }

    public string? VdtColour { get; set; }

    public byte VdtSeatingCapacity { get; set; }

    public bool? VdtActive { get; set; }

    public int DriverEmpId { get; set; }

    public string DriverStaffNo { get; set; } = null!;

    public string DriverLname { get; set; } = null!;

    public string DriverFname { get; set; } = null!;

    public string DriverEmpName5 { get; set; } = null!;

    public string DriverPlc { get; set; } = null!;

    public int OwnerEmpId { get; set; }

    public string OwnerStaffNo { get; set; } = null!;

    public string OwnerLname { get; set; } = null!;

    public string OwnerFname { get; set; } = null!;

    public string OwnerEmpName5 { get; set; } = null!;

    public string OwnerPlc { get; set; } = null!;

    public int? MftIdpk { get; set; }

    public string? MftName { get; set; }

    public string? MftShtName { get; set; }
}
