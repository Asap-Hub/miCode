using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsVehicleSimcardsAssignment
{
    public int VsaIdpk { get; set; }

    public int? VsaVendorIdfk { get; set; }

    public int? VsaVehicleDetailIdfk { get; set; }

    public DateTime? VsaStartDate { get; set; }

    public DateTime? VsaEndDate { get; set; }

    public string? VsaMobNo { get; set; }

    public bool? VsaActive { get; set; }

    public string? VsaRmks { get; set; }

    public int VdtIdpk { get; set; }

    public string VdtRegNo { get; set; } = null!;

    public string VdtChassisNo { get; set; } = null!;

    public decimal VdtCubicCapacity { get; set; }

    public decimal VdtTankCapacity { get; set; }

    public string VdtEngineNo { get; set; } = null!;

    public DateTime VdtSupplyDate { get; set; }

    public decimal? ManufactureAge { get; set; }

    public decimal? SupplyAge { get; set; }

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

    public bool? CurForeign { get; set; }

    public int? PwtIdpk { get; set; }

    public string? PwtName { get; set; }

    public string? PwtShtName { get; set; }

    public int? TrtIdpk { get; set; }

    public string? TrtName { get; set; }

    public string? TrtShtName { get; set; }

    public int CtyIdpk { get; set; }

    public string CtyName { get; set; } = null!;

    public string CtyShtName { get; set; } = null!;

    public int? MftIdpk { get; set; }

    public string? MftName { get; set; }

    public string? MftShtName { get; set; }

    public int? EgmIdpk { get; set; }

    public string? EgmName { get; set; }

    public string? EgmShtName { get; set; }

    public int PmWorkshopId { get; set; }

    public string PmWorkshopName { get; set; } = null!;

    public string PmWorkshopShtName { get; set; } = null!;

    public string PmWorkshopCode { get; set; } = null!;

    public int TvdIdpk { get; set; }

    public string? TvdName { get; set; }

    public string? TvdShtName { get; set; }

    public bool? TvdActive { get; set; }

    public string? TvdRmks { get; set; }

    public int? VsaTrackerUrlIdfk { get; set; }

    public int? TedIdpk { get; set; }

    public string TedVendor { get; set; } = null!;

    public bool TedActive { get; set; }

    public string TedTrackerUrl { get; set; } = null!;

    public string TedPlaybackUrl { get; set; } = null!;

    public string TedGeofenceUrl { get; set; } = null!;

    public string TedTargetInfoUrl { get; set; } = null!;

    public string TedTrackingReportUrl { get; set; } = null!;

    public string? Expr1 { get; set; }

    public string? Expr2 { get; set; }

    public string? Expr3 { get; set; }

    public string? Expr4 { get; set; }

    public string? Expr5 { get; set; }

    public string? TedCheckCommandUrl { get; set; }

    public string? Expr6 { get; set; }

    public bool? Expr7 { get; set; }

    public string? TedRmks { get; set; }
}
